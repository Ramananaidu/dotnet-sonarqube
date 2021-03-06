// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a Service Bus Topic output data source.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.ServiceBus/Topic")]
    [Rest.Serialization.JsonTransformation]
    public partial class ServiceBusTopicOutputDataSource : OutputDataSource
    {
        /// <summary>
        /// Initializes a new instance of the ServiceBusTopicOutputDataSource
        /// class.
        /// </summary>
        public ServiceBusTopicOutputDataSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceBusTopicOutputDataSource
        /// class.
        /// </summary>
        /// <param name="serviceBusNamespace">The namespace that is associated
        /// with the desired Event Hub, Service Bus Queue, Service Bus Topic,
        /// etc. Required on PUT (CreateOrReplace) requests.</param>
        /// <param name="sharedAccessPolicyName">The shared access policy name
        /// for the Event Hub, Service Bus Queue, Service Bus Topic, etc.
        /// Required on PUT (CreateOrReplace) requests.</param>
        /// <param name="sharedAccessPolicyKey">The shared access policy key
        /// for the specified shared access policy. Required on PUT
        /// (CreateOrReplace) requests.</param>
        /// <param name="authenticationMode">Authentication Mode. Possible
        /// values include: 'Msi', 'UserToken', 'ConnectionString'</param>
        /// <param name="topicName">The name of the Service Bus Topic. Required
        /// on PUT (CreateOrReplace) requests.</param>
        /// <param name="propertyColumns">A string array of the names of output
        /// columns to be attached to Service Bus messages as custom
        /// properties.</param>
        /// <param name="systemPropertyColumns">The system properties
        /// associated with the Service Bus Topic Output. The following system
        /// properties are supported: ReplyToSessionId, ContentType, To,
        /// Subject, CorrelationId, TimeToLive, PartitionKey, SessionId,
        /// ScheduledEnqueueTime, MessageId, ReplyTo, Label,
        /// ScheduledEnqueueTimeUtc.</param>
        public ServiceBusTopicOutputDataSource(string serviceBusNamespace = default(string), string sharedAccessPolicyName = default(string), string sharedAccessPolicyKey = default(string), string authenticationMode = default(string), string topicName = default(string), IList<string> propertyColumns = default(IList<string>), IDictionary<string, string> systemPropertyColumns = default(IDictionary<string, string>))
        {
            ServiceBusNamespace = serviceBusNamespace;
            SharedAccessPolicyName = sharedAccessPolicyName;
            SharedAccessPolicyKey = sharedAccessPolicyKey;
            AuthenticationMode = authenticationMode;
            TopicName = topicName;
            PropertyColumns = propertyColumns;
            SystemPropertyColumns = systemPropertyColumns;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the namespace that is associated with the desired
        /// Event Hub, Service Bus Queue, Service Bus Topic, etc. Required on
        /// PUT (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceBusNamespace")]
        public string ServiceBusNamespace { get; set; }

        /// <summary>
        /// Gets or sets the shared access policy name for the Event Hub,
        /// Service Bus Queue, Service Bus Topic, etc. Required on PUT
        /// (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sharedAccessPolicyName")]
        public string SharedAccessPolicyName { get; set; }

        /// <summary>
        /// Gets or sets the shared access policy key for the specified shared
        /// access policy. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sharedAccessPolicyKey")]
        public string SharedAccessPolicyKey { get; set; }

        /// <summary>
        /// Gets or sets authentication Mode. Possible values include: 'Msi',
        /// 'UserToken', 'ConnectionString'
        /// </summary>
        [JsonProperty(PropertyName = "properties.authenticationMode")]
        public string AuthenticationMode { get; set; }

        /// <summary>
        /// Gets or sets the name of the Service Bus Topic. Required on PUT
        /// (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.topicName")]
        public string TopicName { get; set; }

        /// <summary>
        /// Gets or sets a string array of the names of output columns to be
        /// attached to Service Bus messages as custom properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties.propertyColumns")]
        public IList<string> PropertyColumns { get; set; }

        /// <summary>
        /// Gets or sets the system properties associated with the Service Bus
        /// Topic Output. The following system properties are supported:
        /// ReplyToSessionId, ContentType, To, Subject, CorrelationId,
        /// TimeToLive, PartitionKey, SessionId, ScheduledEnqueueTime,
        /// MessageId, ReplyTo, Label, ScheduledEnqueueTimeUtc.
        /// </summary>
        [JsonProperty(PropertyName = "properties.systemPropertyColumns")]
        public IDictionary<string, string> SystemPropertyColumns { get; set; }

    }
}
