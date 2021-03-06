// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Result of the post subvolume and action is to get metadata of the
    /// subvolume.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SubvolumeModel
    {
        /// <summary>
        /// Initializes a new instance of the SubvolumeModel class.
        /// </summary>
        public SubvolumeModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubvolumeModel class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="path">path</param>
        /// <param name="parentPath">parentpath</param>
        /// <param name="size">size</param>
        /// <param name="bytesUsed">bytesUsed</param>
        /// <param name="permissions">permissions</param>
        /// <param name="creationTimeStamp">creationTimeStamp</param>
        /// <param name="accessedTimeStamp">accessedTimeStamp</param>
        /// <param name="modifiedTimeStamp">modifiedTimeStamp</param>
        /// <param name="changedTimeStamp">changedTimeStamp</param>
        /// <param name="provisioningState">Azure lifecycle management</param>
        public SubvolumeModel(string id = default(string), string name = default(string), string type = default(string), string path = default(string), string parentPath = default(string), long? size = default(long?), long? bytesUsed = default(long?), string permissions = default(string), System.DateTime? creationTimeStamp = default(System.DateTime?), System.DateTime? accessedTimeStamp = default(System.DateTime?), System.DateTime? modifiedTimeStamp = default(System.DateTime?), System.DateTime? changedTimeStamp = default(System.DateTime?), string provisioningState = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            Path = path;
            ParentPath = parentPath;
            Size = size;
            BytesUsed = bytesUsed;
            Permissions = permissions;
            CreationTimeStamp = creationTimeStamp;
            AccessedTimeStamp = accessedTimeStamp;
            ModifiedTimeStamp = modifiedTimeStamp;
            ChangedTimeStamp = changedTimeStamp;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets resource Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets resource name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets resource type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets path
        /// </summary>
        /// <remarks>
        /// Path to the subvolume
        /// </remarks>
        [JsonProperty(PropertyName = "properties.path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets parentpath
        /// </summary>
        /// <remarks>
        /// Path to the parent subvolume
        /// </remarks>
        [JsonProperty(PropertyName = "properties.parentPath")]
        public string ParentPath { get; set; }

        /// <summary>
        /// Gets or sets size
        /// </summary>
        /// <remarks>
        /// Size of subvolume
        /// </remarks>
        [JsonProperty(PropertyName = "properties.size")]
        public long? Size { get; set; }

        /// <summary>
        /// Gets or sets bytesUsed
        /// </summary>
        /// <remarks>
        /// Bytes used
        /// </remarks>
        [JsonProperty(PropertyName = "properties.bytesUsed")]
        public long? BytesUsed { get; set; }

        /// <summary>
        /// Gets or sets permissions
        /// </summary>
        /// <remarks>
        /// Permissions of the subvolume
        /// </remarks>
        [JsonProperty(PropertyName = "properties.permissions")]
        public string Permissions { get; set; }

        /// <summary>
        /// Gets or sets creationTimeStamp
        /// </summary>
        /// <remarks>
        /// Creation time and date
        /// </remarks>
        [JsonProperty(PropertyName = "properties.creationTimeStamp")]
        public System.DateTime? CreationTimeStamp { get; set; }

        /// <summary>
        /// Gets or sets accessedTimeStamp
        /// </summary>
        /// <remarks>
        /// Most recent access time and date
        /// </remarks>
        [JsonProperty(PropertyName = "properties.accessedTimeStamp")]
        public System.DateTime? AccessedTimeStamp { get; set; }

        /// <summary>
        /// Gets or sets modifiedTimeStamp
        /// </summary>
        /// <remarks>
        /// Most recent modification time and date
        /// </remarks>
        [JsonProperty(PropertyName = "properties.modifiedTimeStamp")]
        public System.DateTime? ModifiedTimeStamp { get; set; }

        /// <summary>
        /// Gets or sets changedTimeStamp
        /// </summary>
        /// <remarks>
        /// Most recent change time and date
        /// </remarks>
        [JsonProperty(PropertyName = "properties.changedTimeStamp")]
        public System.DateTime? ChangedTimeStamp { get; set; }

        /// <summary>
        /// Gets or sets azure lifecycle management
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

    }
}
