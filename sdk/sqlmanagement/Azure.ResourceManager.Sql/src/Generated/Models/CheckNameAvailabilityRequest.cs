// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A request to check whether the specified name for a resource is available. </summary>
    public partial class CheckNameAvailabilityRequest
    {
        /// <summary> Initializes a new instance of CheckNameAvailabilityRequest. </summary>
        /// <param name="name"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public CheckNameAvailabilityRequest(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            ResourceType = "Microsoft.Sql/servers";
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the resource type. </summary>
        public string ResourceType { get; }
    }
}
