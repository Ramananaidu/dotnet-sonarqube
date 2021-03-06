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
    /// The Data Box Edge/Gateway device extended info patch.
    /// </summary>
    public partial class DataBoxEdgeDeviceExtendedInfoPatch
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DataBoxEdgeDeviceExtendedInfoPatch class.
        /// </summary>
        public DataBoxEdgeDeviceExtendedInfoPatch()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DataBoxEdgeDeviceExtendedInfoPatch class.
        /// </summary>
        /// <param name="clientSecretStoreId">The Key Vault ARM Id for client
        /// secrets</param>
        /// <param name="clientSecretStoreUrl">The url to access the Client Key
        /// Vault</param>
        /// <param name="channelIntegrityKeyName">The name for Channel
        /// Integrity Key stored in the Client Key Vault</param>
        /// <param name="channelIntegrityKeyVersion">The version of Channel
        /// Integrity Key stored in the Client Key Vault</param>
        /// <param name="syncStatus">For changing or to initiate the resync to
        /// key-vault set the status to KeyVaultSyncPending, rest of the status
        /// will not be applicable. Possible values include: 'KeyVaultSynced',
        /// 'KeyVaultSyncFailed', 'KeyVaultNotConfigured',
        /// 'KeyVaultSyncPending', 'KeyVaultSyncing',
        /// 'KeyVaultNotSynced'</param>
        public DataBoxEdgeDeviceExtendedInfoPatch(string clientSecretStoreId = default(string), string clientSecretStoreUrl = default(string), string channelIntegrityKeyName = default(string), string channelIntegrityKeyVersion = default(string), string syncStatus = default(string))
        {
            ClientSecretStoreId = clientSecretStoreId;
            ClientSecretStoreUrl = clientSecretStoreUrl;
            ChannelIntegrityKeyName = channelIntegrityKeyName;
            ChannelIntegrityKeyVersion = channelIntegrityKeyVersion;
            SyncStatus = syncStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Key Vault ARM Id for client secrets
        /// </summary>
        [JsonProperty(PropertyName = "clientSecretStoreId")]
        public string ClientSecretStoreId { get; set; }

        /// <summary>
        /// Gets or sets the url to access the Client Key Vault
        /// </summary>
        [JsonProperty(PropertyName = "clientSecretStoreUrl")]
        public string ClientSecretStoreUrl { get; set; }

        /// <summary>
        /// Gets or sets the name for Channel Integrity Key stored in the
        /// Client Key Vault
        /// </summary>
        [JsonProperty(PropertyName = "channelIntegrityKeyName")]
        public string ChannelIntegrityKeyName { get; set; }

        /// <summary>
        /// Gets or sets the version of Channel Integrity Key stored in the
        /// Client Key Vault
        /// </summary>
        [JsonProperty(PropertyName = "channelIntegrityKeyVersion")]
        public string ChannelIntegrityKeyVersion { get; set; }

        /// <summary>
        /// Gets or sets for changing or to initiate the resync to key-vault
        /// set the status to KeyVaultSyncPending, rest of the status will not
        /// be applicable. Possible values include: 'KeyVaultSynced',
        /// 'KeyVaultSyncFailed', 'KeyVaultNotConfigured',
        /// 'KeyVaultSyncPending', 'KeyVaultSyncing', 'KeyVaultNotSynced'
        /// </summary>
        [JsonProperty(PropertyName = "syncStatus")]
        public string SyncStatus { get; set; }

    }
}
