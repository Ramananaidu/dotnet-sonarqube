// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventHub
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PrivateLinkResourcesOperations.
    /// </summary>
    public static partial class PrivateLinkResourcesOperationsExtensions
    {
            /// <summary>
            /// Gets lists of resources that supports Privatelinks.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639379.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            public static PrivateLinkResourcesListResult Get(this IPrivateLinkResourcesOperations operations, string resourceGroupName, string namespaceName)
            {
                return operations.GetAsync(resourceGroupName, namespaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets lists of resources that supports Privatelinks.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639379.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateLinkResourcesListResult> GetAsync(this IPrivateLinkResourcesOperations operations, string resourceGroupName, string namespaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, namespaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
