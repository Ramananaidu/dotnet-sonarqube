// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This class represent a single filter object that defines a
    /// multidimensional set. The dimensions of this set are Regions,
    /// ClusterFlavors, NodeTypes and ClusterVersions. The constraint should be
    /// defined based on the following: FilterMode (Exclude vs Include),
    /// VMSizes (the vm sizes in affect of exclusion/inclusion) and the
    /// ordering of the Filters. Later filters override previous settings if
    /// conflicted.
    /// </summary>
    public partial class VmSizeCompatibilityFilterV2
    {
        /// <summary>
        /// Initializes a new instance of the VmSizeCompatibilityFilterV2
        /// class.
        /// </summary>
        public VmSizeCompatibilityFilterV2()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VmSizeCompatibilityFilterV2
        /// class.
        /// </summary>
        /// <param name="filterMode">The filtering mode. Effectively this can
        /// enabling or disabling the VM sizes in a particular set. Possible
        /// values include: 'Exclude', 'Include', 'Recommend',
        /// 'Default'</param>
        /// <param name="regions">The list of regions under the effect of the
        /// filter.</param>
        /// <param name="clusterFlavors">The list of cluster flavors under the
        /// effect of the filter.</param>
        /// <param name="nodeTypes">The list of node types affected by the
        /// filter.</param>
        /// <param name="clusterVersions">The list of cluster versions affected
        /// in Major.Minor format.</param>
        /// <param name="osType">The OSType affected, Windows or Linux.</param>
        /// <param name="vmSizes">The list of virtual machine sizes to include
        /// or exclude.</param>
        /// <param name="espApplied">Whether apply for ESP cluster. 'true'
        /// means only for ESP, 'false' means only for non-ESP, null or empty
        /// string or others mean for both.</param>
        /// <param name="computeIsolationSupported">Whether support compute
        /// isolation. 'true' means only for ComputeIsolationEnabled, 'false'
        /// means only for regular cluster.</param>
        public VmSizeCompatibilityFilterV2(string filterMode = default(string), IList<string> regions = default(IList<string>), IList<string> clusterFlavors = default(IList<string>), IList<string> nodeTypes = default(IList<string>), IList<string> clusterVersions = default(IList<string>), IList<string> osType = default(IList<string>), IList<string> vmSizes = default(IList<string>), string espApplied = default(string), string computeIsolationSupported = default(string))
        {
            FilterMode = filterMode;
            Regions = regions;
            ClusterFlavors = clusterFlavors;
            NodeTypes = nodeTypes;
            ClusterVersions = clusterVersions;
            OsType = osType;
            VmSizes = vmSizes;
            EspApplied = espApplied;
            ComputeIsolationSupported = computeIsolationSupported;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the filtering mode. Effectively this can enabling or
        /// disabling the VM sizes in a particular set. Possible values
        /// include: 'Exclude', 'Include', 'Recommend', 'Default'
        /// </summary>
        [JsonProperty(PropertyName = "filterMode")]
        public string FilterMode { get; set; }

        /// <summary>
        /// Gets or sets the list of regions under the effect of the filter.
        /// </summary>
        [JsonProperty(PropertyName = "regions")]
        public IList<string> Regions { get; set; }

        /// <summary>
        /// Gets or sets the list of cluster flavors under the effect of the
        /// filter.
        /// </summary>
        [JsonProperty(PropertyName = "clusterFlavors")]
        public IList<string> ClusterFlavors { get; set; }

        /// <summary>
        /// Gets or sets the list of node types affected by the filter.
        /// </summary>
        [JsonProperty(PropertyName = "nodeTypes")]
        public IList<string> NodeTypes { get; set; }

        /// <summary>
        /// Gets or sets the list of cluster versions affected in Major.Minor
        /// format.
        /// </summary>
        [JsonProperty(PropertyName = "clusterVersions")]
        public IList<string> ClusterVersions { get; set; }

        /// <summary>
        /// Gets or sets the OSType affected, Windows or Linux.
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public IList<string> OsType { get; set; }

        /// <summary>
        /// Gets or sets the list of virtual machine sizes to include or
        /// exclude.
        /// </summary>
        [JsonProperty(PropertyName = "vmSizes")]
        public IList<string> VmSizes { get; set; }

        /// <summary>
        /// Gets or sets whether apply for ESP cluster. 'true' means only for
        /// ESP, 'false' means only for non-ESP, null or empty string or others
        /// mean for both.
        /// </summary>
        [JsonProperty(PropertyName = "espApplied")]
        public string EspApplied { get; set; }

        /// <summary>
        /// Gets or sets whether support compute isolation. 'true' means only
        /// for ComputeIsolationEnabled, 'false' means only for regular
        /// cluster.
        /// </summary>
        [JsonProperty(PropertyName = "computeIsolationSupported")]
        public string ComputeIsolationSupported { get; set; }

    }
}
