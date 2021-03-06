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
    internal class MigrationConfigPropertiesOperationSource : IOperationSource<MigrationConfigProperties>
    {
        private readonly ArmClient _client;

        internal MigrationConfigPropertiesOperationSource(ArmClient client)
        {
            _client = client;
        }

        MigrationConfigProperties IOperationSource<MigrationConfigProperties>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MigrationConfigPropertiesData.DeserializeMigrationConfigPropertiesData(document.RootElement);
            return new MigrationConfigProperties(_client, data);
        }

        async ValueTask<MigrationConfigProperties> IOperationSource<MigrationConfigProperties>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MigrationConfigPropertiesData.DeserializeMigrationConfigPropertiesData(document.RootElement);
            return new MigrationConfigProperties(_client, data);
        }
    }
}
