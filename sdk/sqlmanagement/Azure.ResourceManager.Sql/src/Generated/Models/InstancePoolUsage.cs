// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> ARM usage. </summary>
    public partial class InstancePoolUsage
    {
        /// <summary> Initializes a new instance of InstancePoolUsage. </summary>
        internal InstancePoolUsage()
        {
        }

        /// <summary> Initializes a new instance of InstancePoolUsage. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="instancePoolUsageType"> Resource type. </param>
        /// <param name="unit"> Usage unit. </param>
        /// <param name="currentValue"> Usage current value. </param>
        /// <param name="limit"> Usage limit. </param>
        /// <param name="requestedLimit"> Usage requested limit. </param>
        internal InstancePoolUsage(string id, UsageName name, string instancePoolUsageType, string unit, int? currentValue, int? limit, int? requestedLimit)
        {
            Id = id;
            Name = name;
            InstancePoolUsageType = instancePoolUsageType;
            Unit = unit;
            CurrentValue = currentValue;
            Limit = limit;
            RequestedLimit = requestedLimit;
        }

        /// <summary> Resource ID. </summary>
        public string Id { get; }
        /// <summary> Resource name. </summary>
        public UsageName Name { get; }
        /// <summary> Resource type. </summary>
        public string InstancePoolUsageType { get; }
        /// <summary> Usage unit. </summary>
        public string Unit { get; }
        /// <summary> Usage current value. </summary>
        public int? CurrentValue { get; }
        /// <summary> Usage limit. </summary>
        public int? Limit { get; }
        /// <summary> Usage requested limit. </summary>
        public int? RequestedLimit { get; }
    }
}
