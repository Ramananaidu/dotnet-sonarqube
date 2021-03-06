// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Package carrier details.
    /// </summary>
    public partial class PackageCarrierDetails
    {
        /// <summary>
        /// Initializes a new instance of the PackageCarrierDetails class.
        /// </summary>
        public PackageCarrierDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PackageCarrierDetails class.
        /// </summary>
        /// <param name="carrierAccountNumber">Carrier Account Number of
        /// customer for customer disk.</param>
        /// <param name="carrierName">Name of the carrier.</param>
        /// <param name="trackingId">Tracking Id of shipment.</param>
        public PackageCarrierDetails(string carrierAccountNumber = default(string), string carrierName = default(string), string trackingId = default(string))
        {
            CarrierAccountNumber = carrierAccountNumber;
            CarrierName = carrierName;
            TrackingId = trackingId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets carrier Account Number of customer for customer disk.
        /// </summary>
        [JsonProperty(PropertyName = "carrierAccountNumber")]
        public string CarrierAccountNumber { get; set; }

        /// <summary>
        /// Gets or sets name of the carrier.
        /// </summary>
        [JsonProperty(PropertyName = "carrierName")]
        public string CarrierName { get; set; }

        /// <summary>
        /// Gets or sets tracking Id of shipment.
        /// </summary>
        [JsonProperty(PropertyName = "trackingId")]
        public string TrackingId { get; set; }

    }
}
