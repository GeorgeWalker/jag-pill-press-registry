// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.PillPressRegistry.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.timezonerule
    /// </summary>
    public partial class MicrosoftDynamicsCRMtimezonerule
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMtimezonerule
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMtimezonerule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMtimezonerule
        /// class.
        /// </summary>
        /// <param name="standardmonth">Month when standard time
        /// starts.</param>
        /// <param name="standardhour">Hour of the day when standard time
        /// starts.</param>
        /// <param name="createdon">Date and time when the time zone rule was
        /// created.</param>
        /// <param name="standardsecond">Second of the Minute when standard
        /// time starts.</param>
        /// <param name="timezoneruleid">Unique identifier of the time zone
        /// rule.</param>
        /// <param name="daylightsecond">Second of the minute when daylight
        /// savings time starts</param>
        /// <param name="bias">Base time bias of the time zone rule.</param>
        /// <param name="standardyear">Year when standard time starts.</param>
        /// <param name="daylightminute">Minute of the hour when daylight
        /// savings time starts.</param>
        /// <param name="modifiedon">Date and time when the time zone rule was
        /// modified.</param>
        /// <param name="standardday">Day of the month when standard time
        /// starts.</param>
        /// <param name="standardbias">Time bias in addition to the base bias
        /// for standard time.</param>
        /// <param name="daylightmonth">Month when daylight savings time
        /// starts.</param>
        /// <param name="standardminute">Minute of the hour when standard time
        /// starts.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the time zone rule.</param>
        /// <param name="_timezonedefinitionidValue">Unique identifier of the
        /// time zone definition.</param>
        /// <param name="standarddayofweek">Day of the week when standard time
        /// starts.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// last modified the time zone rule.</param>
        /// <param name="daylighthour">Hour of the day when daylight savings
        /// time starts</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the timezonerule.</param>
        /// <param name="effectivedatetime">Time that this rule takes effect,
        /// in local time.</param>
        /// <param name="_organizationidValue">Unique identifier of the
        /// organization associated with the time zone rule.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who last modified the timezonerule.</param>
        /// <param name="daylightdayofweek">Day of the week when daylight
        /// savings time starts.</param>
        /// <param name="daylightbias">Time bias in addition to the base bias
        /// for daylight savings time.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only</param>
        /// <param name="daylightyear">Year when daylight savings times
        /// starts.</param>
        /// <param name="daylightday">Day of the month when daylight savings
        /// time starts.</param>
        public MicrosoftDynamicsCRMtimezonerule(int? standardmonth = default(int?), int? standardhour = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? standardsecond = default(int?), string versionnumber = default(string), string timezoneruleid = default(string), int? daylightsecond = default(int?), int? bias = default(int?), int? standardyear = default(int?), int? daylightminute = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? standardday = default(int?), int? standardbias = default(int?), int? daylightmonth = default(int?), int? standardminute = default(int?), string _createdbyValue = default(string), string _timezonedefinitionidValue = default(string), int? standarddayofweek = default(int?), string _modifiedbyValue = default(string), int? daylighthour = default(int?), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? effectivedatetime = default(System.DateTimeOffset?), string _organizationidValue = default(string), string _modifiedonbehalfbyValue = default(string), int? daylightdayofweek = default(int?), int? daylightbias = default(int?), int? timezoneruleversionnumber = default(int?), int? daylightyear = default(int?), int? daylightday = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtimezonedefinition timezonedefinitionid = default(MicrosoftDynamicsCRMtimezonedefinition), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Standardmonth = standardmonth;
            Standardhour = standardhour;
            Createdon = createdon;
            Standardsecond = standardsecond;
            Versionnumber = versionnumber;
            Timezoneruleid = timezoneruleid;
            Daylightsecond = daylightsecond;
            Bias = bias;
            Standardyear = standardyear;
            Daylightminute = daylightminute;
            Modifiedon = modifiedon;
            Standardday = standardday;
            Standardbias = standardbias;
            Daylightmonth = daylightmonth;
            Standardminute = standardminute;
            this._createdbyValue = _createdbyValue;
            this._timezonedefinitionidValue = _timezonedefinitionidValue;
            Standarddayofweek = standarddayofweek;
            this._modifiedbyValue = _modifiedbyValue;
            Daylighthour = daylighthour;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Effectivedatetime = effectivedatetime;
            this._organizationidValue = _organizationidValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Daylightdayofweek = daylightdayofweek;
            Daylightbias = daylightbias;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Daylightyear = daylightyear;
            Daylightday = daylightday;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Timezonedefinitionid = timezonedefinitionid;
            Modifiedonbehalfby = modifiedonbehalfby;
            Modifiedby = modifiedby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets month when standard time starts.
        /// </summary>
        [JsonProperty(PropertyName = "standardmonth")]
        public int? Standardmonth { get; set; }

        /// <summary>
        /// Gets or sets hour of the day when standard time starts.
        /// </summary>
        [JsonProperty(PropertyName = "standardhour")]
        public int? Standardhour { get; set; }

        /// <summary>
        /// Gets or sets date and time when the time zone rule was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets second of the Minute when standard time starts.
        /// </summary>
        [JsonProperty(PropertyName = "standardsecond")]
        public int? Standardsecond { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the time zone rule.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleid")]
        public string Timezoneruleid { get; set; }

        /// <summary>
        /// Gets or sets second of the minute when daylight savings time starts
        /// </summary>
        [JsonProperty(PropertyName = "daylightsecond")]
        public int? Daylightsecond { get; set; }

        /// <summary>
        /// Gets or sets base time bias of the time zone rule.
        /// </summary>
        [JsonProperty(PropertyName = "bias")]
        public int? Bias { get; set; }

        /// <summary>
        /// Gets or sets year when standard time starts.
        /// </summary>
        [JsonProperty(PropertyName = "standardyear")]
        public int? Standardyear { get; set; }

        /// <summary>
        /// Gets or sets minute of the hour when daylight savings time starts.
        /// </summary>
        [JsonProperty(PropertyName = "daylightminute")]
        public int? Daylightminute { get; set; }

        /// <summary>
        /// Gets or sets date and time when the time zone rule was modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets day of the month when standard time starts.
        /// </summary>
        [JsonProperty(PropertyName = "standardday")]
        public int? Standardday { get; set; }

        /// <summary>
        /// Gets or sets time bias in addition to the base bias for standard
        /// time.
        /// </summary>
        [JsonProperty(PropertyName = "standardbias")]
        public int? Standardbias { get; set; }

        /// <summary>
        /// Gets or sets month when daylight savings time starts.
        /// </summary>
        [JsonProperty(PropertyName = "daylightmonth")]
        public int? Daylightmonth { get; set; }

        /// <summary>
        /// Gets or sets minute of the hour when standard time starts.
        /// </summary>
        [JsonProperty(PropertyName = "standardminute")]
        public int? Standardminute { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the time
        /// zone rule.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the time zone definition.
        /// </summary>
        [JsonProperty(PropertyName = "_timezonedefinitionid_value")]
        public string _timezonedefinitionidValue { get; set; }

        /// <summary>
        /// Gets or sets day of the week when standard time starts.
        /// </summary>
        [JsonProperty(PropertyName = "standarddayofweek")]
        public int? Standarddayofweek { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who last modified the
        /// time zone rule.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets hour of the day when daylight savings time starts
        /// </summary>
        [JsonProperty(PropertyName = "daylighthour")]
        public int? Daylighthour { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// timezonerule.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets time that this rule takes effect, in local time.
        /// </summary>
        [JsonProperty(PropertyName = "effectivedatetime")]
        public System.DateTimeOffset? Effectivedatetime { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the organization associated with
        /// the time zone rule.
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who last
        /// modified the timezonerule.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets day of the week when daylight savings time starts.
        /// </summary>
        [JsonProperty(PropertyName = "daylightdayofweek")]
        public int? Daylightdayofweek { get; set; }

        /// <summary>
        /// Gets or sets time bias in addition to the base bias for daylight
        /// savings time.
        /// </summary>
        [JsonProperty(PropertyName = "daylightbias")]
        public int? Daylightbias { get; set; }

        /// <summary>
        /// Gets or sets for internal use only
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets year when daylight savings times starts.
        /// </summary>
        [JsonProperty(PropertyName = "daylightyear")]
        public int? Daylightyear { get; set; }

        /// <summary>
        /// Gets or sets day of the month when daylight savings time starts.
        /// </summary>
        [JsonProperty(PropertyName = "daylightday")]
        public int? Daylightday { get; set; }

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
        [JsonProperty(PropertyName = "timezonedefinitionid")]
        public MicrosoftDynamicsCRMtimezonedefinition Timezonedefinitionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

    }
}
