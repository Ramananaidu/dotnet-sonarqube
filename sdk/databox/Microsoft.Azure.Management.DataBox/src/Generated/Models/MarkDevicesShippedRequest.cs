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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The request body to provide the delivery package details of job
    /// </summary>
    public partial class MarkDevicesShippedRequest
    {
        /// <summary>
        /// Initializes a new instance of the MarkDevicesShippedRequest class.
        /// </summary>
        public MarkDevicesShippedRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MarkDevicesShippedRequest class.
        /// </summary>
        /// <param name="deliverToDcPackageDetails">Delivery package
        /// details</param>
        public MarkDevicesShippedRequest(PackageCarrierInfo deliverToDcPackageDetails)
        {
            DeliverToDcPackageDetails = deliverToDcPackageDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets delivery package details
        /// </summary>
        [JsonProperty(PropertyName = "deliverToDcPackageDetails")]
        public PackageCarrierInfo DeliverToDcPackageDetails { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DeliverToDcPackageDetails == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DeliverToDcPackageDetails");
            }
        }
    }
}
