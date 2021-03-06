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

namespace Azure.ResourceManager.EventHubs
{
    internal class EventHubClusterOperationSource : IOperationSource<EventHubCluster>
    {
        private readonly ArmClient _client;

        internal EventHubClusterOperationSource(ArmClient client)
        {
            _client = client;
        }

        EventHubCluster IOperationSource<EventHubCluster>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = EventHubClusterData.DeserializeEventHubClusterData(document.RootElement);
            return new EventHubCluster(_client, data);
        }

        async ValueTask<EventHubCluster> IOperationSource<EventHubCluster>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = EventHubClusterData.DeserializeEventHubClusterData(document.RootElement);
            return new EventHubCluster(_client, data);
        }
    }
}
