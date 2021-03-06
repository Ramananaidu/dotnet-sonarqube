// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The list Kusto pools operation response.
    /// </summary>
    public partial class KustoPoolListResult
    {
        /// <summary>
        /// Initializes a new instance of the KustoPoolListResult class.
        /// </summary>
        public KustoPoolListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KustoPoolListResult class.
        /// </summary>
        /// <param name="value">The list of Kusto pools.</param>
        public KustoPoolListResult(IList<KustoPool> value = default(IList<KustoPool>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of Kusto pools.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<KustoPool> Value { get; set; }

    }
}
