// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SignalR.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a Shared Private Link Resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SharedPrivateLinkResource : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the SharedPrivateLinkResource class.
        /// </summary>
        public SharedPrivateLinkResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SharedPrivateLinkResource class.
        /// </summary>
        /// <param name="groupId">The group id from the provider of resource
        /// the shared private link resource is for</param>
        /// <param name="privateLinkResourceId">The resource id of the resource
        /// the shared private link resource is for</param>
        /// <param name="id">Fully qualified resource Id for the
        /// resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource - e.g.
        /// "Microsoft.SignalRService/SignalR"</param>
        /// <param name="systemData">Metadata pertaining to creation and last
        /// modification of the resource.</param>
        /// <param name="provisioningState">Provisioning state of the shared
        /// private link resource. Possible values include: 'Unknown',
        /// 'Succeeded', 'Failed', 'Canceled', 'Running', 'Creating',
        /// 'Updating', 'Deleting', 'Moving'</param>
        /// <param name="requestMessage">The request message for requesting
        /// approval of the shared private link resource</param>
        /// <param name="status">Status of the shared private link resource.
        /// Possible values include: 'Pending', 'Approved', 'Rejected',
        /// 'Disconnected', 'Timeout'</param>
        public SharedPrivateLinkResource(string groupId, string privateLinkResourceId, string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), string provisioningState = default(string), string requestMessage = default(string), string status = default(string))
            : base(id, name, type)
        {
            SystemData = systemData;
            GroupId = groupId;
            PrivateLinkResourceId = privateLinkResourceId;
            ProvisioningState = provisioningState;
            RequestMessage = requestMessage;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets metadata pertaining to creation and last modification of the
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Gets or sets the group id from the provider of resource the shared
        /// private link resource is for
        /// </summary>
        [JsonProperty(PropertyName = "properties.groupId")]
        public string GroupId { get; set; }

        /// <summary>
        /// Gets or sets the resource id of the resource the shared private
        /// link resource is for
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateLinkResourceId")]
        public string PrivateLinkResourceId { get; set; }

        /// <summary>
        /// Gets provisioning state of the shared private link resource.
        /// Possible values include: 'Unknown', 'Succeeded', 'Failed',
        /// 'Canceled', 'Running', 'Creating', 'Updating', 'Deleting', 'Moving'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the request message for requesting approval of the
        /// shared private link resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestMessage")]
        public string RequestMessage { get; set; }

        /// <summary>
        /// Gets status of the shared private link resource. Possible values
        /// include: 'Pending', 'Approved', 'Rejected', 'Disconnected',
        /// 'Timeout'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (GroupId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "GroupId");
            }
            if (PrivateLinkResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PrivateLinkResourceId");
            }
        }
    }
}
