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
    /// Microsoft.Dynamics.CRM.dynamicpropertyoptionsetitem
    /// </summary>
    public partial class MicrosoftDynamicsCRMdynamicpropertyoptionsetitem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMdynamicpropertyoptionsetitem class.
        /// </summary>
        public MicrosoftDynamicsCRMdynamicpropertyoptionsetitem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMdynamicpropertyoptionsetitem class.
        /// </summary>
        /// <param name="overriddencreatedon">Shows the date and time that the
        /// record was migrated.</param>
        /// <param name="createdon">Shows the date and time when the record was
        /// created.</param>
        /// <param name="dynamicpropertyoptionname">Type the name of the
        /// property option set item.</param>
        /// <param name="_modifiedonbehalfbyValue">Shows who created the record
        /// on behalf of another user.</param>
        /// <param name="_modifiedbyValue">Shows who last updated the
        /// record.</param>
        /// <param name="versionnumber">Shows the version number of the
        /// property option set item.</param>
        /// <param name="exchangerate">Shows the conversion rate of the
        /// record's currency. The exchange rate is used to convert all money
        /// fields in the record from the local currency to the system's
        /// default currency.</param>
        /// <param name="dynamicpropertyoptionsetvaluesequencenumber">Internal
        /// Use Only</param>
        /// <param name="_createdonbehalfbyValue">Shows who created the record
        /// on behalf of another user.</param>
        /// <param name="_organizationidValue">Shows the organization
        /// associated with the record.</param>
        /// <param name="importsequencenumber">Shows the data import or data
        /// migration that created this record.</param>
        /// <param name="dynamicpropertyoptionvalue">Shows the value of the
        /// property option set item.</param>
        /// <param name="_transactioncurrencyidValue">Shows the currency
        /// associated with the record.</param>
        /// <param name="_dynamicpropertyidValue">Shows the property that uses
        /// this option set item.</param>
        /// <param name="dynamicpropertyoptiondescription">Type additional
        /// information about the property option set item.</param>
        /// <param name="dmtimportstate">Internal Use Only</param>
        /// <param name="_createdbyValue">Shows who created the record.</param>
        /// <param name="modifiedon">Shows the date and time when the record
        /// was last updated.</param>
        /// <param name="dynamicpropertyoptionsetvalueid">Shows the unique
        /// identifier of the property option set item.</param>
        public MicrosoftDynamicsCRMdynamicpropertyoptionsetitem(System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string dynamicpropertyoptionname = default(string), string _modifiedonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string versionnumber = default(string), decimal? exchangerate = default(decimal?), int? dynamicpropertyoptionsetvaluesequencenumber = default(int?), string _createdonbehalfbyValue = default(string), string _organizationidValue = default(string), int? importsequencenumber = default(int?), int? dynamicpropertyoptionvalue = default(int?), string _transactioncurrencyidValue = default(string), string _dynamicpropertyidValue = default(string), string dynamicpropertyoptiondescription = default(string), int? dmtimportstate = default(int?), string _createdbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string dynamicpropertyoptionsetvalueid = default(string), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMdynamicproperty dynamicpropertyid = default(MicrosoftDynamicsCRMdynamicproperty), IList<MicrosoftDynamicsCRMdynamicproperty> defaultValueOptionSetDynamicProperty = default(IList<MicrosoftDynamicsCRMdynamicproperty>))
        {
            Overriddencreatedon = overriddencreatedon;
            Createdon = createdon;
            Dynamicpropertyoptionname = dynamicpropertyoptionname;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Versionnumber = versionnumber;
            Exchangerate = exchangerate;
            Dynamicpropertyoptionsetvaluesequencenumber = dynamicpropertyoptionsetvaluesequencenumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._organizationidValue = _organizationidValue;
            Importsequencenumber = importsequencenumber;
            Dynamicpropertyoptionvalue = dynamicpropertyoptionvalue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            this._dynamicpropertyidValue = _dynamicpropertyidValue;
            Dynamicpropertyoptiondescription = dynamicpropertyoptiondescription;
            Dmtimportstate = dmtimportstate;
            this._createdbyValue = _createdbyValue;
            Modifiedon = modifiedon;
            Dynamicpropertyoptionsetvalueid = dynamicpropertyoptionsetvalueid;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Transactioncurrencyid = transactioncurrencyid;
            Createdby = createdby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            Dynamicpropertyid = dynamicpropertyid;
            DefaultValueOptionSetDynamicProperty = defaultValueOptionSetDynamicProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets shows the date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets type the name of the property option set item.
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyoptionname")]
        public string Dynamicpropertyoptionname { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record on behalf of another
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows who last updated the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows the version number of the property option set
        /// item.
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets shows the conversion rate of the record's currency.
        /// The exchange rate is used to convert all money fields in the record
        /// from the local currency to the system's default currency.
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// Gets or sets internal Use Only
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyoptionsetvaluesequencenumber")]
        public int? Dynamicpropertyoptionsetvaluesequencenumber { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record on behalf of another
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows the organization associated with the record.
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets shows the data import or data migration that created
        /// this record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets shows the value of the property option set item.
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyoptionvalue")]
        public int? Dynamicpropertyoptionvalue { get; set; }

        /// <summary>
        /// Gets or sets shows the currency associated with the record.
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// Gets or sets shows the property that uses this option set item.
        /// </summary>
        [JsonProperty(PropertyName = "_dynamicpropertyid_value")]
        public string _dynamicpropertyidValue { get; set; }

        /// <summary>
        /// Gets or sets type additional information about the property option
        /// set item.
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyoptiondescription")]
        public string Dynamicpropertyoptiondescription { get; set; }

        /// <summary>
        /// Gets or sets internal Use Only
        /// </summary>
        [JsonProperty(PropertyName = "dmtimportstate")]
        public int? Dmtimportstate { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was last
        /// updated.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets shows the unique identifier of the property option set
        /// item.
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyoptionsetvalueid")]
        public string Dynamicpropertyoptionsetvalueid { get; set; }

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
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyid")]
        public MicrosoftDynamicsCRMdynamicproperty Dynamicpropertyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DefaultValueOptionSet_DynamicProperty")]
        public IList<MicrosoftDynamicsCRMdynamicproperty> DefaultValueOptionSetDynamicProperty { get; set; }

    }
}
