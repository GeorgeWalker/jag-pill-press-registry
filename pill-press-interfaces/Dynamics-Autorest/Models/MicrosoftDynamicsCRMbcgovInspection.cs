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
    /// bcgov_inspection
    /// </summary>
    public partial class MicrosoftDynamicsCRMbcgovInspection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovInspection class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovInspection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovInspection class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovInspection(string _bcgovBusinesslegalnameValue = default(string), string _owninguserValue = default(string), string _stageidValue = default(string), string _bcgovEquipmentrecordValue = default(string), string _owneridValue = default(string), int? bcgovInspectiontype = default(int?), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _createdbyValue = default(string), string _owningteamValue = default(string), int? bcgovPrvtdwelling = default(int?), string processid = default(string), string emailaddress = default(string), string bcgovProgram = default(string), string traversedpath = default(string), string bcgovCebestinspectionhours = default(string), string _owningbusinessunitValue = default(string), string _bcgovLocationcontactValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string bcgovInspectionid = default(string), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), int? importsequencenumber = default(int?), string _bcgovLocationValue = default(string), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? bcgovInspectionduedate = default(System.DateTimeOffset?), int? bcgovPrivatedwelling = default(int?), int? statecode = default(int?), string _modifiedbyValue = default(string), string bcgovName = default(string), int? statuscode = default(int?), long? versionnumber = default(long?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMactivitypointer> bcgovInspectionActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMappointment> bcgovInspectionAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> bcgovInspectionEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> bcgovInspectionFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> bcgovInspectionLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> bcgovInspectionPhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMserviceappointment> bcgovInspectionServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMtask> bcgovInspectionTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> bcgovInspectionRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> bcgovInspectionSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> bcgovInspectionAbsScheduledprocessexecutions = default(IList<MicrosoftDynamicsCRMabsScheduledprocessexecution>), IList<MicrosoftDynamicsCRMsyncerror> bcgovInspectionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMactivityparty> bcgovInspectionActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMduplicaterecord> bcgovInspectionDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> bcgovInspectionDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> bcgovInspectionSharePointDocumentLocations = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>), IList<MicrosoftDynamicsCRMqueueitem> bcgovInspectionQueueItems = default(IList<MicrosoftDynamicsCRMqueueitem>), IList<MicrosoftDynamicsCRMannotation> bcgovInspectionAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMasyncoperation> bcgovInspectionAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> bcgovInspectionBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMprocessstage stageid = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMbcgovLocation bcgovLocation = default(MicrosoftDynamicsCRMbcgovLocation), MicrosoftDynamicsCRMcontact bcgovLocationContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMaccount bcgovBusinessLegalName = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMbcgovEquipment bcgovEquipmentRecord = default(MicrosoftDynamicsCRMbcgovEquipment), IList<MicrosoftDynamicsCRMincident> bcgovInspectionIncidentNewInspectionRecord = default(IList<MicrosoftDynamicsCRMincident>))
        {
            this._bcgovBusinesslegalnameValue = _bcgovBusinesslegalnameValue;
            this._owninguserValue = _owninguserValue;
            this._stageidValue = _stageidValue;
            this._bcgovEquipmentrecordValue = _bcgovEquipmentrecordValue;
            this._owneridValue = _owneridValue;
            BcgovInspectiontype = bcgovInspectiontype;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Overriddencreatedon = overriddencreatedon;
            this._createdbyValue = _createdbyValue;
            this._owningteamValue = _owningteamValue;
            BcgovPrvtdwelling = bcgovPrvtdwelling;
            Processid = processid;
            Emailaddress = emailaddress;
            BcgovProgram = bcgovProgram;
            Traversedpath = traversedpath;
            BcgovCebestinspectionhours = bcgovCebestinspectionhours;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._bcgovLocationcontactValue = _bcgovLocationcontactValue;
            Modifiedon = modifiedon;
            BcgovInspectionid = bcgovInspectionid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Createdon = createdon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Importsequencenumber = importsequencenumber;
            this._bcgovLocationValue = _bcgovLocationValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            BcgovInspectionduedate = bcgovInspectionduedate;
            BcgovPrivatedwelling = bcgovPrivatedwelling;
            Statecode = statecode;
            this._modifiedbyValue = _modifiedbyValue;
            BcgovName = bcgovName;
            Statuscode = statuscode;
            Versionnumber = versionnumber;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            BcgovInspectionActivityPointers = bcgovInspectionActivityPointers;
            BcgovInspectionAppointments = bcgovInspectionAppointments;
            BcgovInspectionEmails = bcgovInspectionEmails;
            BcgovInspectionFaxes = bcgovInspectionFaxes;
            BcgovInspectionLetters = bcgovInspectionLetters;
            BcgovInspectionPhoneCalls = bcgovInspectionPhoneCalls;
            BcgovInspectionServiceAppointments = bcgovInspectionServiceAppointments;
            BcgovInspectionTasks = bcgovInspectionTasks;
            BcgovInspectionRecurringAppointmentMasters = bcgovInspectionRecurringAppointmentMasters;
            BcgovInspectionSocialActivities = bcgovInspectionSocialActivities;
            BcgovInspectionAbsScheduledprocessexecutions = bcgovInspectionAbsScheduledprocessexecutions;
            BcgovInspectionSyncErrors = bcgovInspectionSyncErrors;
            BcgovInspectionActivityParties = bcgovInspectionActivityParties;
            BcgovInspectionDuplicateMatchingRecord = bcgovInspectionDuplicateMatchingRecord;
            BcgovInspectionDuplicateBaseRecord = bcgovInspectionDuplicateBaseRecord;
            BcgovInspectionSharePointDocumentLocations = bcgovInspectionSharePointDocumentLocations;
            BcgovInspectionQueueItems = bcgovInspectionQueueItems;
            BcgovInspectionAnnotations = bcgovInspectionAnnotations;
            BcgovInspectionAsyncOperations = bcgovInspectionAsyncOperations;
            BcgovInspectionBulkDeleteFailures = bcgovInspectionBulkDeleteFailures;
            Stageid = stageid;
            BcgovLocation = bcgovLocation;
            BcgovLocationContact = bcgovLocationContact;
            BcgovBusinessLegalName = bcgovBusinessLegalName;
            BcgovEquipmentRecord = bcgovEquipmentRecord;
            BcgovInspectionIncidentNewInspectionRecord = bcgovInspectionIncidentNewInspectionRecord;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bcgov_businesslegalname_value")]
        public string _bcgovBusinesslegalnameValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_stageid_value")]
        public string _stageidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bcgov_equipmentrecord_value")]
        public string _bcgovEquipmentrecordValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectiontype")]
        public int? BcgovInspectiontype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_prvtdwelling")]
        public int? BcgovPrvtdwelling { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailaddress")]
        public string Emailaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_program")]
        public string BcgovProgram { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_cebestinspectionhours")]
        public string BcgovCebestinspectionhours { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bcgov_locationcontact_value")]
        public string _bcgovLocationcontactValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionid")]
        public string BcgovInspectionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bcgov_location_value")]
        public string _bcgovLocationValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspectionduedate")]
        public System.DateTimeOffset? BcgovInspectionduedate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_privatedwelling")]
        public int? BcgovPrivatedwelling { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_name")]
        public string BcgovName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspection_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> BcgovInspectionActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspection_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> BcgovInspectionAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspection_Emails")]
        public IList<MicrosoftDynamicsCRMemail> BcgovInspectionEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspection_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> BcgovInspectionFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspection_Letters")]
        public IList<MicrosoftDynamicsCRMletter> BcgovInspectionLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspection_PhoneCalls")]
        public IList<MicrosoftDynamicsCRMphonecall> BcgovInspectionPhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspection_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> BcgovInspectionServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspection_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> BcgovInspectionTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspection_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> BcgovInspectionRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspection_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> BcgovInspectionSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspection_abs_scheduledprocessexecutions")]
        public IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> BcgovInspectionAbsScheduledprocessexecutions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspection_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> BcgovInspectionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspection_ActivityParties")]
        public IList<MicrosoftDynamicsCRMactivityparty> BcgovInspectionActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspection_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BcgovInspectionDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspection_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BcgovInspectionDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspection_SharePointDocumentLocations")]
        public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> BcgovInspectionSharePointDocumentLocations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspection_QueueItems")]
        public IList<MicrosoftDynamicsCRMqueueitem> BcgovInspectionQueueItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspection_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> BcgovInspectionAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspection_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> BcgovInspectionAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspection_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> BcgovInspectionBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public MicrosoftDynamicsCRMprocessstage Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_Location")]
        public MicrosoftDynamicsCRMbcgovLocation BcgovLocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_LocationContact")]
        public MicrosoftDynamicsCRMcontact BcgovLocationContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_BusinessLegalName")]
        public MicrosoftDynamicsCRMaccount BcgovBusinessLegalName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_EquipmentRecord")]
        public MicrosoftDynamicsCRMbcgovEquipment BcgovEquipmentRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_inspection_incident_NewInspectionRecord")]
        public IList<MicrosoftDynamicsCRMincident> BcgovInspectionIncidentNewInspectionRecord { get; set; }

    }
}