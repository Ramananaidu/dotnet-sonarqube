// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The impact of an operation, both in absolute and relative terms. </summary>
    internal partial class OperationImpact
    {
        /// <summary> Initializes a new instance of OperationImpact. </summary>
        internal OperationImpact()
        {
        }

        /// <summary> The name of the impact dimension. </summary>
        public string Name { get; }
        /// <summary> The unit in which estimated impact to dimension is measured. </summary>
        public string Unit { get; }
        /// <summary> The absolute impact to dimension. </summary>
        public double? ChangeValueAbsolute { get; }
        /// <summary> The relative impact to dimension (null if not applicable). </summary>
        public double? ChangeValueRelative { get; }
    }
}
