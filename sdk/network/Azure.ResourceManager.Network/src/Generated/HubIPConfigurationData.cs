// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the HubIPConfiguration data model. </summary>
    public partial class HubIPConfigurationData : SubResource
    {
        /// <summary> Initializes a new instance of HubIPConfigurationData. </summary>
        public HubIPConfigurationData()
        {
        }

        /// <summary> Initializes a new instance of HubIPConfigurationData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Name of the Ip Configuration. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="resourceType"> Ipconfiguration type. </param>
        /// <param name="privateIPAddress"> The private IP address of the IP configuration. </param>
        /// <param name="privateIPAllocationMethod"> The private IP address allocation method. </param>
        /// <param name="subnet"> The reference to the subnet resource. </param>
        /// <param name="publicIPAddress"> The reference to the public IP resource. </param>
        /// <param name="provisioningState"> The provisioning state of the IP configuration resource. </param>
        internal HubIPConfigurationData(string id, string name, string etag, string resourceType, string privateIPAddress, IPAllocationMethod? privateIPAllocationMethod, SubnetData subnet, PublicIPAddressData publicIPAddress, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            ResourceType = resourceType;
            PrivateIPAddress = privateIPAddress;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            Subnet = subnet;
            PublicIPAddress = publicIPAddress;
            ProvisioningState = provisioningState;
        }

        /// <summary> Name of the Ip Configuration. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Ipconfiguration type. </summary>
        public string ResourceType { get; }
        /// <summary> The private IP address of the IP configuration. </summary>
        public string PrivateIPAddress { get; set; }
        /// <summary> The private IP address allocation method. </summary>
        public IPAllocationMethod? PrivateIPAllocationMethod { get; set; }
        /// <summary> The reference to the subnet resource. </summary>
        public SubnetData Subnet { get; set; }
        /// <summary> The reference to the public IP resource. </summary>
        public PublicIPAddressData PublicIPAddress { get; set; }
        /// <summary> The provisioning state of the IP configuration resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
