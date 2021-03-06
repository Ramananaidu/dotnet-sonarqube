// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Properties required to update a profile. </summary>
    internal partial class PatchableProfileData
    {
        /// <summary> Initializes a new instance of PatchableProfileData. </summary>
        public PatchableProfileData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Profile tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
