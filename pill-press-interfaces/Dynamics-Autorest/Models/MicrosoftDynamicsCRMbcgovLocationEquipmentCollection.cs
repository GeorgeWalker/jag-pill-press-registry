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
    /// Collection of bcgov_location_equipment
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.bcgov_location_equipmentCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMbcgovLocationEquipmentCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovLocationEquipmentCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovLocationEquipmentCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbcgovLocationEquipmentCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMbcgovLocationEquipmentCollection(IList<MicrosoftDynamicsCRMbcgovLocationEquipment> value = default(IList<MicrosoftDynamicsCRMbcgovLocationEquipment>))
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
        public IList<MicrosoftDynamicsCRMbcgovLocationEquipment> Value { get; set; }

    }
}