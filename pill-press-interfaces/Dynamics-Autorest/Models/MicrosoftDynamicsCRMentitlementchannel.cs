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
    /// Microsoft.Dynamics.CRM.entitlementchannel
    /// </summary>
    public partial class MicrosoftDynamicsCRMentitlementchannel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMentitlementchannel class.
        /// </summary>
        public MicrosoftDynamicsCRMentitlementchannel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMentitlementchannel class.
        /// </summary>
        /// <param name="_owninguserValue">Unique identifier for the user that
        /// owns the record.</param>
        /// <param name="versionnumber">Version number of the entitlement
        /// channel item.</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="name">The name of the custom entity.</param>
        /// <param name="_organizationidValue">Unique identifier of the
        /// organization with which the entitlement channel is
        /// associated.</param>
        /// <param name="importsequencenumber">Unique identifier of the data
        /// import or data migration that created this record.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the record.</param>
        /// <param name="createdon">Date and time when the entitlement was
        /// created.</param>
        /// <param name="modifiedon">Date and time when the record was
        /// modified.</param>
        /// <param name="channel">Select a channel for which you are defining
        /// the entitlement terms.</param>
        /// <param name="_transactioncurrencyidValue">Unique identifier of the
        /// currency associated with the incident.</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the record.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the record.</param>
        /// <param name="_entitlementidValue">Unique identifier for Entitlement
        /// associated with Entitlement Channel.</param>
        /// <param name="remainingterms">Type the total number of entitlement
        /// terms that are left.</param>
        /// <param name="_owneridValue">Unique identifier of the user or team
        /// who owns the entitlement channel.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="totalterms">Type the total number of entitlement
        /// terms.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="entitlementchannelid">Unique identifier for entity
        /// instances</param>
        /// <param name="_owningbusinessunitValue">Unique identifier for the
        /// business unit that owns the record</param>
        /// <param name="exchangerate">Exchange rate for the currency
        /// associated with the incident with respect to the base
        /// currency.</param>
        public MicrosoftDynamicsCRMentitlementchannel(string _owninguserValue = default(string), string versionnumber = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string name = default(string), string _organizationidValue = default(string), int? importsequencenumber = default(int?), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? channel = default(int?), string _transactioncurrencyidValue = default(string), int? utcconversiontimezonecode = default(int?), string _createdbyValue = default(string), string _modifiedbyValue = default(string), string _entitlementidValue = default(string), decimal? remainingterms = default(decimal?), string _owneridValue = default(string), int? timezoneruleversionnumber = default(int?), decimal? totalterms = default(decimal?), string _modifiedonbehalfbyValue = default(string), string entitlementchannelid = default(string), string _owningbusinessunitValue = default(string), decimal? exchangerate = default(decimal?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMduplicaterecord> entitlementchannelDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> entitlementchannelDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMannotation> entitlementchannelAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMasyncoperation> entitlementchannelAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> entitlementchannelBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMentitlement entitlementid = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization))
        {
            this._owninguserValue = _owninguserValue;
            Versionnumber = versionnumber;
            Overriddencreatedon = overriddencreatedon;
            Name = name;
            this._organizationidValue = _organizationidValue;
            Importsequencenumber = importsequencenumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Createdon = createdon;
            Modifiedon = modifiedon;
            Channel = channel;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._createdbyValue = _createdbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._entitlementidValue = _entitlementidValue;
            Remainingterms = remainingterms;
            this._owneridValue = _owneridValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Totalterms = totalterms;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Entitlementchannelid = entitlementchannelid;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Exchangerate = exchangerate;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            EntitlementchannelDuplicateMatchingRecord = entitlementchannelDuplicateMatchingRecord;
            EntitlementchannelDuplicateBaseRecord = entitlementchannelDuplicateBaseRecord;
            EntitlementchannelAnnotations = entitlementchannelAnnotations;
            EntitlementchannelAsyncOperations = entitlementchannelAsyncOperations;
            EntitlementchannelBulkDeleteFailures = entitlementchannelBulkDeleteFailures;
            Entitlementid = entitlementid;
            Transactioncurrencyid = transactioncurrencyid;
            Organizationid = organizationid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier for the user that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// Gets or sets version number of the entitlement channel item.
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// Gets or sets the name of the custom entity.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the organization with which the
        /// entitlement channel is associated.
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the data import or data migration
        /// that created this record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the entitlement was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets select a channel for which you are defining the
        /// entitlement terms.
        /// </summary>
        [JsonProperty(PropertyName = "channel")]
        public int? Channel { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the currency associated with the
        /// incident.
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who modified the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for Entitlement associated with
        /// Entitlement Channel.
        /// </summary>
        [JsonProperty(PropertyName = "_entitlementid_value")]
        public string _entitlementidValue { get; set; }

        /// <summary>
        /// Gets or sets type the total number of entitlement terms that are
        /// left.
        /// </summary>
        [JsonProperty(PropertyName = "remainingterms")]
        public decimal? Remainingterms { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user or team who owns the
        /// entitlement channel.
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets type the total number of entitlement terms.
        /// </summary>
        [JsonProperty(PropertyName = "totalterms")]
        public decimal? Totalterms { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for entity instances
        /// </summary>
        [JsonProperty(PropertyName = "entitlementchannelid")]
        public string Entitlementchannelid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the business unit that owns the
        /// record
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// Gets or sets exchange rate for the currency associated with the
        /// incident with respect to the base currency.
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementchannel_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> EntitlementchannelDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementchannel_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> EntitlementchannelDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementchannel_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> EntitlementchannelAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementchannel_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> EntitlementchannelAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementchannel_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> EntitlementchannelBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementid")]
        public MicrosoftDynamicsCRMentitlement Entitlementid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

    }
}
