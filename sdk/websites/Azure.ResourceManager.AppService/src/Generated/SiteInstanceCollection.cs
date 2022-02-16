// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of SiteInstance and their operations over its parent. </summary>
    public partial class SiteInstanceCollection : ArmCollection, IEnumerable<SiteInstance>, IAsyncEnumerable<SiteInstance>
    {
        private readonly ClientDiagnostics _siteInstanceWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteInstanceWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteInstanceCollection"/> class for mocking. </summary>
        protected SiteInstanceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteInstanceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteInstanceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteInstanceWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteInstance.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(SiteInstance.ResourceType, out string siteInstanceWebAppsApiVersion);
            _siteInstanceWebAppsRestClient = new WebAppsRestOperations(_siteInstanceWebAppsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteInstanceWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSite.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSite.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Gets all scale-out instances of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}
        /// Operation Id: WebApps_GetInstanceInfo
        /// </summary>
        /// <param name="instanceId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public async virtual Task<Response<SiteInstance>> GetAsync(string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _siteInstanceWebAppsClientDiagnostics.CreateScope("SiteInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteInstanceWebAppsRestClient.GetInstanceInfoAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _siteInstanceWebAppsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteInstance(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets all scale-out instances of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}
        /// Operation Id: WebApps_GetInstanceInfo
        /// </summary>
        /// <param name="instanceId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual Response<SiteInstance> Get(string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _siteInstanceWebAppsClientDiagnostics.CreateScope("SiteInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = _siteInstanceWebAppsRestClient.GetInstanceInfo(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, cancellationToken);
                if (response.Value == null)
                    throw _siteInstanceWebAppsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteInstance(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets all scale-out instances of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances
        /// Operation Id: WebApps_ListInstanceIdentifiers
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteInstance" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteInstance> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteInstance>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteInstanceWebAppsClientDiagnostics.CreateScope("SiteInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteInstanceWebAppsRestClient.ListInstanceIdentifiersAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteInstance(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteInstance>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteInstanceWebAppsClientDiagnostics.CreateScope("SiteInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteInstanceWebAppsRestClient.ListInstanceIdentifiersNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteInstance(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Description for Gets all scale-out instances of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances
        /// Operation Id: WebApps_ListInstanceIdentifiers
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteInstance" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteInstance> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteInstance> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteInstanceWebAppsClientDiagnostics.CreateScope("SiteInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteInstanceWebAppsRestClient.ListInstanceIdentifiers(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteInstance(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteInstance> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteInstanceWebAppsClientDiagnostics.CreateScope("SiteInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteInstanceWebAppsRestClient.ListInstanceIdentifiersNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteInstance(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}
        /// Operation Id: WebApps_GetInstanceInfo
        /// </summary>
        /// <param name="instanceId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _siteInstanceWebAppsClientDiagnostics.CreateScope("SiteInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(instanceId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}
        /// Operation Id: WebApps_GetInstanceInfo
        /// </summary>
        /// <param name="instanceId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual Response<bool> Exists(string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _siteInstanceWebAppsClientDiagnostics.CreateScope("SiteInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(instanceId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}
        /// Operation Id: WebApps_GetInstanceInfo
        /// </summary>
        /// <param name="instanceId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public async virtual Task<Response<SiteInstance>> GetIfExistsAsync(string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _siteInstanceWebAppsClientDiagnostics.CreateScope("SiteInstanceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteInstanceWebAppsRestClient.GetInstanceInfoAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteInstance>(null, response.GetRawResponse());
                return Response.FromValue(new SiteInstance(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}
        /// Operation Id: WebApps_GetInstanceInfo
        /// </summary>
        /// <param name="instanceId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual Response<SiteInstance> GetIfExists(string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _siteInstanceWebAppsClientDiagnostics.CreateScope("SiteInstanceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteInstanceWebAppsRestClient.GetInstanceInfo(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteInstance>(null, response.GetRawResponse());
                return Response.FromValue(new SiteInstance(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteInstance> IEnumerable<SiteInstance>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteInstance> IAsyncEnumerable<SiteInstance>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
