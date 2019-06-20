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
    /// bcgov_cecontact
    /// </summary>
    public partial class MicrosoftDynamicsCRMbcgovCecontact
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovCecontact class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovCecontact()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovCecontact class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovCecontact(System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _owninguserValue = default(string), string _bcgovContactidValue = default(string), string bcgovName = default(string), int? statecode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), int? statuscode = default(int?), string _bcgovCecontacttypeValue = default(string), int? timezoneruleversionnumber = default(int?), string _modifiedbyValue = default(string), int? utcconversiontimezonecode = default(int?), string bcgovContactdetails = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string bcgovCecontactid = default(string), long? versionnumber = default(long?), string _owneridValue = default(string), string _owningteamValue = default(string), string _createdbyValue = default(string), int? importsequencenumber = default(int?), string _owningbusinessunitValue = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> bcgovCecontactSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> bcgovCecontactDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> bcgovCecontactDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> bcgovCecontactAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> bcgovCecontactBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMcontact bcgovContactId = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMbcgovCecontacttype bcgovCEContactType = default(MicrosoftDynamicsCRMbcgovCecontacttype), IList<MicrosoftDynamicsCRMbcgovInvestigationstep> bcgovInvestigationstepCecontact = default(IList<MicrosoftDynamicsCRMbcgovInvestigationstep>), IList<MicrosoftDynamicsCRMbcgovComplaint> bcgovComplaintCecontact = default(IList<MicrosoftDynamicsCRMbcgovComplaint>))
        {
            Modifiedon = modifiedon;
            this._owninguserValue = _owninguserValue;
            this._bcgovContactidValue = _bcgovContactidValue;
            BcgovName = bcgovName;
            Statecode = statecode;
            Createdon = createdon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Statuscode = statuscode;
            this._bcgovCecontacttypeValue = _bcgovCecontacttypeValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._modifiedbyValue = _modifiedbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            BcgovContactdetails = bcgovContactdetails;
            Overriddencreatedon = overriddencreatedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            BcgovCecontactid = bcgovCecontactid;
            Versionnumber = versionnumber;
            this._owneridValue = _owneridValue;
            this._owningteamValue = _owningteamValue;
            this._createdbyValue = _createdbyValue;
            Importsequencenumber = importsequencenumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            BcgovCecontactSyncErrors = bcgovCecontactSyncErrors;
            BcgovCecontactDuplicateMatchingRecord = bcgovCecontactDuplicateMatchingRecord;
            BcgovCecontactDuplicateBaseRecord = bcgovCecontactDuplicateBaseRecord;
            BcgovCecontactAsyncOperations = bcgovCecontactAsyncOperations;
            BcgovCecontactBulkDeleteFailures = bcgovCecontactBulkDeleteFailures;
            BcgovContactId = bcgovContactId;
            BcgovCEContactType = bcgovCEContactType;
            BcgovInvestigationstepCecontact = bcgovInvestigationstepCecontact;
            BcgovComplaintCecontact = bcgovComplaintCecontact;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bcgov_contactid_value")]
        public string _bcgovContactidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_name")]
        public string BcgovName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bcgov_cecontacttype_value")]
        public string _bcgovCecontacttypeValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_contactdetails")]
        public string BcgovContactdetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_cecontactid")]
        public string BcgovCecontactid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

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
        [JsonProperty(PropertyName = "bcgov_cecontact_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> BcgovCecontactSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_cecontact_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BcgovCecontactDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_cecontact_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BcgovCecontactDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_cecontact_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> BcgovCecontactAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_cecontact_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> BcgovCecontactBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_ContactId")]
        public MicrosoftDynamicsCRMcontact BcgovContactId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_CEContactType")]
        public MicrosoftDynamicsCRMbcgovCecontacttype BcgovCEContactType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_investigationstep_cecontact")]
        public IList<MicrosoftDynamicsCRMbcgovInvestigationstep> BcgovInvestigationstepCecontact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_complaint_cecontact")]
        public IList<MicrosoftDynamicsCRMbcgovComplaint> BcgovComplaintCecontact { get; set; }

    }
}