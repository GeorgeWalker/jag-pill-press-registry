// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// RetrieveOrganizationResourcesResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMRetrieveOrganizationResourcesResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveOrganizationResourcesResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveOrganizationResourcesResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveOrganizationResourcesResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveOrganizationResourcesResponse(MicrosoftDynamicsCRMOrganizationResources organizationResources = default(MicrosoftDynamicsCRMOrganizationResources))
        {
            OrganizationResources = organizationResources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrganizationResources")]
        public MicrosoftDynamicsCRMOrganizationResources OrganizationResources { get; set; }

    }
}
