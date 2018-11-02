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
    /// IntegerAttributeMetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMIntegerAttributeMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMIntegerAttributeMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMIntegerAttributeMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMIntegerAttributeMetadata class.
        /// </summary>
        /// <param name="format">Possible values include: 'None', 'Duration',
        /// 'TimeZone', 'Language', 'Locale'</param>
        public MicrosoftDynamicsCRMIntegerAttributeMetadata(string format = default(string), int? maxValue = default(int?), int? minValue = default(int?), string formulaDefinition = default(string), int? sourceTypeMask = default(int?))
        {
            Format = format;
            MaxValue = maxValue;
            MinValue = minValue;
            FormulaDefinition = formulaDefinition;
            SourceTypeMask = sourceTypeMask;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'None', 'Duration',
        /// 'TimeZone', 'Language', 'Locale'
        /// </summary>
        [JsonProperty(PropertyName = "Format")]
        public string Format { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaxValue")]
        public int? MaxValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MinValue")]
        public int? MinValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FormulaDefinition")]
        public string FormulaDefinition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SourceTypeMask")]
        public int? SourceTypeMask { get; set; }

    }
}
