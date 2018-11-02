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
    /// RetrieveMissingComponentsResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMRetrieveMissingComponentsResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveMissingComponentsResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveMissingComponentsResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveMissingComponentsResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveMissingComponentsResponse(IList<MicrosoftDynamicsCRMMissingComponent> missingComponents = default(IList<MicrosoftDynamicsCRMMissingComponent>))
        {
            MissingComponents = missingComponents;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MissingComponents")]
        public IList<MicrosoftDynamicsCRMMissingComponent> MissingComponents { get; set; }

    }
}
