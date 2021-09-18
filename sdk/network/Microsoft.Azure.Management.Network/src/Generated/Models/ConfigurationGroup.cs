// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The network configuration group resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ConfigurationGroup
    {
        /// <summary>
        /// Initializes a new instance of the ConfigurationGroup class.
        /// </summary>
        public ConfigurationGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConfigurationGroup class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="displayName">A friendly name for the network
        /// group.</param>
        /// <param name="description">A description of the network
        /// group.</param>
        /// <param name="memberType">Group member type.</param>
        /// <param name="groupMembers">Group members of network group.</param>
        /// <param name="conditionalMembership">Network group conditional
        /// filter.</param>
        /// <param name="provisioningState">The provisioning state of the scope
        /// assignment resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'</param>
        public ConfigurationGroup(string id = default(string), string displayName = default(string), string description = default(string), string memberType = default(string), IList<GroupMembersItem> groupMembers = default(IList<GroupMembersItem>), string conditionalMembership = default(string), string provisioningState = default(string))
        {
            Id = id;
            DisplayName = displayName;
            Description = description;
            MemberType = memberType;
            GroupMembers = groupMembers;
            ConditionalMembership = conditionalMembership;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets a friendly name for the network group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets a description of the network group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets group member type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.memberType")]
        public string MemberType { get; set; }

        /// <summary>
        /// Gets or sets group members of network group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.groupMembers")]
        public IList<GroupMembersItem> GroupMembers { get; set; }

        /// <summary>
        /// Gets or sets network group conditional filter.
        /// </summary>
        [JsonProperty(PropertyName = "properties.conditionalMembership")]
        public string ConditionalMembership { get; set; }

        /// <summary>
        /// Gets the provisioning state of the scope assignment resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

    }
}
