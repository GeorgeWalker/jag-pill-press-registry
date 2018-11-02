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
    /// timezonedefinition
    /// </summary>
    public partial class MicrosoftDynamicsCRMtimezonedefinition
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMtimezonedefinition class.
        /// </summary>
        public MicrosoftDynamicsCRMtimezonedefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMtimezonedefinition class.
        /// </summary>
        public MicrosoftDynamicsCRMtimezonedefinition(string userinterfacename = default(string), string timezonedefinitionid = default(string), long? versionnumber = default(long?), string _modifiedonbehalfbyValue = default(string), string _organizationidValue = default(string), int? bias = default(int?), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? timezonecode = default(int?), string _modifiedbyValue = default(string), string _createdbyValue = default(string), string standardname = default(string), int? retiredorder = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string daylightname = default(string), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMtimezonelocalizedname> lkTimezonelocalizednameTimezonedefinitionid = default(IList<MicrosoftDynamicsCRMtimezonelocalizedname>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMtimezonerule> lkTimezoneruleTimezonedefinitionid = default(IList<MicrosoftDynamicsCRMtimezonerule>))
        {
            Userinterfacename = userinterfacename;
            Timezonedefinitionid = timezonedefinitionid;
            Versionnumber = versionnumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._organizationidValue = _organizationidValue;
            Bias = bias;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Createdon = createdon;
            Timezonecode = timezonecode;
            this._modifiedbyValue = _modifiedbyValue;
            this._createdbyValue = _createdbyValue;
            Standardname = standardname;
            Retiredorder = retiredorder;
            Modifiedon = modifiedon;
            Daylightname = daylightname;
            Modifiedby = modifiedby;
            LkTimezonelocalizednameTimezonedefinitionid = lkTimezonelocalizednameTimezonedefinitionid;
            Createdonbehalfby = createdonbehalfby;
            Createdby = createdby;
            Modifiedonbehalfby = modifiedonbehalfby;
            LkTimezoneruleTimezonedefinitionid = lkTimezoneruleTimezonedefinitionid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userinterfacename")]
        public string Userinterfacename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezonedefinitionid")]
        public string Timezonedefinitionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bias")]
        public int? Bias { get; set; }

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
        [JsonProperty(PropertyName = "timezonecode")]
        public int? Timezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "standardname")]
        public string Standardname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "retiredorder")]
        public int? Retiredorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "daylightname")]
        public string Daylightname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lk_timezonelocalizedname_timezonedefinitionid")]
        public IList<MicrosoftDynamicsCRMtimezonelocalizedname> LkTimezonelocalizednameTimezonedefinitionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

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
        [JsonProperty(PropertyName = "lk_timezonerule_timezonedefinitionid")]
        public IList<MicrosoftDynamicsCRMtimezonerule> LkTimezoneruleTimezonedefinitionid { get; set; }

    }
}
