// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Redis.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Response to put/get linked server (with properties) for Redis cache.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RedisLinkedServerWithProperties : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the RedisLinkedServerWithProperties
        /// class.
        /// </summary>
        public RedisLinkedServerWithProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RedisLinkedServerWithProperties
        /// class.
        /// </summary>
        /// <param name="linkedRedisCacheId">Fully qualified resourceId of the
        /// linked redis cache.</param>
        /// <param name="linkedRedisCacheLocation">Location of the linked redis
        /// cache.</param>
        /// <param name="serverRole">Role of the linked server. Possible values
        /// include: 'Primary', 'Secondary'</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="provisioningState">Terminal state of the link between
        /// primary and secondary redis cache.</param>
        public RedisLinkedServerWithProperties(string linkedRedisCacheId, string linkedRedisCacheLocation, ReplicationRole serverRole, string id = default(string), string name = default(string), string type = default(string), string provisioningState = default(string))
            : base(id, name, type)
        {
            LinkedRedisCacheId = linkedRedisCacheId;
            LinkedRedisCacheLocation = linkedRedisCacheLocation;
            ServerRole = serverRole;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets fully qualified resourceId of the linked redis cache.
        /// </summary>
        [JsonProperty(PropertyName = "properties.linkedRedisCacheId")]
        public string LinkedRedisCacheId { get; set; }

        /// <summary>
        /// Gets or sets location of the linked redis cache.
        /// </summary>
        [JsonProperty(PropertyName = "properties.linkedRedisCacheLocation")]
        public string LinkedRedisCacheLocation { get; set; }

        /// <summary>
        /// Gets or sets role of the linked server. Possible values include:
        /// 'Primary', 'Secondary'
        /// </summary>
        [JsonProperty(PropertyName = "properties.serverRole")]
        public ReplicationRole ServerRole { get; set; }

        /// <summary>
        /// Gets terminal state of the link between primary and secondary redis
        /// cache.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (LinkedRedisCacheId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LinkedRedisCacheId");
            }
            if (LinkedRedisCacheLocation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LinkedRedisCacheLocation");
            }
        }
    }
}
