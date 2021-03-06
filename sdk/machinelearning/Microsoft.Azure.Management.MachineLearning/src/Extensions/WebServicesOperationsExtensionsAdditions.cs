// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.MachineLearning.WebServices.Models;

namespace Microsoft.Azure.Management.MachineLearning.WebServices
{
    /// <summary>
    /// This class was added as a temporary fix for the AutoRest generated client code, which does not handle
    /// the request id for async operations properly. Basically, if an async operation fails during execution,
    /// the AutoRest library will resturn an exception with the request id of the latest GET call that was
    /// polling for the async operation status. This is not desired, as all logs for the execution of the 
    /// operation and stored under the request id of the initial PUT/PATCH/DELETE call that initiated the 
    /// operation.
    /// 
    /// Here, we capture that request id after the initial async call, and return it with the final operation
    /// result or any CloudException thrown during execution.
    /// </summary>
    public static partial class WebServicesOperationsExtensions
    {
        /// <summary>
        /// Create a new Azure ML web service or update an existing one.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='createOrUpdatePayload'>
        /// The payload to create or update the Azure ML web service.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='webServiceName'>
        /// The Azure ML web service name which you want to reach.
        /// </param>
        /// <remarks>
        /// In case of an error, the thrown CloudException contains the proper request id to monitor the reasons for the failure
        /// </remarks>
        public static WebService CreateOrUpdateWithRequestId(this IWebServicesOperations operations, WebService createOrUpdatePayload, string resourceGroupName, string webServiceName)
        {
            return Task.Factory.StartNew(s => ((IWebServicesOperations)s).CreateOrUpdateWithRequestIdAsync(createOrUpdatePayload, resourceGroupName, webServiceName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a new Azure ML web service or update an existing one.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='createOrUpdatePayload'>
        /// The payload to create or update the Azure ML web service.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='webServiceName'>
        /// The Azure ML web service name which you want to reach.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <remarks>
        /// In case of an error, the thrown CloudException contains the proper request id to monitor the reasons for the failure
        /// </remarks>
        public static async Task<WebService> CreateOrUpdateWithRequestIdAsync(this IWebServicesOperations operations, WebService createOrUpdatePayload, string resourceGroupName, string webServiceName, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.CreateOrUpdateWebServiceWithProperRequestIdAsync(createOrUpdatePayload, resourceGroupName, webServiceName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Patch an existing Azure ML web service resource.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='patchPayload'>
        /// The payload to patch the Azure ML web service with.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='webServiceName'>
        /// The Azure ML web service name which you want to reach.
        /// </param>
        public static WebService PatchWithRequestId(this IWebServicesOperations operations, WebService patchPayload, string resourceGroupName, string webServiceName)
        {
            return Task.Factory.StartNew(s => ((IWebServicesOperations)s).PatchWithRequestIdAsync(patchPayload, resourceGroupName, webServiceName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Patch an existing Azure ML web service resource.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='patchPayload'>
        /// The payload to patch the Azure ML web service with.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='webServiceName'>
        /// The Azure ML web service name which you want to reach.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<WebService> PatchWithRequestIdAsync(this IWebServicesOperations operations, WebService patchPayload, string resourceGroupName, string webServiceName, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.PatchWebServiceWithProperRequestIdAsync(patchPayload, resourceGroupName, webServiceName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Remove an existing Azure ML web service.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='webServiceName'>
        /// The Azure ML web service name which you want to reach.
        /// </param>
        public static void RemoveWithRequestId(this IWebServicesOperations operations, string resourceGroupName, string webServiceName)
        {
            Task.Factory.StartNew(s => ((IWebServicesOperations)s).RemoveWithRequestIdAsync(resourceGroupName, webServiceName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Remove an existing Azure ML web service.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='webServiceName'>
        /// The Azure ML web service name which you want to reach.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task RemoveWithRequestIdAsync(this IWebServicesOperations operations, string resourceGroupName, string webServiceName, CancellationToken cancellationToken = default(CancellationToken))
        {
            await operations.RemoveWebServiceWitProperRequestIdAsync(resourceGroupName, webServiceName, null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Create web service properties for a specific region.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='webServiceName'>
        /// The Azure ML web service name which you want to reach.
        /// </param>
        /// <param name='region'>
        /// The new region of Azure ML web service properties.
        /// </param>
        public static void CreateRegionalPropertiesWithRequestId(this IWebServicesOperations operations, string resourceGroupName, string webServiceName, string region)
        {
            Task.Factory.StartNew(s => ((IWebServicesOperations)s).CreateRegionalPropertiesWithRequestIdAsync(resourceGroupName, webServiceName, region), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create web service properties for a specific region.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='webServiceName'>
        /// The Azure ML web service name which you want to reach.
        /// </param>
        /// <param name='region'>
        /// The new region of Azure ML web service properties.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task CreateRegionalPropertiesWithRequestIdAsync(this IWebServicesOperations operations, string resourceGroupName, string webServiceName, string region, CancellationToken cancellationToken = default(CancellationToken))
        {
            await operations.CreateRegionalPropertiesWithProperRequestIdAsync(resourceGroupName, webServiceName, region, null, cancellationToken).ConfigureAwait(false);
        }
    }
}
