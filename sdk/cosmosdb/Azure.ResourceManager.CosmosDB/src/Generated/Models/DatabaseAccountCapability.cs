// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB capability object. </summary>
    public partial class DatabaseAccountCapability
    {
        /// <summary> Initializes a new instance of DatabaseAccountCapability. </summary>
        public DatabaseAccountCapability()
        {
        }

        /// <summary> Initializes a new instance of DatabaseAccountCapability. </summary>
        /// <param name="name"> Name of the Cosmos DB capability. For example, &quot;name&quot;: &quot;EnableCassandra&quot;. Current values also include &quot;EnableTable&quot; and &quot;EnableGremlin&quot;. </param>
        internal DatabaseAccountCapability(string name)
        {
            Name = name;
        }

        /// <summary> Name of the Cosmos DB capability. For example, &quot;name&quot;: &quot;EnableCassandra&quot;. Current values also include &quot;EnableTable&quot; and &quot;EnableGremlin&quot;. </summary>
        public string Name { get; set; }
    }
}
