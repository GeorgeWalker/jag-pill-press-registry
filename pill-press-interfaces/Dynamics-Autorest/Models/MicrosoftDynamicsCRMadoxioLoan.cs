// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// adoxio_loan
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioLoan
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMadoxioLoan
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioLoan()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMadoxioLoan
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioLoan(int? utcconversiontimezonecode = default(int?), string adoxioAddressstreet = default(string), string _modifiedonbehalfbyValue = default(string), int? adoxioLoantype = default(int?), System.DateTimeOffset? adoxioDateofloan = default(System.DateTimeOffset?), int? statuscode = default(int?), string _adoxioAccountidValue = default(string), int? importsequencenumber = default(int?), string _owninguserValue = default(string), int? adoxioAddressstateprovince = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _owneridValue = default(string), string _owningteamValue = default(string), string _modifiedbyValue = default(string), string adoxioLoanid = default(string), string adoxioReasonforloan = default(string), int? timezoneruleversionnumber = default(int?), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string _owningbusinessunitValue = default(string), string adoxioAmountorasset = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string adoxioName = default(string), long? versionnumber = default(long?), string adoxioAddresscity = default(string), int? statecode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string adoxioTerms = default(string), string adoxioAddresspostalcode = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioLoanSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioLoanDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioLoanDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioLoanAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioLoanBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMaccount adoxioAccountId = default(MicrosoftDynamicsCRMaccount))
        {
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AdoxioAddressstreet = adoxioAddressstreet;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AdoxioLoantype = adoxioLoantype;
            AdoxioDateofloan = adoxioDateofloan;
            Statuscode = statuscode;
            this._adoxioAccountidValue = _adoxioAccountidValue;
            Importsequencenumber = importsequencenumber;
            this._owninguserValue = _owninguserValue;
            AdoxioAddressstateprovince = adoxioAddressstateprovince;
            Createdon = createdon;
            this._owneridValue = _owneridValue;
            this._owningteamValue = _owningteamValue;
            this._modifiedbyValue = _modifiedbyValue;
            AdoxioLoanid = adoxioLoanid;
            AdoxioReasonforloan = adoxioReasonforloan;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            AdoxioAmountorasset = adoxioAmountorasset;
            Overriddencreatedon = overriddencreatedon;
            AdoxioName = adoxioName;
            Versionnumber = versionnumber;
            AdoxioAddresscity = adoxioAddresscity;
            Statecode = statecode;
            Modifiedon = modifiedon;
            AdoxioTerms = adoxioTerms;
            AdoxioAddresspostalcode = adoxioAddresspostalcode;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioLoanSyncErrors = adoxioLoanSyncErrors;
            AdoxioLoanDuplicateMatchingRecord = adoxioLoanDuplicateMatchingRecord;
            AdoxioLoanDuplicateBaseRecord = adoxioLoanDuplicateBaseRecord;
            AdoxioLoanAsyncOperations = adoxioLoanAsyncOperations;
            AdoxioLoanBulkDeleteFailures = adoxioLoanBulkDeleteFailures;
            AdoxioAccountId = adoxioAccountId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_addressstreet")]
        public string AdoxioAddressstreet { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_loantype")]
        public int? AdoxioLoantype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_dateofloan")]
        public System.DateTimeOffset? AdoxioDateofloan { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_accountid_value")]
        public string _adoxioAccountidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_addressstateprovince")]
        public int? AdoxioAddressstateprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

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
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_loanid")]
        public string AdoxioLoanid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_reasonforloan")]
        public string AdoxioReasonforloan { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_amountorasset")]
        public string AdoxioAmountorasset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_addresscity")]
        public string AdoxioAddresscity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_terms")]
        public string AdoxioTerms { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_addresspostalcode")]
        public string AdoxioAddresspostalcode { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_loan_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioLoanSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_loan_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioLoanDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_loan_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioLoanDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_loan_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioLoanAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_loan_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioLoanBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_AccountId")]
        public MicrosoftDynamicsCRMaccount AdoxioAccountId { get; set; }

    }
}
