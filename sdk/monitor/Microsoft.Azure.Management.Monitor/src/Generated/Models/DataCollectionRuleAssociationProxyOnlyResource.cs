// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Definition of generic ARM proxy resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DataCollectionRuleAssociationProxyOnlyResource : IResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DataCollectionRuleAssociationProxyOnlyResource class.
        /// </summary>
        public DataCollectionRuleAssociationProxyOnlyResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DataCollectionRuleAssociationProxyOnlyResource class.
        /// </summary>
        /// <param name="description">Description of the association.</param>
        /// <param name="dataCollectionRuleId">The resource ID of the data
        /// collection rule that is to be associated.</param>
        /// <param name="dataCollectionEndpointId">The resource ID of the data
        /// collection endpoint that is to be associated.</param>
        /// <param name="provisioningState">The resource provisioning state.
        /// Possible values include: 'Creating', 'Updating', 'Deleting',
        /// 'Succeeded', 'Failed'</param>
        /// <param name="metadata">Metadata about the resource</param>
        /// <param name="id">Fully qualified ID of the resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="etag">Resource entity tag (ETag).</param>
        /// <param name="systemData">Metadata pertaining to creation and last
        /// modification of the resource.</param>
        public DataCollectionRuleAssociationProxyOnlyResource(string description = default(string), string dataCollectionRuleId = default(string), string dataCollectionEndpointId = default(string), string provisioningState = default(string), DataCollectionRuleAssociationMetadata metadata = default(DataCollectionRuleAssociationMetadata), string id = default(string), string name = default(string), string type = default(string), string etag = default(string), DataCollectionRuleAssociationProxyOnlyResourceSystemData systemData = default(DataCollectionRuleAssociationProxyOnlyResourceSystemData))
        {
            Description = description;
            DataCollectionRuleId = dataCollectionRuleId;
            DataCollectionEndpointId = dataCollectionEndpointId;
            ProvisioningState = provisioningState;
            Metadata = metadata;
            Id = id;
            Name = name;
            Type = type;
            Etag = etag;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets description of the association.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the resource ID of the data collection rule that is to
        /// be associated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataCollectionRuleId")]
        public string DataCollectionRuleId { get; set; }

        /// <summary>
        /// Gets or sets the resource ID of the data collection endpoint that
        /// is to be associated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataCollectionEndpointId")]
        public string DataCollectionEndpointId { get; set; }

        /// <summary>
        /// Gets the resource provisioning state. Possible values include:
        /// 'Creating', 'Updating', 'Deleting', 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets metadata about the resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.metadata")]
        public DataCollectionRuleAssociationMetadata Metadata { get; private set; }

        /// <summary>
        /// Gets fully qualified ID of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets resource entity tag (ETag).
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets metadata pertaining to creation and last modification of the
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public DataCollectionRuleAssociationProxyOnlyResourceSystemData SystemData { get; private set; }

    }
}
