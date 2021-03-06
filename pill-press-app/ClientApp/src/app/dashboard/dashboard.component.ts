import { Component, OnInit } from '@angular/core';
import { UserDataService } from '../services/user-data.service';
import { User } from '../models/user.model';
import { Router } from '@angular/router';
import { Application } from '../models/application.model';
import { DynamicsDataService } from '../services/dynamics-data.service';
import { ApplicationDataService } from '../services/application-data.service';
import { EquipmentDataService } from '../services/equipment-data-service';
import { DynamicsAccount } from '../models/dynamics-account.model';
import { Subscription } from 'rxjs';
import { MatSnackBar } from '@angular/material';

import {
  faExclamationCircle,
  faFileAlt,
  faPencilAlt,
  faExclamationTriangle,
  faShoppingCart,
  faEye,
  faMapMarkerAlt
} from '@fortawesome/free-solid-svg-icons';

import {
  faFilePdf,
} from '@fortawesome/free-regular-svg-icons';
import { Certificate } from '../models/certificate.model';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {
  public currentUser: User;
  applicationId: string;
  submittedApplications = 8;

  contactId: string = null;
  account: DynamicsAccount;
  busy; busy2: Subscription;
  isPaid: Boolean;
  orgType = '';

  inProgressEquipment: any[] = [];
  allCompletedEquipment: any[] = [];
  completedEquipment: any[] = [];
  waiverApplication: any;
  authorizedOwnerApplication: Application;
  registeredSellerApplication: any;

  faExclamationTriangle = faExclamationTriangle;
  faShoppingCart = faShoppingCart;
  faEye = faEye;
  faMapMarkerAlt = faMapMarkerAlt;
  faPencilAlt = faPencilAlt;
  faFileAlt = faFileAlt;
  faExclamationCircle = faExclamationCircle;
  faFilePdf = faFilePdf;
  sellerCertificate: Certificate;
  waiverHolderCertificate: Certificate;

  constructor(private userDataService: UserDataService, private router: Router,
    private dynamicsDataService: DynamicsDataService,
    private applicationDataService: ApplicationDataService,
    private equipmentDataService: EquipmentDataService,
    public snackBar: MatSnackBar) { }

  /**
   *
   */
  ngOnInit(): void {
    this.busy = this.userDataService.getCurrentUser()
      .subscribe((data) => {
        this.currentUser = data;
        if (this.currentUser.accountid != null) {
          // fetch the account to get the primary contact.
          this.busy = this.dynamicsDataService.getRecord('account', this.currentUser.accountid)
            .subscribe((result: DynamicsAccount) => {
              this.account = result;
              if (result.primaryContact) {
                this.contactId = result.primaryContact.id;
              }
            });
        }
      });

    this.busy = this.applicationDataService.getApplications()
      .subscribe((data: Application[]) => {

        data.forEach((app: any) => {
          app.certificates = app.certificates || [];
          if (app.certificates.length > 0) {
            app.certificates.sort(this.dateSort);
            app.certificate = app.certificates[0];
            app.certificate.hasExpired = (new Date(app.certificate.expiryDate) < new Date());
          }

          // an equipment record on the dashboard must be grayed out when the corresponding application status
          // is NOT "Draft" or "Cancelled" and the application type is an equipment change.
          const pendingChanges = data.filter(a => a.equipmentRecord && app.equipmentRecord
            && a.equipmentRecord.id === app.equipmentRecord.id && a.applicationtype === 'Equipment Change'
            && a.statuscode !== 'Draft' && a.statuscode !== 'Cancelled');
          app.hasChangePending = (pendingChanges.length > 0);
          if (pendingChanges.length > 0) {
            const lsdChanges = pendingChanges.filter(c => ['Lost', 'Stolen', 'Destroyed'].indexOf(c.typeOfChange) !== -1);
            if (lsdChanges.length > 0) {
              app.lsdLinkId = lsdChanges[0].id;
            }
            const soldChanges = pendingChanges.filter(c => ['Sold'].indexOf(c.typeOfChange) !== -1);
            if (soldChanges.length > 0) {
              app.soldLinkId = soldChanges[0].id;
            }
          }
        });

        data.forEach((app: any) => {
          if (app.certificate) {
            this.applicationDataService.doesCertificateExist(app.id).subscribe(result => {
              app.hasCertificate = result;
            });
          }
        });

        const authorizedOwners = data.filter(a => a.applicationtype === 'Authorized Owner');
        if (authorizedOwners.length > 0) {
          // get latest application
          this.authorizedOwnerApplication = authorizedOwners.sort((a, b) => a.createdon > b.createdon ? -1 : 1)[0];
        }

        const sellers = data.filter(a => a.applicationtype === 'Registered Seller');
        this.sellerCertificate = this.getLatestCertificate(sellers);
        if (sellers.length > 0) {
          // get latest application
          this.registeredSellerApplication = sellers.sort((a, b) => a.createdon > b.createdon ? -1 : 1)[0];
          // overide status if certificate has expired
          if (this.registeredSellerApplication.certificate && this.registeredSellerApplication.certificate.hasExpired) {
            this.registeredSellerApplication.statuscode = 'Expired';
          }
        }

        const waivers = data.filter(a => a.applicationtype === 'Waiver');
        this.waiverHolderCertificate = this.getLatestCertificate(waivers);
        if (waivers.length > 0) {
          // get latest application
          this.waiverApplication = waivers.sort((a, b) => a.createdon > b.createdon ? -1 : 1)[0];
          // overide status if certificate has expired
          if (this.waiverApplication.certificate && this.waiverApplication.certificate.hasExpired) {
            this.waiverApplication.statuscode = 'Expired';
          }
        }

        this.inProgressEquipment = data.filter(a => a.applicationtype === 'Equipment Notification' && a.statuscode !== 'Approved');
        this.allCompletedEquipment = data.filter(a => a.applicationtype === 'Equipment Notification' && a.statuscode === 'Approved');

        /* When equipment is lost, stolen, destroyed or sold and the application is approved then the equipment is assinged
         * to a different business profile (account).
         * Because the application (equipment notification) will always have the intial business profile associated with the equipment,
         * it's required to check if the equipment is still associated with the same business profile (account).
         */

        //only add equipment applications to the completedEquipment array
        //when the current equipment business profile matches the application business profile
        this.allCompletedEquipment.forEach((equipmentApp: any, index) => {
          this.busy = this.equipmentDataService.getEquipment(equipmentApp.equipmentRecord.id).subscribe(equipmentResponse => {
            if (equipmentResponse.bcgovCurrentBusinessOwner.id === this.currentUser.accountid) {
              //only add completed equipment that belong to this business profile (account)
              //set the location to the equipment current location (the original application might be different because of a location change)
              equipmentApp.equipmentLocation = equipmentResponse.bcgovCurrentLocation;
              this.completedEquipment.push(equipmentApp);
            }
          });
        });
      });
  }

  /**
   * Get the latest certificate
   * @param applications
   */
  getLatestCertificate(applications: any[]): Certificate {
    applications = applications || [];
    const certificates = [];
    applications.forEach(app => {
      if (app.certificate) {
        certificates.push({ applicationId: app.id, certificate: app.certificate });
      }
    });

    if (certificates.length > 0) {
      // get latest certificate
      const latest = certificates.sort((a, b) => a.certificate.issueDate > b.certificate.issueDate ? -1 : 1)[0];
      const certificate: Certificate = latest.certificate;
      // check if the certificate is downloadable
      this.busy = this.applicationDataService.doesCertificateExist(latest.applicationId).subscribe(result => {
        certificate.hasCertificate = result;
      });
      return certificate;
    } else {
      return null;
    }

  }

  /**
   * 
   * @param a
   * @param b
   */
  dateSort(a, b) {
    if (a.issueDate > b.issueDate) {
      return 1;
    } else {
      return -1;
    }
  }

  /**
   *
   */
  isAuthorizedApplicationPending() {
    return this.authorizedOwnerApplication
      && this.authorizedOwnerApplication.statuscode !== 'Draft'
      && this.authorizedOwnerApplication.statuscode !== 'Withdrawn'
      && this.authorizedOwnerApplication.statuscode !== 'Approved'
      && this.authorizedOwnerApplication.statuscode !== 'Cancelled'
      && this.authorizedOwnerApplication.statuscode !== 'Denied';
  }

  /**
   * Is Waiver or Seller Under Review
   * @param statuscode
   */
  isWaiverOrSellerUnderReview(statuscode: string) {
    return statuscode
      && (
        statuscode === 'Under Review'
        || statuscode === 'With Risk Assessment'
        || statuscode === 'With C&E Investigations'
        || statuscode === 'With Deputy Registrar'
      );
  }

  /**
   * Create a waiver application.
   * Status initiates as draft
   * @param applicationReasoncode
   */
  startNewWaiverApplication(applicationReasoncode: string) {
    const newLicenceApplicationData: Application = <Application>{
      statuscode: 'Draft', // initiate as draft
      applicationreasoncode: applicationReasoncode // first time = 'New', next times = 'Renew'
    };
    this.busy = this.applicationDataService.createApplication(newLicenceApplicationData, 'Waiver').subscribe(
      data => {
        this.router.navigateByUrl(`/waiver/profile-review/${data.id}`);
      },
      err => {
        this.snackBar.open('Error starting a New Licence Application', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
        console.log('Error starting a New Licence Application');
      }
    );
  }

  /**
   * Create an authorized owner application.
   * Status initiates as draft
   * @param applicationReasoncode
   */
  startNewAuthorizedOwnerApplication(applicationReasoncode: string) {
    const newLicenceApplicationData: Application = <Application>{
      statuscode: 'Draft', // initiate as draft
      applicationreasoncode: applicationReasoncode // first time = 'New', next times = 'Re-Notify'
    };
    this.busy = this.applicationDataService.createApplication(newLicenceApplicationData, 'Authorized Owner').subscribe(
      data => {
        this.router.navigateByUrl(`/authorized-owner/profile-review/${data.id}`);
      },
      err => {
        this.snackBar.open('Error starting a New Authorized Owner Application', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
        console.log('Error starting a New Authorized Owner Application');
      }
    );
  }

  /**
   * Create a registerd seller application.
   * Status initiates as draft
   * @param applicationReasoncode
   */
  startNewASellerApplication(applicationReasoncode: string) {
    const newLicenceApplicationData: Application = <Application>{
      statuscode: 'Draft', // initiate as draft
      applicationreasoncode: applicationReasoncode // first time = 'New', next times = 'Renew'
    };
    this.busy = this.applicationDataService.createApplication(newLicenceApplicationData, 'Registered Seller').subscribe(
      data => {
        this.router.navigateByUrl(`/registered-seller/profile-review/${data.id}`);
      },
      err => {
        this.snackBar.open('Error starting a New Registered Seller Application', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
        console.log('Error starting a Registered Seller Application');
      }
    );
  }

  /**
   * Determine if Equipment data (table) should be displayed for the business profile
   *
   * Don't show equipment if no approved ownership category or an equipment notification has been completed ???
   */
  showEquipmentTables() {
    const show = (this.authorizedOwnerApplication && this.authorizedOwnerApplication.statuscode === 'Approved')
      || (this.waiverApplication && this.waiverApplication.statuscode === 'Approved')
      || (this.registeredSellerApplication && this.registeredSellerApplication.statuscode === 'Approved')
      //|| (this.inProgressEquipment.length > 0)
      || (this.completedEquipment.length > 0);
    return show;
  }

  /**
   * Add new equipment to the business profile
   */
  addEquipment() {
    const newLicenceApplicationData: Application = <Application>{
      statuscode: 'Draft'
    };
    this.busy2 = this.applicationDataService.createApplication(newLicenceApplicationData, 'Equipment Notification').subscribe(
      data => {
        this.router.navigateByUrl(`/equipment-notification/profile-review/${data.id}`);
      },
      err => {
        this.snackBar.open('Error starting a New Equipment Notificatio Application',
          'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
        console.log('Error starting a Registered Seller Application');
      }
    );
  }

  /**
   * New report sale
   * @param equipmentId
   */
  newReportSale(equipmentId: string) {
    // TODO: Link the equipment to the application
    const newLicenceApplicationData: Application = <Application>{
      statuscode: 'Draft',
      typeOfChange: 'Sold',
      equipmentRecord: {
        id: equipmentId
      }
    };
    this.busy2 = this.applicationDataService.createApplication(newLicenceApplicationData, 'Equipment Change').subscribe(
      data => {
        this.router.navigateByUrl(`/equipment-changes/reporting-sales/details/${data.id}`);
      },
      err => {
        this.snackBar.open('Error starting a Reporting Sales Application', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
        console.log('Error starting Reporting Sales Application');
      }
    );
  }

  /**
   * New Report Change LSD (Lost, Stolen, Destroyed)
   * @param equipmentId
   */
  newReportChangeLSD(equipmentId: string) {
    const newLicenceApplicationData: Application = <Application>{
      statuscode: 'Draft',
      //typeOfChange: 'Lost',
      equipmentRecord: {
        id: equipmentId
      }
    };
    this.busy2 = this.applicationDataService.createApplication(newLicenceApplicationData, 'Equipment Change').subscribe(
      data => {
        this.router.navigateByUrl(`/equipment-changes/reporting-changes/details/${data.id}`);
      },
      err => {
        this.snackBar.open('Error starting a Reporting Sales Application', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
        console.log('Error starting Reporting Sales Application');
      }
    );
  }

  /**
   * Navigate to the equipment notification application
   * @param applicationId
   */
  viewSubmission(applicationId) {
    //alert("View submission " + applicationId);
    this.router.navigateByUrl('/equipment-notification/review/' + applicationId);
  }

}
