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
    /// ExportSolutionResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMExportSolutionResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMExportSolutionResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMExportSolutionResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMExportSolutionResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMExportSolutionResponse(object exportSolutionFile = default(object))
        {
            ExportSolutionFile = exportSolutionFile;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ExportSolutionFile")]
        public object ExportSolutionFile { get; set; }

    }
}
