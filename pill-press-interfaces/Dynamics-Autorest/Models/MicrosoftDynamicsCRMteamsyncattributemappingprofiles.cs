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
    /// teamsyncattributemappingprofiles
    /// </summary>
    public partial class MicrosoftDynamicsCRMteamsyncattributemappingprofiles
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMteamsyncattributemappingprofiles class.
        /// </summary>
        public MicrosoftDynamicsCRMteamsyncattributemappingprofiles()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMteamsyncattributemappingprofiles class.
        /// </summary>
        public MicrosoftDynamicsCRMteamsyncattributemappingprofiles(string teamsyncattributemappingprofileid = default(string), string syncattributemappingprofileid = default(string), long? versionnumber = default(long?), string teamid = default(string))
        {
            Teamsyncattributemappingprofileid = teamsyncattributemappingprofileid;
            Syncattributemappingprofileid = syncattributemappingprofileid;
            Versionnumber = versionnumber;
            Teamid = teamid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teamsyncattributemappingprofileid")]
        public string Teamsyncattributemappingprofileid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "syncattributemappingprofileid")]
        public string Syncattributemappingprofileid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teamid")]
        public string Teamid { get; set; }

    }
}
