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

namespace Azure.ResourceManager.Network
{
    internal class IPAllocationOperationSource : IOperationSource<IPAllocation>
    {
        private readonly ArmClient _client;

        internal IPAllocationOperationSource(ArmClient client)
        {
            _client = client;
        }

        IPAllocation IOperationSource<IPAllocation>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = IPAllocationData.DeserializeIPAllocationData(document.RootElement);
            return new IPAllocation(_client, data);
        }

        async ValueTask<IPAllocation> IOperationSource<IPAllocation>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = IPAllocationData.DeserializeIPAllocationData(document.RootElement);
            return new IPAllocation(_client, data);
        }
    }
}
