// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KeyVault
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// PrivateEndpointConnectionsOperations operations.
    /// </summary>
    public partial interface IPrivateEndpointConnectionsOperations
    {
        /// <summary>
        /// Gets the specified private endpoint connection associated with the
        /// key vault.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group that contains the key vault.
        /// </param>
        /// <param name='vaultName'>
        /// The name of the key vault.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// Name of the private endpoint connection associated with the key
        /// vault.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PrivateEndpointConnection>> GetWithHttpMessagesAsync(string resourceGroupName, string vaultName, string privateEndpointConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the specified private endpoint connection associated with
        /// the key vault.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group that contains the key vault.
        /// </param>
        /// <param name='vaultName'>
        /// The name of the key vault.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// Name of the private endpoint connection associated with the key
        /// vault.
        /// </param>
        /// <param name='properties'>
        /// The intended state of private endpoint connection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PrivateEndpointConnection,PrivateEndpointConnectionsPutHeaders>> PutWithHttpMessagesAsync(string resourceGroupName, string vaultName, string privateEndpointConnectionName, PrivateEndpointConnection properties, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified private endpoint connection associated with
        /// the key vault.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group that contains the key vault.
        /// </param>
        /// <param name='vaultName'>
        /// The name of the key vault.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// Name of the private endpoint connection associated with the key
        /// vault.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PrivateEndpointConnection,PrivateEndpointConnectionsDeleteHeaders>> DeleteWithHttpMessagesAsync(string resourceGroupName, string vaultName, string privateEndpointConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The List operation gets information about the private endpoint
        /// connections associated with the vault.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group that contains the key vault.
        /// </param>
        /// <param name='vaultName'>
        /// The name of the key vault.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<PrivateEndpointConnection>>> ListByResourceWithHttpMessagesAsync(string resourceGroupName, string vaultName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified private endpoint connection associated with
        /// the key vault.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group that contains the key vault.
        /// </param>
        /// <param name='vaultName'>
        /// The name of the key vault.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// Name of the private endpoint connection associated with the key
        /// vault.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PrivateEndpointConnection,PrivateEndpointConnectionsDeleteHeaders>> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string vaultName, string privateEndpointConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The List operation gets information about the private endpoint
        /// connections associated with the vault.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<PrivateEndpointConnection>>> ListByResourceNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
