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
    internal class SiteSlotInstanceExtensionOperationSource : IOperationSource<SiteSlotInstanceExtension>
    {
        private readonly ArmClient _client;

        internal SiteSlotInstanceExtensionOperationSource(ArmClient client)
        {
            _client = client;
        }

        SiteSlotInstanceExtension IOperationSource<SiteSlotInstanceExtension>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MSDeployStatusData.DeserializeMSDeployStatusData(document.RootElement);
            return new SiteSlotInstanceExtension(_client, data);
        }

        async ValueTask<SiteSlotInstanceExtension> IOperationSource<SiteSlotInstanceExtension>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MSDeployStatusData.DeserializeMSDeployStatusData(document.RootElement);
            return new SiteSlotInstanceExtension(_client, data);
        }
    }
}
