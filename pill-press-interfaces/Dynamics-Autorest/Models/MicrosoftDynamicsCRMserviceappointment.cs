// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.PillPressRegistry.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.serviceappointment
    /// </summary>
    public partial class MicrosoftDynamicsCRMserviceappointment
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMserviceappointment class.
        /// </summary>
        public MicrosoftDynamicsCRMserviceappointment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMserviceappointment class.
        /// </summary>
        /// <param name="category">Type a category to identify the service
        /// activity type, such as routine maintenance or service call, to tie
        /// the service activity to a business group or function.</param>
        /// <param name="importsequencenumber">Unique identifier of the data
        /// import or data migration that created this record.</param>
        /// <param name="subcategory">Type a subcategory to identify the
        /// service activity type and relate the activity to a specific
        /// product, service region, business group, or other function.</param>
        /// <param name="isalldayevent">Select whether the service activity is
        /// an all-day event to make sure the required resources are scheduled
        /// for the full day.</param>
        /// <param name="location">Type the location where the service activity
        /// will take place, such as a conference room, customer office, or
        /// other venue.</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="subscriptionid">For internal use only.</param>
        /// <param name="_siteidValue">Choose the site or location where the
        /// service activity will be performed.</param>
        public MicrosoftDynamicsCRMserviceappointment(string category = default(string), int? importsequencenumber = default(int?), string subcategory = default(string), bool? isalldayevent = default(bool?), string location = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string subscriptionid = default(string), string _siteidValue = default(string), MicrosoftDynamicsCRMentitlement regardingobjectidEntitlementServiceappointment = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMentitlementtemplate regardingobjectidEntitlementtemplateServiceappointment = default(MicrosoftDynamicsCRMentitlementtemplate), MicrosoftDynamicsCRMbookableresourcebooking regardingobjectidBookableresourcebookingServiceappointment = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader regardingobjectidBookableresourcebookingheaderServiceappointment = default(MicrosoftDynamicsCRMbookableresourcebookingheader), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecordServiceappointment = default(MicrosoftDynamicsCRMknowledgebaserecord), MicrosoftDynamicsCRMaccount regardingobjectidAccountServiceappointment = default(MicrosoftDynamicsCRMaccount), IList<MicrosoftDynamicsCRMslakpiinstance> slakpiinstanceServiceappointment = default(IList<MicrosoftDynamicsCRMslakpiinstance>), IList<MicrosoftDynamicsCRMactivityparty> serviceappointmentActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), MicrosoftDynamicsCRMservice serviceidServiceappointment = default(MicrosoftDynamicsCRMservice), IList<MicrosoftDynamicsCRMbulkdeletefailure> serviceAppointmentBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMsyncerror> serviceAppointmentSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMsystemuser createdonbehalfbyServiceappointment = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMincident regardingobjectidIncidentServiceappointment = default(MicrosoftDynamicsCRMincident), IList<MicrosoftDynamicsCRMconnection> serviceappointmentConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMsystemuser owninguserServiceappointment = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsalesorder regardingobjectidSalesorderServiceappointment = default(MicrosoftDynamicsCRMsalesorder), IList<MicrosoftDynamicsCRMasyncoperation> serviceAppointmentAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMcontact regardingobjectidContactServiceappointment = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMconnection> serviceappointmentConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMcontract regardingobjectidContractServiceappointment = default(MicrosoftDynamicsCRMcontract), IList<MicrosoftDynamicsCRMactioncard> serviceappointmentActioncard = default(IList<MicrosoftDynamicsCRMactioncard>), MicrosoftDynamicsCRMcampaign regardingobjectidCampaignServiceappointment = default(MicrosoftDynamicsCRMcampaign), IList<MicrosoftDynamicsCRMqueueitem> serviceAppointmentQueueItem = default(IList<MicrosoftDynamicsCRMqueueitem>), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunityServiceappointment = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMquote regardingobjectidQuoteServiceappointment = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticleServiceappointment = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMsite siteid = default(MicrosoftDynamicsCRMsite), MicrosoftDynamicsCRMsystemuser createdbyServiceappointment = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyidServiceappointment = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsla sLAId = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMannotation> serviceAppointmentAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMsystemuser modifiedbyServiceappointment = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteamServiceappointment = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyServiceappointment = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMinvoice regardingobjectidInvoiceServiceappointment = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMsla slainvokedidServiceappointmentSla = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMbusinessunit owningbusinessunitServiceappointment = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMlead regardingobjectidLeadServiceappointment = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMabsScheduledprocess regardingobjectidAbsScheduledprocessServiceappointment = default(MicrosoftDynamicsCRMabsScheduledprocess), MicrosoftDynamicsCRMbcgovCustomaddress regardingobjectidBcgovCustomaddressServiceappointment = default(MicrosoftDynamicsCRMbcgovCustomaddress), MicrosoftDynamicsCRMbcgovCustomproduct regardingobjectidBcgovCustomproductServiceappointment = default(MicrosoftDynamicsCRMbcgovCustomproduct), MicrosoftDynamicsCRMbcgovEquipment regardingobjectidBcgovEquipmentServiceappointment = default(MicrosoftDynamicsCRMbcgovEquipment), MicrosoftDynamicsCRMbcgovEquipmentlocation regardingobjectidBcgovEquipmentlocationServiceappointment = default(MicrosoftDynamicsCRMbcgovEquipmentlocation), MicrosoftDynamicsCRMbcgovLocation regardingobjectidBcgovLocationServiceappointment = default(MicrosoftDynamicsCRMbcgovLocation), MicrosoftDynamicsCRMbcgovRiskassessment regardingobjectidBcgovRiskassessmentServiceappointment = default(MicrosoftDynamicsCRMbcgovRiskassessment), MicrosoftDynamicsCRMbcgovInspection regardingobjectidBcgovInspectionServiceappointment = default(MicrosoftDynamicsCRMbcgovInspection), MicrosoftDynamicsCRMbcgovComplaint regardingobjectidBcgovComplaintServiceappointment = default(MicrosoftDynamicsCRMbcgovComplaint), MicrosoftDynamicsCRMbcgovViolationticket regardingobjectidBcgovViolationticketServiceappointment = default(MicrosoftDynamicsCRMbcgovViolationticket), MicrosoftDynamicsCRMbcgovInvestigationstep regardingobjectidBcgovInvestigationstepServiceappointment = default(MicrosoftDynamicsCRMbcgovInvestigationstep), MicrosoftDynamicsCRMbcgovInvestigation regardingobjectidBcgovInvestigationServiceappointment = default(MicrosoftDynamicsCRMbcgovInvestigation))
        {
            Category = category;
            Importsequencenumber = importsequencenumber;
            Subcategory = subcategory;
            Isalldayevent = isalldayevent;
            Location = location;
            Overriddencreatedon = overriddencreatedon;
            Subscriptionid = subscriptionid;
            this._siteidValue = _siteidValue;
            RegardingobjectidEntitlementServiceappointment = regardingobjectidEntitlementServiceappointment;
            RegardingobjectidEntitlementtemplateServiceappointment = regardingobjectidEntitlementtemplateServiceappointment;
            RegardingobjectidBookableresourcebookingServiceappointment = regardingobjectidBookableresourcebookingServiceappointment;
            RegardingobjectidBookableresourcebookingheaderServiceappointment = regardingobjectidBookableresourcebookingheaderServiceappointment;
            RegardingobjectidKnowledgebaserecordServiceappointment = regardingobjectidKnowledgebaserecordServiceappointment;
            RegardingobjectidAccountServiceappointment = regardingobjectidAccountServiceappointment;
            SlakpiinstanceServiceappointment = slakpiinstanceServiceappointment;
            ServiceappointmentActivityParties = serviceappointmentActivityParties;
            ServiceidServiceappointment = serviceidServiceappointment;
            ServiceAppointmentBulkDeleteFailures = serviceAppointmentBulkDeleteFailures;
            ServiceAppointmentSyncErrors = serviceAppointmentSyncErrors;
            CreatedonbehalfbyServiceappointment = createdonbehalfbyServiceappointment;
            RegardingobjectidIncidentServiceappointment = regardingobjectidIncidentServiceappointment;
            ServiceappointmentConnections2 = serviceappointmentConnections2;
            OwninguserServiceappointment = owninguserServiceappointment;
            RegardingobjectidSalesorderServiceappointment = regardingobjectidSalesorderServiceappointment;
            ServiceAppointmentAsyncOperations = serviceAppointmentAsyncOperations;
            RegardingobjectidContactServiceappointment = regardingobjectidContactServiceappointment;
            ServiceappointmentConnections1 = serviceappointmentConnections1;
            ActivityidActivitypointer = activityidActivitypointer;
            RegardingobjectidContractServiceappointment = regardingobjectidContractServiceappointment;
            ServiceappointmentActioncard = serviceappointmentActioncard;
            RegardingobjectidCampaignServiceappointment = regardingobjectidCampaignServiceappointment;
            ServiceAppointmentQueueItem = serviceAppointmentQueueItem;
            RegardingobjectidOpportunityServiceappointment = regardingobjectidOpportunityServiceappointment;
            RegardingobjectidQuoteServiceappointment = regardingobjectidQuoteServiceappointment;
            RegardingobjectidKnowledgearticleServiceappointment = regardingobjectidKnowledgearticleServiceappointment;
            Siteid = siteid;
            CreatedbyServiceappointment = createdbyServiceappointment;
            TransactioncurrencyidServiceappointment = transactioncurrencyidServiceappointment;
            SLAId = sLAId;
            ServiceAppointmentAnnotation = serviceAppointmentAnnotation;
            ModifiedbyServiceappointment = modifiedbyServiceappointment;
            OwningteamServiceappointment = owningteamServiceappointment;
            ModifiedonbehalfbyServiceappointment = modifiedonbehalfbyServiceappointment;
            RegardingobjectidInvoiceServiceappointment = regardingobjectidInvoiceServiceappointment;
            SlainvokedidServiceappointmentSla = slainvokedidServiceappointmentSla;
            OwningbusinessunitServiceappointment = owningbusinessunitServiceappointment;
            RegardingobjectidLeadServiceappointment = regardingobjectidLeadServiceappointment;
            RegardingobjectidAbsScheduledprocessServiceappointment = regardingobjectidAbsScheduledprocessServiceappointment;
            RegardingobjectidBcgovCustomaddressServiceappointment = regardingobjectidBcgovCustomaddressServiceappointment;
            RegardingobjectidBcgovCustomproductServiceappointment = regardingobjectidBcgovCustomproductServiceappointment;
            RegardingobjectidBcgovEquipmentServiceappointment = regardingobjectidBcgovEquipmentServiceappointment;
            RegardingobjectidBcgovEquipmentlocationServiceappointment = regardingobjectidBcgovEquipmentlocationServiceappointment;
            RegardingobjectidBcgovLocationServiceappointment = regardingobjectidBcgovLocationServiceappointment;
            RegardingobjectidBcgovRiskassessmentServiceappointment = regardingobjectidBcgovRiskassessmentServiceappointment;
            RegardingobjectidBcgovInspectionServiceappointment = regardingobjectidBcgovInspectionServiceappointment;
            RegardingobjectidBcgovComplaintServiceappointment = regardingobjectidBcgovComplaintServiceappointment;
            RegardingobjectidBcgovViolationticketServiceappointment = regardingobjectidBcgovViolationticketServiceappointment;
            RegardingobjectidBcgovInvestigationstepServiceappointment = regardingobjectidBcgovInvestigationstepServiceappointment;
            RegardingobjectidBcgovInvestigationServiceappointment = regardingobjectidBcgovInvestigationServiceappointment;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type a category to identify the service activity type,
        /// such as routine maintenance or service call, to tie the service
        /// activity to a business group or function.
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the data import or data migration
        /// that created this record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets type a subcategory to identify the service activity
        /// type and relate the activity to a specific product, service region,
        /// business group, or other function.
        /// </summary>
        [JsonProperty(PropertyName = "subcategory")]
        public string Subcategory { get; set; }

        /// <summary>
        /// Gets or sets select whether the service activity is an all-day
        /// event to make sure the required resources are scheduled for the
        /// full day.
        /// </summary>
        [JsonProperty(PropertyName = "isalldayevent")]
        public bool? Isalldayevent { get; set; }

        /// <summary>
        /// Gets or sets type the location where the service activity will take
        /// place, such as a conference room, customer office, or other venue.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionid")]
        public string Subscriptionid { get; set; }

        /// <summary>
        /// Gets or sets choose the site or location where the service activity
        /// will be performed.
        /// </summary>
        [JsonProperty(PropertyName = "_siteid_value")]
        public string _siteidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlement_serviceappointment")]
        public MicrosoftDynamicsCRMentitlement RegardingobjectidEntitlementServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlementtemplate_serviceappointment")]
        public MicrosoftDynamicsCRMentitlementtemplate RegardingobjectidEntitlementtemplateServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebooking_serviceappointment")]
        public MicrosoftDynamicsCRMbookableresourcebooking RegardingobjectidBookableresourcebookingServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebookingheader_serviceappointment")]
        public MicrosoftDynamicsCRMbookableresourcebookingheader RegardingobjectidBookableresourcebookingheaderServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgebaserecord_serviceappointment")]
        public MicrosoftDynamicsCRMknowledgebaserecord RegardingobjectidKnowledgebaserecordServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account_serviceappointment")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccountServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slakpiinstance_serviceappointment")]
        public IList<MicrosoftDynamicsCRMslakpiinstance> SlakpiinstanceServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceappointment_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> ServiceappointmentActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceid_serviceappointment")]
        public MicrosoftDynamicsCRMservice ServiceidServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ServiceAppointment_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ServiceAppointmentBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ServiceAppointment_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ServiceAppointmentSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_serviceappointment")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_incident_serviceappointment")]
        public MicrosoftDynamicsCRMincident RegardingobjectidIncidentServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceappointment_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> ServiceappointmentConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_serviceappointment")]
        public MicrosoftDynamicsCRMsystemuser OwninguserServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_salesorder_serviceappointment")]
        public MicrosoftDynamicsCRMsalesorder RegardingobjectidSalesorderServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ServiceAppointment_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ServiceAppointmentAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contact_serviceappointment")]
        public MicrosoftDynamicsCRMcontact RegardingobjectidContactServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceappointment_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> ServiceappointmentConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contract_serviceappointment")]
        public MicrosoftDynamicsCRMcontract RegardingobjectidContractServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceappointment_actioncard")]
        public IList<MicrosoftDynamicsCRMactioncard> ServiceappointmentActioncard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaign_serviceappointment")]
        public MicrosoftDynamicsCRMcampaign RegardingobjectidCampaignServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ServiceAppointment_QueueItem")]
        public IList<MicrosoftDynamicsCRMqueueitem> ServiceAppointmentQueueItem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_opportunity_serviceappointment")]
        public MicrosoftDynamicsCRMopportunity RegardingobjectidOpportunityServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_quote_serviceappointment")]
        public MicrosoftDynamicsCRMquote RegardingobjectidQuoteServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgearticle_serviceappointment")]
        public MicrosoftDynamicsCRMknowledgearticle RegardingobjectidKnowledgearticleServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "siteid")]
        public MicrosoftDynamicsCRMsite Siteid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_serviceappointment")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid_serviceappointment")]
        public MicrosoftDynamicsCRMtransactioncurrency TransactioncurrencyidServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SLAId")]
        public MicrosoftDynamicsCRMsla SLAId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ServiceAppointment_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> ServiceAppointmentAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_serviceappointment")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_serviceappointment")]
        public MicrosoftDynamicsCRMteam OwningteamServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_serviceappointment")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_invoice_serviceappointment")]
        public MicrosoftDynamicsCRMinvoice RegardingobjectidInvoiceServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid_serviceappointment_sla")]
        public MicrosoftDynamicsCRMsla SlainvokedidServiceappointmentSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_serviceappointment")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead_serviceappointment")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLeadServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_abs_scheduledprocess_serviceappointment")]
        public MicrosoftDynamicsCRMabsScheduledprocess RegardingobjectidAbsScheduledprocessServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bcgov_customaddress_serviceappointment")]
        public MicrosoftDynamicsCRMbcgovCustomaddress RegardingobjectidBcgovCustomaddressServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bcgov_customproduct_serviceappointment")]
        public MicrosoftDynamicsCRMbcgovCustomproduct RegardingobjectidBcgovCustomproductServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bcgov_equipment_serviceappointment")]
        public MicrosoftDynamicsCRMbcgovEquipment RegardingobjectidBcgovEquipmentServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bcgov_equipmentlocation_serviceappointment")]
        public MicrosoftDynamicsCRMbcgovEquipmentlocation RegardingobjectidBcgovEquipmentlocationServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bcgov_location_serviceappointment")]
        public MicrosoftDynamicsCRMbcgovLocation RegardingobjectidBcgovLocationServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bcgov_riskassessment_serviceappointment")]
        public MicrosoftDynamicsCRMbcgovRiskassessment RegardingobjectidBcgovRiskassessmentServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bcgov_inspection_serviceappointment")]
        public MicrosoftDynamicsCRMbcgovInspection RegardingobjectidBcgovInspectionServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bcgov_complaint_serviceappointment")]
        public MicrosoftDynamicsCRMbcgovComplaint RegardingobjectidBcgovComplaintServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bcgov_violationticket_serviceappointment")]
        public MicrosoftDynamicsCRMbcgovViolationticket RegardingobjectidBcgovViolationticketServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bcgov_investigationstep_serviceappointment")]
        public MicrosoftDynamicsCRMbcgovInvestigationstep RegardingobjectidBcgovInvestigationstepServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bcgov_investigation_serviceappointment")]
        public MicrosoftDynamicsCRMbcgovInvestigation RegardingobjectidBcgovInvestigationServiceappointment { get; set; }

    }
}
