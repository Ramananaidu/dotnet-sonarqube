// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class ElisionTokenFilter
    {
        /// <summary> The set of articles to remove. </summary>
        public IList<string> Articles { get; }
    }
}
