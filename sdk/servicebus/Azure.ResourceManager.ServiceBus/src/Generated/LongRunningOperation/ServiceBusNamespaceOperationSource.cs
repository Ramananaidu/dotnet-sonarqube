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

namespace Azure.ResourceManager.ServiceBus
{
    internal class ServiceBusNamespaceOperationSource : IOperationSource<ServiceBusNamespace>
    {
        private readonly ArmClient _client;

        internal ServiceBusNamespaceOperationSource(ArmClient client)
        {
            _client = client;
        }

        ServiceBusNamespace IOperationSource<ServiceBusNamespace>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ServiceBusNamespaceData.DeserializeServiceBusNamespaceData(document.RootElement);
            return new ServiceBusNamespace(_client, data);
        }

        async ValueTask<ServiceBusNamespace> IOperationSource<ServiceBusNamespace>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ServiceBusNamespaceData.DeserializeServiceBusNamespaceData(document.RootElement);
            return new ServiceBusNamespace(_client, data);
        }
    }
}
