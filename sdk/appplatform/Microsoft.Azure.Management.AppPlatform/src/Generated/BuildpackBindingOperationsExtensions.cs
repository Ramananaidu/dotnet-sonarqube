// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BuildpackBindingOperations.
    /// </summary>
    public static partial class BuildpackBindingOperationsExtensions
    {
            /// <summary>
            /// Get a buildpack binding by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='buildServiceName'>
            /// The name of the build service resource.
            /// </param>
            /// <param name='builderName'>
            /// The name of the builder resource.
            /// </param>
            /// <param name='buildpackBindingName'>
            /// The name of the Buildpack Binding Name
            /// </param>
            public static BuildpackBindingResource Get(this IBuildpackBindingOperations operations, string resourceGroupName, string serviceName, string buildServiceName, string builderName, string buildpackBindingName)
            {
                return operations.GetAsync(resourceGroupName, serviceName, buildServiceName, builderName, buildpackBindingName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a buildpack binding by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='buildServiceName'>
            /// The name of the build service resource.
            /// </param>
            /// <param name='builderName'>
            /// The name of the builder resource.
            /// </param>
            /// <param name='buildpackBindingName'>
            /// The name of the Buildpack Binding Name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BuildpackBindingResource> GetAsync(this IBuildpackBindingOperations operations, string resourceGroupName, string serviceName, string buildServiceName, string builderName, string buildpackBindingName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceName, buildServiceName, builderName, buildpackBindingName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a buildpack binding.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='buildServiceName'>
            /// The name of the build service resource.
            /// </param>
            /// <param name='builderName'>
            /// The name of the builder resource.
            /// </param>
            /// <param name='buildpackBindingName'>
            /// The name of the Buildpack Binding Name
            /// </param>
            /// <param name='buildpackBinding'>
            /// The target buildpack binding for the create or update operation
            /// </param>
            public static BuildpackBindingResource CreateOrUpdate(this IBuildpackBindingOperations operations, string resourceGroupName, string serviceName, string buildServiceName, string builderName, string buildpackBindingName, BuildpackBindingResource buildpackBinding)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serviceName, buildServiceName, builderName, buildpackBindingName, buildpackBinding).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a buildpack binding.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='buildServiceName'>
            /// The name of the build service resource.
            /// </param>
            /// <param name='builderName'>
            /// The name of the builder resource.
            /// </param>
            /// <param name='buildpackBindingName'>
            /// The name of the Buildpack Binding Name
            /// </param>
            /// <param name='buildpackBinding'>
            /// The target buildpack binding for the create or update operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BuildpackBindingResource> CreateOrUpdateAsync(this IBuildpackBindingOperations operations, string resourceGroupName, string serviceName, string buildServiceName, string builderName, string buildpackBindingName, BuildpackBindingResource buildpackBinding, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, buildServiceName, builderName, buildpackBindingName, buildpackBinding, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Operation to delete a Buildpack Binding
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='buildServiceName'>
            /// The name of the build service resource.
            /// </param>
            /// <param name='builderName'>
            /// The name of the builder resource.
            /// </param>
            /// <param name='buildpackBindingName'>
            /// The name of the Buildpack Binding Name
            /// </param>
            public static void Delete(this IBuildpackBindingOperations operations, string resourceGroupName, string serviceName, string buildServiceName, string builderName, string buildpackBindingName)
            {
                operations.DeleteAsync(resourceGroupName, serviceName, buildServiceName, builderName, buildpackBindingName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Operation to delete a Buildpack Binding
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='buildServiceName'>
            /// The name of the build service resource.
            /// </param>
            /// <param name='builderName'>
            /// The name of the builder resource.
            /// </param>
            /// <param name='buildpackBindingName'>
            /// The name of the Buildpack Binding Name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IBuildpackBindingOperations operations, string resourceGroupName, string serviceName, string buildServiceName, string builderName, string buildpackBindingName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceName, buildServiceName, builderName, buildpackBindingName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Handles requests to list all buildpack bindings in a builder.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='buildServiceName'>
            /// The name of the build service resource.
            /// </param>
            /// <param name='builderName'>
            /// The name of the builder resource.
            /// </param>
            public static IPage<BuildpackBindingResource> List(this IBuildpackBindingOperations operations, string resourceGroupName, string serviceName, string buildServiceName, string builderName)
            {
                return operations.ListAsync(resourceGroupName, serviceName, buildServiceName, builderName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Handles requests to list all buildpack bindings in a builder.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='buildServiceName'>
            /// The name of the build service resource.
            /// </param>
            /// <param name='builderName'>
            /// The name of the builder resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BuildpackBindingResource>> ListAsync(this IBuildpackBindingOperations operations, string resourceGroupName, string serviceName, string buildServiceName, string builderName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, serviceName, buildServiceName, builderName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a buildpack binding.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='buildServiceName'>
            /// The name of the build service resource.
            /// </param>
            /// <param name='builderName'>
            /// The name of the builder resource.
            /// </param>
            /// <param name='buildpackBindingName'>
            /// The name of the Buildpack Binding Name
            /// </param>
            /// <param name='buildpackBinding'>
            /// The target buildpack binding for the create or update operation
            /// </param>
            public static BuildpackBindingResource BeginCreateOrUpdate(this IBuildpackBindingOperations operations, string resourceGroupName, string serviceName, string buildServiceName, string builderName, string buildpackBindingName, BuildpackBindingResource buildpackBinding)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, serviceName, buildServiceName, builderName, buildpackBindingName, buildpackBinding).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a buildpack binding.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='buildServiceName'>
            /// The name of the build service resource.
            /// </param>
            /// <param name='builderName'>
            /// The name of the builder resource.
            /// </param>
            /// <param name='buildpackBindingName'>
            /// The name of the Buildpack Binding Name
            /// </param>
            /// <param name='buildpackBinding'>
            /// The target buildpack binding for the create or update operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BuildpackBindingResource> BeginCreateOrUpdateAsync(this IBuildpackBindingOperations operations, string resourceGroupName, string serviceName, string buildServiceName, string builderName, string buildpackBindingName, BuildpackBindingResource buildpackBinding, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, buildServiceName, builderName, buildpackBindingName, buildpackBinding, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Operation to delete a Buildpack Binding
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='buildServiceName'>
            /// The name of the build service resource.
            /// </param>
            /// <param name='builderName'>
            /// The name of the builder resource.
            /// </param>
            /// <param name='buildpackBindingName'>
            /// The name of the Buildpack Binding Name
            /// </param>
            public static void BeginDelete(this IBuildpackBindingOperations operations, string resourceGroupName, string serviceName, string buildServiceName, string builderName, string buildpackBindingName)
            {
                operations.BeginDeleteAsync(resourceGroupName, serviceName, buildServiceName, builderName, buildpackBindingName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Operation to delete a Buildpack Binding
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='buildServiceName'>
            /// The name of the build service resource.
            /// </param>
            /// <param name='builderName'>
            /// The name of the builder resource.
            /// </param>
            /// <param name='buildpackBindingName'>
            /// The name of the Buildpack Binding Name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IBuildpackBindingOperations operations, string resourceGroupName, string serviceName, string buildServiceName, string builderName, string buildpackBindingName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, serviceName, buildServiceName, builderName, buildpackBindingName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Handles requests to list all buildpack bindings in a builder.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BuildpackBindingResource> ListNext(this IBuildpackBindingOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Handles requests to list all buildpack bindings in a builder.
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
            public static async Task<IPage<BuildpackBindingResource>> ListNextAsync(this IBuildpackBindingOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
