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

namespace Azure.ResourceManager.Sql
{
    internal class ServerSecurityAlertPolicyOperationSource : IOperationSource<ServerSecurityAlertPolicy>
    {
        private readonly ArmClient _client;

        internal ServerSecurityAlertPolicyOperationSource(ArmClient client)
        {
            _client = client;
        }

        ServerSecurityAlertPolicy IOperationSource<ServerSecurityAlertPolicy>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ServerSecurityAlertPolicyData.DeserializeServerSecurityAlertPolicyData(document.RootElement);
            return new ServerSecurityAlertPolicy(_client, data);
        }

        async ValueTask<ServerSecurityAlertPolicy> IOperationSource<ServerSecurityAlertPolicy>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ServerSecurityAlertPolicyData.DeserializeServerSecurityAlertPolicyData(document.RootElement);
            return new ServerSecurityAlertPolicy(_client, data);
        }
    }
}
