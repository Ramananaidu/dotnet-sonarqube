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
    internal class PacketCaptureOperationSource : IOperationSource<PacketCapture>
    {
        private readonly ArmClient _client;

        internal PacketCaptureOperationSource(ArmClient client)
        {
            _client = client;
        }

        PacketCapture IOperationSource<PacketCapture>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = PacketCaptureData.DeserializePacketCaptureData(document.RootElement);
            return new PacketCapture(_client, data);
        }

        async ValueTask<PacketCapture> IOperationSource<PacketCapture>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = PacketCaptureData.DeserializePacketCaptureData(document.RootElement);
            return new PacketCapture(_client, data);
        }
    }
}
