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
    /// entitlementtemplateproducts
    /// </summary>
    public partial class MicrosoftDynamicsCRMentitlementtemplateproducts
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMentitlementtemplateproducts class.
        /// </summary>
        public MicrosoftDynamicsCRMentitlementtemplateproducts()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMentitlementtemplateproducts class.
        /// </summary>
        public MicrosoftDynamicsCRMentitlementtemplateproducts(string productid = default(string), string entitlementtemplateproductid = default(string), string entitlementtemplateid = default(string), long? versionnumber = default(long?))
        {
            Productid = productid;
            Entitlementtemplateproductid = entitlementtemplateproductid;
            Entitlementtemplateid = entitlementtemplateid;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productid")]
        public string Productid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplateproductid")]
        public string Entitlementtemplateproductid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplateid")]
        public string Entitlementtemplateid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

    }
}
