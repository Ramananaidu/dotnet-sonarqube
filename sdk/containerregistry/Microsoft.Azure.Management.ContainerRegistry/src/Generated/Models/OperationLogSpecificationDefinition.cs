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
    /// The definition of Azure Monitoring log.
    /// </summary>
    public partial class OperationLogSpecificationDefinition
    {
        /// <summary>
        /// Initializes a new instance of the
        /// OperationLogSpecificationDefinition class.
        /// </summary>
        public OperationLogSpecificationDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// OperationLogSpecificationDefinition class.
        /// </summary>
        /// <param name="name">Log name.</param>
        /// <param name="displayName">Log display name.</param>
        /// <param name="blobDuration">Log blob duration.</param>
        public OperationLogSpecificationDefinition(string name = default(string), string displayName = default(string), string blobDuration = default(string))
        {
            Name = name;
            DisplayName = displayName;
            BlobDuration = blobDuration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets log name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets log display name.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets log blob duration.
        /// </summary>
        [JsonProperty(PropertyName = "blobDuration")]
        public string BlobDuration { get; set; }

    }
}
