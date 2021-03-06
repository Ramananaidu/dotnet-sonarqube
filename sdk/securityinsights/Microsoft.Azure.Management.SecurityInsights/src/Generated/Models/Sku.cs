// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The pricing tier of the solution
    /// </summary>
    public partial class Sku
    {
        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        public Sku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        /// <param name="name">The kind of the tier. Possible values include:
        /// 'PerGB', 'CapacityReservation'</param>
        /// <param name="capacityReservationLevel">The amount of reservation
        /// level</param>
        public Sku(string name = default(string), int? capacityReservationLevel = default(int?))
        {
            Name = name;
            CapacityReservationLevel = capacityReservationLevel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the kind of the tier. Possible values include:
        /// 'PerGB', 'CapacityReservation'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the amount of reservation level
        /// </summary>
        [JsonProperty(PropertyName = "capacityReservationLevel")]
        public int? CapacityReservationLevel { get; set; }

    }
}
