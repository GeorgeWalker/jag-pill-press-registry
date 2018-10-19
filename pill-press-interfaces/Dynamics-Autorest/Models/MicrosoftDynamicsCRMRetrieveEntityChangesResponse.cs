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
    /// RetrieveEntityChangesResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMRetrieveEntityChangesResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveEntityChangesResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveEntityChangesResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveEntityChangesResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveEntityChangesResponse(MicrosoftDynamicsCRMBusinessEntityChanges entityChanges = default(MicrosoftDynamicsCRMBusinessEntityChanges))
        {
            EntityChanges = entityChanges;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntityChanges")]
        public MicrosoftDynamicsCRMBusinessEntityChanges EntityChanges { get; set; }

    }
}
