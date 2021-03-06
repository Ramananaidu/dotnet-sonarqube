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

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    internal class GuestAgentOperationSource : IOperationSource<GuestAgent>
    {
        private readonly ArmClient _client;

        internal GuestAgentOperationSource(ArmClient client)
        {
            _client = client;
        }

        GuestAgent IOperationSource<GuestAgent>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = GuestAgentData.DeserializeGuestAgentData(document.RootElement);
            return new GuestAgent(_client, data);
        }

        async ValueTask<GuestAgent> IOperationSource<GuestAgent>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = GuestAgentData.DeserializeGuestAgentData(document.RootElement);
            return new GuestAgent(_client, data);
        }
    }
}
