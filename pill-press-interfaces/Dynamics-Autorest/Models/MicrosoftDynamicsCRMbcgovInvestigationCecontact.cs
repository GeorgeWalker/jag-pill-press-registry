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
    /// Microsoft.Dynamics.CRM.bcgov_investigation_cecontact
    /// </summary>
    public partial class MicrosoftDynamicsCRMbcgovInvestigationCecontact
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovInvestigationCecontact class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovInvestigationCecontact()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovInvestigationCecontact class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovInvestigationCecontact(string bcgovInvestigationid = default(string), string versionnumber = default(string), string bcgovInvestigationCecontactid = default(string), string bcgovCecontactid = default(string))
        {
            BcgovInvestigationid = bcgovInvestigationid;
            Versionnumber = versionnumber;
            BcgovInvestigationCecontactid = bcgovInvestigationCecontactid;
            BcgovCecontactid = bcgovCecontactid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_investigationid")]
        public string BcgovInvestigationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_investigation_cecontactid")]
        public string BcgovInvestigationCecontactid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_cecontactid")]
        public string BcgovCecontactid { get; set; }

    }
}