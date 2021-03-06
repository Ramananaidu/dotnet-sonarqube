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
    internal class FlowLogOperationSource : IOperationSource<FlowLog>
    {
        private readonly ArmClient _client;

        internal FlowLogOperationSource(ArmClient client)
        {
            _client = client;
        }

        FlowLog IOperationSource<FlowLog>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = FlowLogData.DeserializeFlowLogData(document.RootElement);
            return new FlowLog(_client, data);
        }

        async ValueTask<FlowLog> IOperationSource<FlowLog>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = FlowLogData.DeserializeFlowLogData(document.RootElement);
            return new FlowLog(_client, data);
        }
    }
}
