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
    internal class SiteSiteextensionOperationSource : IOperationSource<SiteSiteextension>
    {
        private readonly ArmClient _client;

        internal SiteSiteextensionOperationSource(ArmClient client)
        {
            _client = client;
        }

        SiteSiteextension IOperationSource<SiteSiteextension>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SiteExtensionInfoData.DeserializeSiteExtensionInfoData(document.RootElement);
            return new SiteSiteextension(_client, data);
        }

        async ValueTask<SiteSiteextension> IOperationSource<SiteSiteextension>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SiteExtensionInfoData.DeserializeSiteExtensionInfoData(document.RootElement);
            return new SiteSiteextension(_client, data);
        }
    }
}
