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
    /// Collection of knowledgearticleincidents
    /// </summary>
    public partial class KnowledgearticleincidentsGetResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// KnowledgearticleincidentsGetResponseModel class.
        /// </summary>
        public KnowledgearticleincidentsGetResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// KnowledgearticleincidentsGetResponseModel class.
        /// </summary>
        public KnowledgearticleincidentsGetResponseModel(IList<MicrosoftDynamicsCRMknowledgearticleincident> value = default(IList<MicrosoftDynamicsCRMknowledgearticleincident>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MicrosoftDynamicsCRMknowledgearticleincident> Value { get; set; }

    }
}
