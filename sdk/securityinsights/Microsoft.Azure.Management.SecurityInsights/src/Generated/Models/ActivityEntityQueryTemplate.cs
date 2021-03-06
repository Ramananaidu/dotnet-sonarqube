// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents Activity entity query.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Activity")]
    [Rest.Serialization.JsonTransformation]
    public partial class ActivityEntityQueryTemplate : EntityQueryTemplate
    {
        /// <summary>
        /// Initializes a new instance of the ActivityEntityQueryTemplate
        /// class.
        /// </summary>
        public ActivityEntityQueryTemplate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActivityEntityQueryTemplate
        /// class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="systemData">Azure Resource Manager metadata containing
        /// createdBy and modifiedBy information.</param>
        /// <param name="title">The entity query title</param>
        /// <param name="content">The entity query content to display in
        /// timeline</param>
        /// <param name="description">The entity query description</param>
        /// <param name="queryDefinitions">The Activity query
        /// definitions</param>
        /// <param name="dataTypes">List of required data types for the given
        /// entity query template</param>
        /// <param name="inputEntityType">The type of the query's source
        /// entity. Possible values include: 'Account', 'Host', 'File',
        /// 'AzureResource', 'CloudApplication', 'DNS', 'FileHash', 'IP',
        /// 'Malware', 'Process', 'RegistryKey', 'RegistryValue',
        /// 'SecurityGroup', 'URL', 'IoTDevice', 'SecurityAlert',
        /// 'HuntingBookmark', 'MailCluster', 'MailMessage', 'Mailbox',
        /// 'SubmissionMail'</param>
        /// <param name="requiredInputFieldsSets">List of the fields of the
        /// source entity that are required to run the query</param>
        /// <param name="entitiesFilter">The query applied only to entities
        /// matching to all filters</param>
        public ActivityEntityQueryTemplate(string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), string title = default(string), string content = default(string), string description = default(string), ActivityEntityQueryTemplatePropertiesQueryDefinitions queryDefinitions = default(ActivityEntityQueryTemplatePropertiesQueryDefinitions), IList<DataTypeDefinitions> dataTypes = default(IList<DataTypeDefinitions>), string inputEntityType = default(string), IList<IList<string>> requiredInputFieldsSets = default(IList<IList<string>>), IDictionary<string, IList<string>> entitiesFilter = default(IDictionary<string, IList<string>>))
            : base(id, name, type, systemData)
        {
            Title = title;
            Content = content;
            Description = description;
            QueryDefinitions = queryDefinitions;
            DataTypes = dataTypes;
            InputEntityType = inputEntityType;
            RequiredInputFieldsSets = requiredInputFieldsSets;
            EntitiesFilter = entitiesFilter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the entity query title
        /// </summary>
        [JsonProperty(PropertyName = "properties.title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the entity query content to display in timeline
        /// </summary>
        [JsonProperty(PropertyName = "properties.content")]
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the entity query description
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Activity query definitions
        /// </summary>
        [JsonProperty(PropertyName = "properties.queryDefinitions")]
        public ActivityEntityQueryTemplatePropertiesQueryDefinitions QueryDefinitions { get; set; }

        /// <summary>
        /// Gets or sets list of required data types for the given entity query
        /// template
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataTypes")]
        public IList<DataTypeDefinitions> DataTypes { get; set; }

        /// <summary>
        /// Gets or sets the type of the query's source entity. Possible values
        /// include: 'Account', 'Host', 'File', 'AzureResource',
        /// 'CloudApplication', 'DNS', 'FileHash', 'IP', 'Malware', 'Process',
        /// 'RegistryKey', 'RegistryValue', 'SecurityGroup', 'URL',
        /// 'IoTDevice', 'SecurityAlert', 'HuntingBookmark', 'MailCluster',
        /// 'MailMessage', 'Mailbox', 'SubmissionMail'
        /// </summary>
        [JsonProperty(PropertyName = "properties.inputEntityType")]
        public string InputEntityType { get; set; }

        /// <summary>
        /// Gets or sets list of the fields of the source entity that are
        /// required to run the query
        /// </summary>
        [JsonProperty(PropertyName = "properties.requiredInputFieldsSets")]
        public IList<IList<string>> RequiredInputFieldsSets { get; set; }

        /// <summary>
        /// Gets or sets the query applied only to entities matching to all
        /// filters
        /// </summary>
        [JsonProperty(PropertyName = "properties.entitiesFilter")]
        public IDictionary<string, IList<string>> EntitiesFilter { get; set; }

    }
}
