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
    /// Collection of entitlementproductscollection
    /// </summary>
    public partial class EntitlementproductscollectionGetResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// EntitlementproductscollectionGetResponseModel class.
        /// </summary>
        public EntitlementproductscollectionGetResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// EntitlementproductscollectionGetResponseModel class.
        /// </summary>
        public EntitlementproductscollectionGetResponseModel(IList<MicrosoftDynamicsCRMentitlementproducts> value = default(IList<MicrosoftDynamicsCRMentitlementproducts>))
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
        public IList<MicrosoftDynamicsCRMentitlementproducts> Value { get; set; }

    }
}
