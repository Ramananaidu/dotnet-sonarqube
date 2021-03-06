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
    /// Array of tags to be appended to the threat intelligence indicator.
    /// </summary>
    public partial class ThreatIntelligenceAppendTags
    {
        /// <summary>
        /// Initializes a new instance of the ThreatIntelligenceAppendTags
        /// class.
        /// </summary>
        public ThreatIntelligenceAppendTags()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ThreatIntelligenceAppendTags
        /// class.
        /// </summary>
        /// <param name="threatIntelligenceTags">List of tags to be
        /// appended.</param>
        public ThreatIntelligenceAppendTags(IList<string> threatIntelligenceTags = default(IList<string>))
        {
            ThreatIntelligenceTags = threatIntelligenceTags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of tags to be appended.
        /// </summary>
        [JsonProperty(PropertyName = "threatIntelligenceTags")]
        public IList<string> ThreatIntelligenceTags { get; set; }

    }
}
