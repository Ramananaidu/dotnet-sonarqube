// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    /// Open API 2.0 Specs for Azure Data Protection service
    /// </summary>
    public partial class DataProtectionClient : ServiceClient<DataProtectionClient>, IDataProtectionClient, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// The subscription Id.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Client Api Version.
        /// </summary>
        public string ApiVersion { get; private set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default value is
        /// 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When set to
        /// true a unique x-ms-client-request-id value is generated and included in
        /// each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IBackupVaultsOperations.
        /// </summary>
        public virtual IBackupVaultsOperations BackupVaults { get; private set; }

        /// <summary>
        /// Gets the IOperationResultOperations.
        /// </summary>
        public virtual IOperationResultOperations OperationResult { get; private set; }

        /// <summary>
        /// Gets the IOperationStatusOperations.
        /// </summary>
        public virtual IOperationStatusOperations OperationStatus { get; private set; }

        /// <summary>
        /// Gets the IBackupVaultOperationResultsOperations.
        /// </summary>
        public virtual IBackupVaultOperationResultsOperations BackupVaultOperationResults { get; private set; }

        /// <summary>
        /// Gets the IDataProtectionOperations.
        /// </summary>
        public virtual IDataProtectionOperations DataProtection { get; private set; }

        /// <summary>
        /// Gets the IDataProtectionOperationsOperations.
        /// </summary>
        public virtual IDataProtectionOperationsOperations DataProtectionOperations { get; private set; }

        /// <summary>
        /// Gets the IBackupPoliciesOperations.
        /// </summary>
        public virtual IBackupPoliciesOperations BackupPolicies { get; private set; }

        /// <summary>
        /// Gets the IBackupInstancesOperations.
        /// </summary>
        public virtual IBackupInstancesOperations BackupInstances { get; private set; }

        /// <summary>
        /// Gets the IRecoveryPointsOperations.
        /// </summary>
        public virtual IRecoveryPointsOperations RecoveryPoints { get; private set; }

        /// <summary>
        /// Gets the IJobsOperations.
        /// </summary>
        public virtual IJobsOperations Jobs { get; private set; }

        /// <summary>
        /// Gets the IRestorableTimeRangesOperations.
        /// </summary>
        public virtual IRestorableTimeRangesOperations RestorableTimeRanges { get; private set; }

        /// <summary>
        /// Gets the IExportJobsOperations.
        /// </summary>
        public virtual IExportJobsOperations ExportJobs { get; private set; }

        /// <summary>
        /// Gets the IExportJobsOperationResultOperations.
        /// </summary>
        public virtual IExportJobsOperationResultOperations ExportJobsOperationResult { get; private set; }

        /// <summary>
        /// Gets the IResourceGuardsOperations.
        /// </summary>
        public virtual IResourceGuardsOperations ResourceGuards { get; private set; }

        /// <summary>
        /// Initializes a new instance of the DataProtectionClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling DataProtectionClient.Dispose(). False: will not dispose provided httpClient</param>
        protected DataProtectionClient(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the DataProtectionClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected DataProtectionClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the DataProtectionClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected DataProtectionClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the DataProtectionClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected DataProtectionClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the DataProtectionClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected DataProtectionClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the DataProtectionClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DataProtectionClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the DataProtectionClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling DataProtectionClient.Dispose(). False: will not dispose provided httpClient</param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DataProtectionClient(ServiceClientCredentials credentials, HttpClient httpClient, bool disposeHttpClient) : this(httpClient, disposeHttpClient)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the DataProtectionClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DataProtectionClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the DataProtectionClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DataProtectionClient(System.Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the DataProtectionClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DataProtectionClient(System.Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        /// </summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            BackupVaults = new BackupVaultsOperations(this);
            OperationResult = new OperationResultOperations(this);
            OperationStatus = new OperationStatusOperations(this);
            BackupVaultOperationResults = new BackupVaultOperationResultsOperations(this);
            DataProtection = new DataProtectionOperations(this);
            DataProtectionOperations = new DataProtectionOperationsOperations(this);
            BackupPolicies = new BackupPoliciesOperations(this);
            BackupInstances = new BackupInstancesOperations(this);
            RecoveryPoints = new RecoveryPointsOperations(this);
            Jobs = new JobsOperations(this);
            RestorableTimeRanges = new RestorableTimeRangesOperations(this);
            ExportJobs = new ExportJobsOperations(this);
            ExportJobsOperationResult = new ExportJobsOperationResultOperations(this);
            ResourceGuards = new ResourceGuardsOperations(this);
            BaseUri = new System.Uri("https://management.azure.com");
            ApiVersion = "2021-07-01";
            AcceptLanguage = "en-US";
            LongRunningOperationRetryTimeout = 30;
            GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<AuthCredentials>("objectType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<AuthCredentials>("objectType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<AzureBackupRecoveryPoint>("objectType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<AzureBackupRecoveryPoint>("objectType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<RestoreTargetInfoBase>("objectType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<RestoreTargetInfoBase>("objectType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<AzureBackupRestoreRequest>("objectType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<AzureBackupRestoreRequest>("objectType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<BackupParameters>("objectType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<BackupParameters>("objectType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<TriggerContext>("objectType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<TriggerContext>("objectType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<DeleteOption>("objectType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<DeleteOption>("objectType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<CopyOption>("objectType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<CopyOption>("objectType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<BackupCriteria>("objectType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<BackupCriteria>("objectType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<DataStoreParameters>("objectType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<DataStoreParameters>("objectType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<BasePolicyRule>("objectType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<BasePolicyRule>("objectType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<BaseBackupPolicy>("objectType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<BaseBackupPolicy>("objectType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<FeatureValidationRequestBase>("objectType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<FeatureValidationRequestBase>("objectType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<FeatureValidationResponseBase>("objectType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<FeatureValidationResponseBase>("objectType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<ItemLevelRestoreCriteria>("objectType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<ItemLevelRestoreCriteria>("objectType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<OperationExtendedInfo>("objectType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<OperationExtendedInfo>("objectType"));
            CustomInitialize();
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter());
        }
    }
}
