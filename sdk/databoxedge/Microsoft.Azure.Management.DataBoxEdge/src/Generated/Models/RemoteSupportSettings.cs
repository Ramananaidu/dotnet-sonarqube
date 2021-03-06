// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// RemoteApplicationType for which remote support settings is being
    /// modified
    /// </summary>
    public partial class RemoteSupportSettings
    {
        /// <summary>
        /// Initializes a new instance of the RemoteSupportSettings class.
        /// </summary>
        public RemoteSupportSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RemoteSupportSettings class.
        /// </summary>
        /// <param name="remoteApplicationType">Remote application type.
        /// Possible values include: 'Powershell', 'WAC', 'LocalUI',
        /// 'AllApplications'</param>
        /// <param name="accessLevel">Access level allowed for this remote
        /// application type. Possible values include: 'None', 'ReadOnly',
        /// 'ReadWrite', 'FullAccess'</param>
        /// <param name="expirationTimeStampInUTC">Expiration time
        /// stamp</param>
        public RemoteSupportSettings(string remoteApplicationType = default(string), string accessLevel = default(string), System.DateTime? expirationTimeStampInUTC = default(System.DateTime?))
        {
            RemoteApplicationType = remoteApplicationType;
            AccessLevel = accessLevel;
            ExpirationTimeStampInUTC = expirationTimeStampInUTC;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets remote application type. Possible values include:
        /// 'Powershell', 'WAC', 'LocalUI', 'AllApplications'
        /// </summary>
        [JsonProperty(PropertyName = "remoteApplicationType")]
        public string RemoteApplicationType { get; set; }

        /// <summary>
        /// Gets or sets access level allowed for this remote application type.
        /// Possible values include: 'None', 'ReadOnly', 'ReadWrite',
        /// 'FullAccess'
        /// </summary>
        [JsonProperty(PropertyName = "accessLevel")]
        public string AccessLevel { get; set; }

        /// <summary>
        /// Gets or sets expiration time stamp
        /// </summary>
        [JsonProperty(PropertyName = "expirationTimeStampInUTC")]
        public System.DateTime? ExpirationTimeStampInUTC { get; set; }

    }
}
