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

namespace Azure.ResourceManager.AppService
{
    internal class StaticSitePrivateEndpointConnectionOperationSource : IOperationSource<StaticSitePrivateEndpointConnection>
    {
        private readonly ArmClient _client;

        internal StaticSitePrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        StaticSitePrivateEndpointConnection IOperationSource<StaticSitePrivateEndpointConnection>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = RemotePrivateEndpointConnectionARMResourceData.DeserializeRemotePrivateEndpointConnectionARMResourceData(document.RootElement);
            return new StaticSitePrivateEndpointConnection(_client, data);
        }

        async ValueTask<StaticSitePrivateEndpointConnection> IOperationSource<StaticSitePrivateEndpointConnection>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = RemotePrivateEndpointConnectionARMResourceData.DeserializeRemotePrivateEndpointConnectionARMResourceData(document.RootElement);
            return new StaticSitePrivateEndpointConnection(_client, data);
        }
    }
}
