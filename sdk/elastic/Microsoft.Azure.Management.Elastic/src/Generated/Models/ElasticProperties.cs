// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Elastic.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Elastic Resource Properties.
    /// </summary>
    public partial class ElasticProperties
    {
        /// <summary>
        /// Initializes a new instance of the ElasticProperties class.
        /// </summary>
        public ElasticProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ElasticProperties class.
        /// </summary>
        /// <param name="elasticCloudUser">Details of the user's elastic
        /// account.</param>
        /// <param name="elasticCloudDeployment">Details of the elastic cloud
        /// deployment.</param>
        public ElasticProperties(ElasticCloudUser elasticCloudUser = default(ElasticCloudUser), ElasticCloudDeployment elasticCloudDeployment = default(ElasticCloudDeployment))
        {
            ElasticCloudUser = elasticCloudUser;
            ElasticCloudDeployment = elasticCloudDeployment;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets details of the user's elastic account.
        /// </summary>
        [JsonProperty(PropertyName = "elasticCloudUser")]
        public ElasticCloudUser ElasticCloudUser { get; set; }

        /// <summary>
        /// Gets or sets details of the elastic cloud deployment.
        /// </summary>
        [JsonProperty(PropertyName = "elasticCloudDeployment")]
        public ElasticCloudDeployment ElasticCloudDeployment { get; set; }

    }
}
