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
    /// ValidationResult
    /// </summary>
    public partial class MicrosoftDynamicsCRMValidationResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMValidationResult class.
        /// </summary>
        public MicrosoftDynamicsCRMValidationResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMValidationResult class.
        /// </summary>
        public MicrosoftDynamicsCRMValidationResult(bool? validationSuccess = default(bool?), MicrosoftDynamicsCRMTraceInfo traceInfo = default(MicrosoftDynamicsCRMTraceInfo), string activityId = default(string))
        {
            ValidationSuccess = validationSuccess;
            TraceInfo = traceInfo;
            ActivityId = activityId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ValidationSuccess")]
        public bool? ValidationSuccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TraceInfo")]
        public MicrosoftDynamicsCRMTraceInfo TraceInfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ActivityId")]
        public string ActivityId { get; set; }

    }
}
