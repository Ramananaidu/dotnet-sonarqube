// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information to be stored in Vault properties as an element of
    /// privateEndpointConnections List.
    /// </summary>
    public partial class PrivateEndpointConnectionVaultProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PrivateEndpointConnectionVaultProperties class.
        /// </summary>
        public PrivateEndpointConnectionVaultProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PrivateEndpointConnectionVaultProperties class.
        /// </summary>
        /// <param name="id">Format of id
        /// subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.[Service]/{resource}/{resourceName}/privateEndpointConnections/{connectionName}.</param>
        /// <param name="name">The name of the private Endpoint
        /// Connection</param>
        /// <param name="type">The type, which will be of the format,
        /// Microsoft.RecoveryServices/vaults/privateEndpointConnections</param>
        /// <param name="location">The location of the private Endpoint
        /// connection</param>
        public PrivateEndpointConnectionVaultProperties(string id = default(string), PrivateEndpointConnection properties = default(PrivateEndpointConnection), string name = default(string), string type = default(string), string location = default(string))
        {
            Id = id;
            Properties = properties;
            Name = name;
            Type = type;
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets format of id
        /// subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.[Service]/{resource}/{resourceName}/privateEndpointConnections/{connectionName}.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public PrivateEndpointConnection Properties { get; set; }

        /// <summary>
        /// Gets the name of the private Endpoint Connection
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the type, which will be of the format,
        /// Microsoft.RecoveryServices/vaults/privateEndpointConnections
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets the location of the private Endpoint connection
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

    }
}
