// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for EntityQueriesOperations.
    /// </summary>
    public static partial class EntityQueriesOperationsExtensions
    {
            /// <summary>
            /// Gets all entity queries.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='kind'>
            /// The entity query kind we want to fetch. Possible values include:
            /// 'Expansion', 'Activity'
            /// </param>
            public static IPage<EntityQuery> List(this IEntityQueriesOperations operations, string resourceGroupName, string workspaceName, string kind = default(string))
            {
                return operations.ListAsync(resourceGroupName, workspaceName, kind).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all entity queries.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='kind'>
            /// The entity query kind we want to fetch. Possible values include:
            /// 'Expansion', 'Activity'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<EntityQuery>> ListAsync(this IEntityQueriesOperations operations, string resourceGroupName, string workspaceName, string kind = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, workspaceName, kind, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an entity query.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='entityQueryId'>
            /// entity query ID
            /// </param>
            public static EntityQuery Get(this IEntityQueriesOperations operations, string resourceGroupName, string workspaceName, string entityQueryId)
            {
                return operations.GetAsync(resourceGroupName, workspaceName, entityQueryId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an entity query.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='entityQueryId'>
            /// entity query ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EntityQuery> GetAsync(this IEntityQueriesOperations operations, string resourceGroupName, string workspaceName, string entityQueryId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, entityQueryId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates the entity query.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='entityQueryId'>
            /// entity query ID
            /// </param>
            /// <param name='entityQuery'>
            /// The entity query we want to create or update
            /// </param>
            public static EntityQuery CreateOrUpdate(this IEntityQueriesOperations operations, string resourceGroupName, string workspaceName, string entityQueryId, CustomEntityQuery entityQuery)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, workspaceName, entityQueryId, entityQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the entity query.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='entityQueryId'>
            /// entity query ID
            /// </param>
            /// <param name='entityQuery'>
            /// The entity query we want to create or update
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EntityQuery> CreateOrUpdateAsync(this IEntityQueriesOperations operations, string resourceGroupName, string workspaceName, string entityQueryId, CustomEntityQuery entityQuery, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, entityQueryId, entityQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the entity query.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='entityQueryId'>
            /// entity query ID
            /// </param>
            public static void Delete(this IEntityQueriesOperations operations, string resourceGroupName, string workspaceName, string entityQueryId)
            {
                operations.DeleteAsync(resourceGroupName, workspaceName, entityQueryId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the entity query.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='entityQueryId'>
            /// entity query ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IEntityQueriesOperations operations, string resourceGroupName, string workspaceName, string entityQueryId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, workspaceName, entityQueryId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets all entity queries.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<EntityQuery> ListNext(this IEntityQueriesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all entity queries.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<EntityQuery>> ListNextAsync(this IEntityQueriesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
