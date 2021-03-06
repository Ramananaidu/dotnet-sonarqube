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
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Get Insights result metadata.
    /// </summary>
    public partial class GetInsightsResultsMetadata
    {
        /// <summary>
        /// Initializes a new instance of the GetInsightsResultsMetadata class.
        /// </summary>
        public GetInsightsResultsMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetInsightsResultsMetadata class.
        /// </summary>
        /// <param name="totalCount">the total items found for the insights
        /// request</param>
        /// <param name="errors">information about the failed queries</param>
        public GetInsightsResultsMetadata(int totalCount, IList<GetInsightsError> errors = default(IList<GetInsightsError>))
        {
            TotalCount = totalCount;
            Errors = errors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the total items found for the insights request
        /// </summary>
        [JsonProperty(PropertyName = "totalCount")]
        public int TotalCount { get; set; }

        /// <summary>
        /// Gets or sets information about the failed queries
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<GetInsightsError> Errors { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Errors != null)
            {
                foreach (var element in Errors)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
