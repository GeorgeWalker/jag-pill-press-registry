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
    /// FetchXmlToQueryExpressionResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMFetchXmlToQueryExpressionResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMFetchXmlToQueryExpressionResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMFetchXmlToQueryExpressionResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMFetchXmlToQueryExpressionResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMFetchXmlToQueryExpressionResponse(MicrosoftDynamicsCRMQueryExpression query = default(MicrosoftDynamicsCRMQueryExpression))
        {
            Query = query;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Query")]
        public MicrosoftDynamicsCRMQueryExpression Query { get; set; }

    }
}
