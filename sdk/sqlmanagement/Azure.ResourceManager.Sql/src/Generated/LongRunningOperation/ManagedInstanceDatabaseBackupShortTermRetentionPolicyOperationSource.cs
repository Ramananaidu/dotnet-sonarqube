// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Sql
{
    internal class ManagedInstanceDatabaseBackupShortTermRetentionPolicyOperationSource : IOperationSource<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>
    {
        private readonly ArmClient _client;

        internal ManagedInstanceDatabaseBackupShortTermRetentionPolicyOperationSource(ArmClient client)
        {
            _client = client;
        }

        ManagedInstanceDatabaseBackupShortTermRetentionPolicy IOperationSource<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ManagedBackupShortTermRetentionPolicyData.DeserializeManagedBackupShortTermRetentionPolicyData(document.RootElement);
            return new ManagedInstanceDatabaseBackupShortTermRetentionPolicy(_client, data);
        }

        async ValueTask<ManagedInstanceDatabaseBackupShortTermRetentionPolicy> IOperationSource<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ManagedBackupShortTermRetentionPolicyData.DeserializeManagedBackupShortTermRetentionPolicyData(document.RootElement);
            return new ManagedInstanceDatabaseBackupShortTermRetentionPolicy(_client, data);
        }
    }
}
