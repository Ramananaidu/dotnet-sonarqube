// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// UserRulesOperations operations.
    /// </summary>
    public partial interface IUserRulesOperations
    {
        /// <summary>
        /// Lists all user rules in a rule collection.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkManagerName'>
        /// The name of the network manager.
        /// </param>
        /// <param name='configurationName'>
        /// The name of the network manager security Configuration.
        /// </param>
        /// <param name='ruleCollectionName'>
        /// The name of the network manager security Configuration rule
        /// collection.
        /// </param>
        /// <param name='top'>
        /// An optional query parameter which specifies the maximum number of
        /// records to be returned by the server.
        /// </param>
        /// <param name='skipToken'>
        /// SkipToken is only used if a previous operation returned a partial
        /// result. If a previous response contains a nextLink element, the
        /// value of the nextLink element will include a skipToken parameter
        /// that specifies a starting point to use for subsequent calls.
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
        Task<AzureOperationResponse<IPage<BaseUserRule>>> ListWithHttpMessagesAsync(string resourceGroupName, string networkManagerName, string configurationName, string ruleCollectionName, int? top = default(int?), string skipToken = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a user rule.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkManagerName'>
        /// The name of the network manager.
        /// </param>
        /// <param name='configurationName'>
        /// The name of the network manager security Configuration.
        /// </param>
        /// <param name='ruleCollectionName'>
        /// The name of the network manager security Configuration rule
        /// collection.
        /// </param>
        /// <param name='ruleName'>
        /// The name of the rule.
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
        Task<AzureOperationResponse<BaseUserRule>> GetWithHttpMessagesAsync(string resourceGroupName, string networkManagerName, string configurationName, string ruleCollectionName, string ruleName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a user rule.
        /// </summary>
        /// <param name='userRule'>
        /// The user rule to create or update
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkManagerName'>
        /// The name of the network manager.
        /// </param>
        /// <param name='configurationName'>
        /// The name of the network manager security Configuration.
        /// </param>
        /// <param name='ruleCollectionName'>
        /// The name of the network manager security Configuration rule
        /// collection.
        /// </param>
        /// <param name='ruleName'>
        /// The name of the rule.
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
        Task<AzureOperationResponse<BaseUserRule>> CreateOrUpdateWithHttpMessagesAsync(BaseUserRule userRule, string resourceGroupName, string networkManagerName, string configurationName, string ruleCollectionName, string ruleName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a user rule.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkManagerName'>
        /// The name of the network manager.
        /// </param>
        /// <param name='configurationName'>
        /// The name of the network manager security Configuration.
        /// </param>
        /// <param name='ruleCollectionName'>
        /// The name of the network manager security Configuration rule
        /// collection.
        /// </param>
        /// <param name='ruleName'>
        /// The name of the rule.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string networkManagerName, string configurationName, string ruleCollectionName, string ruleName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all user rules in a rule collection.
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
        Task<AzureOperationResponse<IPage<BaseUserRule>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
