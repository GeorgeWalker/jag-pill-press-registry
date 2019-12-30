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
    /// Microsoft.Dynamics.CRM.abs_autonumberingdefinition
    /// </summary>
    public partial class MicrosoftDynamicsCRMabsAutonumberingdefinition
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMabsAutonumberingdefinition class.
        /// </summary>
        public MicrosoftDynamicsCRMabsAutonumberingdefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMabsAutonumberingdefinition class.
        /// </summary>
        /// <param name="versionnumber">Version Number</param>
        /// <param name="absAutonumberingdefinitionid">Unique identifier for
        /// entity instances</param>
        /// <param name="statuscode">Reason for the status of the Auto
        /// Numbering Definition</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="absName">The name of the custom entity.</param>
        /// <param name="createdon">Date and time when the record was
        /// created.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the record.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the record.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the record.</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="_organizationidValue">Unique identifier for the
        /// organization</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="statecode">Status of the Auto Numbering
        /// Definition</param>
        /// <param name="importsequencenumber">Sequence number of the import
        /// that created this record.</param>
        /// <param name="modifiedon">Date and time when the record was
        /// modified.</param>
        public MicrosoftDynamicsCRMabsAutonumberingdefinition(int? absLastnumberissued = default(int?), string versionnumber = default(string), string absAutonumberingdefinitionid = default(string), int? statuscode = default(int?), int? absInitialvalue = default(int?), int? absDigits = default(int?), int? utcconversiontimezonecode = default(int?), string absName = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string absDatetimeformat = default(string), int? timezoneruleversionnumber = default(int?), string _modifiedbyValue = default(string), string _createdonbehalfbyValue = default(string), string _createdbyValue = default(string), int? absIncrement = default(int?), string absLock = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _organizationidValue = default(string), int? absRandomsuffixlength = default(int?), string absFormat = default(string), string _modifiedonbehalfbyValue = default(string), int? statecode = default(int?), int? importsequencenumber = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> absAutonumberingdefinitionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> absAutonumberingdefinitionDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> absAutonumberingdefinitionDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> absAutonumberingdefinitionAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> absAutonumberingdefinitionBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMabsAutonumberedentity> absAutonumberedentityAutoNumberingDefinition = default(IList<MicrosoftDynamicsCRMabsAutonumberedentity>))
        {
            AbsLastnumberissued = absLastnumberissued;
            Versionnumber = versionnumber;
            AbsAutonumberingdefinitionid = absAutonumberingdefinitionid;
            Statuscode = statuscode;
            AbsInitialvalue = absInitialvalue;
            AbsDigits = absDigits;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AbsName = absName;
            Createdon = createdon;
            AbsDatetimeformat = absDatetimeformat;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._modifiedbyValue = _modifiedbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            AbsIncrement = absIncrement;
            AbsLock = absLock;
            Overriddencreatedon = overriddencreatedon;
            this._organizationidValue = _organizationidValue;
            AbsRandomsuffixlength = absRandomsuffixlength;
            AbsFormat = absFormat;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Statecode = statecode;
            Importsequencenumber = importsequencenumber;
            Modifiedon = modifiedon;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Organizationid = organizationid;
            AbsAutonumberingdefinitionSyncErrors = absAutonumberingdefinitionSyncErrors;
            AbsAutonumberingdefinitionDuplicateMatchingRecord = absAutonumberingdefinitionDuplicateMatchingRecord;
            AbsAutonumberingdefinitionDuplicateBaseRecord = absAutonumberingdefinitionDuplicateBaseRecord;
            AbsAutonumberingdefinitionAsyncOperations = absAutonumberingdefinitionAsyncOperations;
            AbsAutonumberingdefinitionBulkDeleteFailures = absAutonumberingdefinitionBulkDeleteFailures;
            AbsAutonumberedentityAutoNumberingDefinition = absAutonumberedentityAutoNumberingDefinition;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_lastnumberissued")]
        public int? AbsLastnumberissued { get; set; }

        /// <summary>
        /// Gets or sets version Number
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for entity instances
        /// </summary>
        [JsonProperty(PropertyName = "abs_autonumberingdefinitionid")]
        public string AbsAutonumberingdefinitionid { get; set; }

        /// <summary>
        /// Gets or sets reason for the status of the Auto Numbering Definition
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_initialvalue")]
        public int? AbsInitialvalue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_digits")]
        public int? AbsDigits { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets the name of the custom entity.
        /// </summary>
        [JsonProperty(PropertyName = "abs_name")]
        public string AbsName { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_datetimeformat")]
        public string AbsDatetimeformat { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who modified the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_increment")]
        public int? AbsIncrement { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_lock")]
        public string AbsLock { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the organization
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_randomsuffixlength")]
        public int? AbsRandomsuffixlength { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_format")]
        public string AbsFormat { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets status of the Auto Numbering Definition
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// Gets or sets sequence number of the import that created this
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

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
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_autonumberingdefinition_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AbsAutonumberingdefinitionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_autonumberingdefinition_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AbsAutonumberingdefinitionDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_autonumberingdefinition_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AbsAutonumberingdefinitionDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_autonumberingdefinition_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AbsAutonumberingdefinitionAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_autonumberingdefinition_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AbsAutonumberingdefinitionBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_autonumberedentity_AutoNumberingDefinition")]
        public IList<MicrosoftDynamicsCRMabsAutonumberedentity> AbsAutonumberedentityAutoNumberingDefinition { get; set; }

    }
}
