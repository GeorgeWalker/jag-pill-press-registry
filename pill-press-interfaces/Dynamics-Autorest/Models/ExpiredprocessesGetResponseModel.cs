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
    /// Collection of expiredprocesses
    /// </summary>
    public partial class ExpiredprocessesGetResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the ExpiredprocessesGetResponseModel
        /// class.
        /// </summary>
        public ExpiredprocessesGetResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExpiredprocessesGetResponseModel
        /// class.
        /// </summary>
        public ExpiredprocessesGetResponseModel(IList<MicrosoftDynamicsCRMexpiredprocess> value = default(IList<MicrosoftDynamicsCRMexpiredprocess>))
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
        public IList<MicrosoftDynamicsCRMexpiredprocess> Value { get; set; }

    }
}
