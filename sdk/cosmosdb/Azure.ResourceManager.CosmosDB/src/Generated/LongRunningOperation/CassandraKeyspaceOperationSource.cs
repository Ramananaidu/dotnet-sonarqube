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

namespace Azure.ResourceManager.CosmosDB
{
    internal class CassandraKeyspaceOperationSource : IOperationSource<CassandraKeyspace>
    {
        private readonly ArmClient _client;

        internal CassandraKeyspaceOperationSource(ArmClient client)
        {
            _client = client;
        }

        CassandraKeyspace IOperationSource<CassandraKeyspace>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CassandraKeyspaceData.DeserializeCassandraKeyspaceData(document.RootElement);
            return new CassandraKeyspace(_client, data);
        }

        async ValueTask<CassandraKeyspace> IOperationSource<CassandraKeyspace>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CassandraKeyspaceData.DeserializeCassandraKeyspaceData(document.RootElement);
            return new CassandraKeyspace(_client, data);
        }
    }
}
