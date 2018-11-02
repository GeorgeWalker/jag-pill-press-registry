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
    /// BooleanAttributeMetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMBooleanAttributeMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMBooleanAttributeMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMBooleanAttributeMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMBooleanAttributeMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMBooleanAttributeMetadata(bool? defaultValue = default(bool?), string formulaDefinition = default(string), int? sourceTypeMask = default(int?), MicrosoftDynamicsCRMBooleanOptionSetMetadata optionSet = default(MicrosoftDynamicsCRMBooleanOptionSetMetadata), MicrosoftDynamicsCRMBooleanOptionSetMetadata globalOptionSet = default(MicrosoftDynamicsCRMBooleanOptionSetMetadata))
        {
            DefaultValue = defaultValue;
            FormulaDefinition = formulaDefinition;
            SourceTypeMask = sourceTypeMask;
            OptionSet = optionSet;
            GlobalOptionSet = globalOptionSet;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DefaultValue")]
        public bool? DefaultValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FormulaDefinition")]
        public string FormulaDefinition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SourceTypeMask")]
        public int? SourceTypeMask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OptionSet")]
        public MicrosoftDynamicsCRMBooleanOptionSetMetadata OptionSet { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GlobalOptionSet")]
        public MicrosoftDynamicsCRMBooleanOptionSetMetadata GlobalOptionSet { get; set; }

    }
}
