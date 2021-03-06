// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The managed application properties. </summary>
    internal partial class ApplicationPropertiesPatchable
    {
        /// <summary> Initializes a new instance of ApplicationPropertiesPatchable. </summary>
        internal ApplicationPropertiesPatchable()
        {
        }

        /// <summary> The managed resource group Id. </summary>
        public string ManagedResourceGroupId { get; }
        /// <summary> The fully qualified path of managed application definition Id. </summary>
        public string ApplicationDefinitionId { get; }
        /// <summary> Name and value pairs that define the managed application parameters. It can be a JObject or a well formed JSON string. </summary>
        public BinaryData Parameters { get; }
        /// <summary> Name and value pairs that define the managed application outputs. </summary>
        public BinaryData Outputs { get; }
        /// <summary> The managed application provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
