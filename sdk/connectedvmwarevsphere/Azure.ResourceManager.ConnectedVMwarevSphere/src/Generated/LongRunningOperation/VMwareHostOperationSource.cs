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
    internal class VMwareHostOperationSource : IOperationSource<VMwareHost>
    {
        private readonly ArmClient _client;

        internal VMwareHostOperationSource(ArmClient client)
        {
            _client = client;
        }

        VMwareHost IOperationSource<VMwareHost>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VMwareHostData.DeserializeVMwareHostData(document.RootElement);
            return new VMwareHost(_client, data);
        }

        async ValueTask<VMwareHost> IOperationSource<VMwareHost>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VMwareHostData.DeserializeVMwareHostData(document.RootElement);
            return new VMwareHost(_client, data);
        }
    }
}
