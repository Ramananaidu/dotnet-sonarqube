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

namespace Azure.ResourceManager.DeviceUpdate
{
    internal class DeviceUpdateAccountOperationSource : IOperationSource<DeviceUpdateAccount>
    {
        private readonly ArmClient _client;

        internal DeviceUpdateAccountOperationSource(ArmClient client)
        {
            _client = client;
        }

        DeviceUpdateAccount IOperationSource<DeviceUpdateAccount>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DeviceUpdateAccountData.DeserializeDeviceUpdateAccountData(document.RootElement);
            return new DeviceUpdateAccount(_client, data);
        }

        async ValueTask<DeviceUpdateAccount> IOperationSource<DeviceUpdateAccount>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DeviceUpdateAccountData.DeserializeDeviceUpdateAccountData(document.RootElement);
            return new DeviceUpdateAccount(_client, data);
        }
    }
}
