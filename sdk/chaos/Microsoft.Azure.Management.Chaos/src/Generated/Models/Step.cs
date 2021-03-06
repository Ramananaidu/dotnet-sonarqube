// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Chaos.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Model that represents a step in the Experiment resource.
    /// </summary>
    public partial class Step
    {
        /// <summary>
        /// Initializes a new instance of the Step class.
        /// </summary>
        public Step()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Step class.
        /// </summary>
        /// <param name="name">String of the step name.</param>
        /// <param name="branches">List of branches.</param>
        public Step(string name, IList<Branch> branches)
        {
            Name = name;
            Branches = branches;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets string of the step name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets list of branches.
        /// </summary>
        [JsonProperty(PropertyName = "branches")]
        public IList<Branch> Branches { get; set; }

    }
}
