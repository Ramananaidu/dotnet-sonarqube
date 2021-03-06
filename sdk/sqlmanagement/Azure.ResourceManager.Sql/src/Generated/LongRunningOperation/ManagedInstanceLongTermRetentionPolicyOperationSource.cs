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
    internal class ManagedInstanceLongTermRetentionPolicyOperationSource : IOperationSource<ManagedInstanceLongTermRetentionPolicy>
    {
        private readonly ArmClient _client;

        internal ManagedInstanceLongTermRetentionPolicyOperationSource(ArmClient client)
        {
            _client = client;
        }

        ManagedInstanceLongTermRetentionPolicy IOperationSource<ManagedInstanceLongTermRetentionPolicy>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ManagedInstanceLongTermRetentionPolicyData.DeserializeManagedInstanceLongTermRetentionPolicyData(document.RootElement);
            return new ManagedInstanceLongTermRetentionPolicy(_client, data);
        }

        async ValueTask<ManagedInstanceLongTermRetentionPolicy> IOperationSource<ManagedInstanceLongTermRetentionPolicy>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ManagedInstanceLongTermRetentionPolicyData.DeserializeManagedInstanceLongTermRetentionPolicyData(document.RootElement);
            return new ManagedInstanceLongTermRetentionPolicy(_client, data);
        }
    }
}
