// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Provides details about resource creation and update time
    /// </summary>
    public partial class SystemData
    {
        /// <summary>
        /// Initializes a new instance of the SystemData class.
        /// </summary>
        public SystemData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SystemData class.
        /// </summary>
        /// <param name="createdBy">A string identifier for the identity that
        /// created the resource</param>
        /// <param name="createdByType">The type of identity that created the
        /// resource: user, application, managedIdentity</param>
        /// <param name="createdAt">The timestamp of resource creation
        /// (UTC)</param>
        /// <param name="lastModifiedBy">A string identifier for the identity
        /// that last modified the resource</param>
        /// <param name="lastModifiedByType">The type of identity that last
        /// modified the resource: user, application, managedIdentity</param>
        /// <param name="lastModifiedAt">The timestamp of resource last
        /// modification (UTC)</param>
        public SystemData(string createdBy = default(string), string createdByType = default(string), System.DateTime? createdAt = default(System.DateTime?), string lastModifiedBy = default(string), string lastModifiedByType = default(string), System.DateTime? lastModifiedAt = default(System.DateTime?))
        {
            CreatedBy = createdBy;
            CreatedByType = createdByType;
            CreatedAt = createdAt;
            LastModifiedBy = lastModifiedBy;
            LastModifiedByType = lastModifiedByType;
            LastModifiedAt = lastModifiedAt;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a string identifier for the identity that created the resource
        /// </summary>
        [JsonProperty(PropertyName = "createdBy")]
        public string CreatedBy { get; private set; }

        /// <summary>
        /// Gets the type of identity that created the resource: user,
        /// application, managedIdentity
        /// </summary>
        [JsonProperty(PropertyName = "createdByType")]
        public string CreatedByType { get; private set; }

        /// <summary>
        /// Gets the timestamp of resource creation (UTC)
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public System.DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Gets a string identifier for the identity that last modified the
        /// resource
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedBy")]
        public string LastModifiedBy { get; private set; }

        /// <summary>
        /// Gets the type of identity that last modified the resource: user,
        /// application, managedIdentity
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedByType")]
        public string LastModifiedByType { get; private set; }

        /// <summary>
        /// Gets the timestamp of resource last modification (UTC)
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedAt")]
        public System.DateTime? LastModifiedAt { get; private set; }

    }
}
