// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The activation properties of the connected registry.
    /// </summary>
    public partial class ActivationProperties
    {
        /// <summary>
        /// Initializes a new instance of the ActivationProperties class.
        /// </summary>
        public ActivationProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActivationProperties class.
        /// </summary>
        /// <param name="status">The activation status of the connected
        /// registry. Possible values include: 'Active', 'Inactive'</param>
        public ActivationProperties(string status = default(string))
        {
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the activation status of the connected registry. Possible
        /// values include: 'Active', 'Inactive'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

    }
}
