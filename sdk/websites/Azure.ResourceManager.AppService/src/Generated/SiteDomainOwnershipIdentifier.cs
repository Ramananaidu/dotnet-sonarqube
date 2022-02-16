// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a SiteDomainOwnershipIdentifier along with the instance operations that can be performed on it. </summary>
    public partial class SiteDomainOwnershipIdentifier : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteDomainOwnershipIdentifier"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string domainOwnershipIdentifierName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteDomainOwnershipIdentifierWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteDomainOwnershipIdentifierWebAppsRestClient;
        private readonly IdentifierData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteDomainOwnershipIdentifier"/> class for mocking. </summary>
        protected SiteDomainOwnershipIdentifier()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteDomainOwnershipIdentifier"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteDomainOwnershipIdentifier(ArmClient client, IdentifierData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteDomainOwnershipIdentifier"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteDomainOwnershipIdentifier(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteDomainOwnershipIdentifierWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string siteDomainOwnershipIdentifierWebAppsApiVersion);
            _siteDomainOwnershipIdentifierWebAppsRestClient = new WebAppsRestOperations(_siteDomainOwnershipIdentifierWebAppsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteDomainOwnershipIdentifierWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/domainOwnershipIdentifiers";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual IdentifierData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get domain ownership identifier for web app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// Operation Id: WebApps_GetDomainOwnershipIdentifier
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<SiteDomainOwnershipIdentifier>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteDomainOwnershipIdentifier.Get");
            scope.Start();
            try
            {
                var response = await _siteDomainOwnershipIdentifierWebAppsRestClient.GetDomainOwnershipIdentifierAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _siteDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteDomainOwnershipIdentifier(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get domain ownership identifier for web app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// Operation Id: WebApps_GetDomainOwnershipIdentifier
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteDomainOwnershipIdentifier> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteDomainOwnershipIdentifier.Get");
            scope.Start();
            try
            {
                var response = _siteDomainOwnershipIdentifierWebAppsRestClient.GetDomainOwnershipIdentifier(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _siteDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteDomainOwnershipIdentifier(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Deletes a domain ownership identifier for a web app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// Operation Id: WebApps_DeleteDomainOwnershipIdentifier
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _siteDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteDomainOwnershipIdentifier.Delete");
            scope.Start();
            try
            {
                var response = await _siteDomainOwnershipIdentifierWebAppsRestClient.DeleteDomainOwnershipIdentifierAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation(response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Deletes a domain ownership identifier for a web app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// Operation Id: WebApps_DeleteDomainOwnershipIdentifier
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _siteDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteDomainOwnershipIdentifier.Delete");
            scope.Start();
            try
            {
                var response = _siteDomainOwnershipIdentifierWebAppsRestClient.DeleteDomainOwnershipIdentifier(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppServiceArmOperation(response);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Creates a domain ownership identifier for web app, or updates an existing ownership identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// Operation Id: WebApps_UpdateDomainOwnershipIdentifier
        /// </summary>
        /// <param name="domainOwnershipIdentifier"> A JSON representation of the domain ownership properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifier"/> is null. </exception>
        public async virtual Task<Response<SiteDomainOwnershipIdentifier>> UpdateAsync(IdentifierData domainOwnershipIdentifier, CancellationToken cancellationToken = default)
        {
            if (domainOwnershipIdentifier == null)
            {
                throw new ArgumentNullException(nameof(domainOwnershipIdentifier));
            }

            using var scope = _siteDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteDomainOwnershipIdentifier.Update");
            scope.Start();
            try
            {
                var response = await _siteDomainOwnershipIdentifierWebAppsRestClient.UpdateDomainOwnershipIdentifierAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainOwnershipIdentifier, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SiteDomainOwnershipIdentifier(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Creates a domain ownership identifier for web app, or updates an existing ownership identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// Operation Id: WebApps_UpdateDomainOwnershipIdentifier
        /// </summary>
        /// <param name="domainOwnershipIdentifier"> A JSON representation of the domain ownership properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifier"/> is null. </exception>
        public virtual Response<SiteDomainOwnershipIdentifier> Update(IdentifierData domainOwnershipIdentifier, CancellationToken cancellationToken = default)
        {
            if (domainOwnershipIdentifier == null)
            {
                throw new ArgumentNullException(nameof(domainOwnershipIdentifier));
            }

            using var scope = _siteDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteDomainOwnershipIdentifier.Update");
            scope.Start();
            try
            {
                var response = _siteDomainOwnershipIdentifierWebAppsRestClient.UpdateDomainOwnershipIdentifier(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainOwnershipIdentifier, cancellationToken);
                return Response.FromValue(new SiteDomainOwnershipIdentifier(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
