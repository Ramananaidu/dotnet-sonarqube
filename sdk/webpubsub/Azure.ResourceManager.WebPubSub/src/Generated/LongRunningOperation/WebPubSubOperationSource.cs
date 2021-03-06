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

namespace Azure.ResourceManager.WebPubSub
{
    internal class WebPubSubOperationSource : IOperationSource<WebPubSub>
    {
        private readonly ArmClient _client;

        internal WebPubSubOperationSource(ArmClient client)
        {
            _client = client;
        }

        WebPubSub IOperationSource<WebPubSub>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = WebPubSubData.DeserializeWebPubSubData(document.RootElement);
            return new WebPubSub(_client, data);
        }

        async ValueTask<WebPubSub> IOperationSource<WebPubSub>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = WebPubSubData.DeserializeWebPubSubData(document.RootElement);
            return new WebPubSub(_client, data);
        }
    }
}
