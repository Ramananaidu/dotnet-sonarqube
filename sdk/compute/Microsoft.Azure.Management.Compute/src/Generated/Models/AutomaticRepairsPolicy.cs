// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specifies the configuration parameters for automatic repairs on the
    /// virtual machine scale set.
    /// </summary>
    public partial class AutomaticRepairsPolicy
    {
        /// <summary>
        /// Initializes a new instance of the AutomaticRepairsPolicy class.
        /// </summary>
        public AutomaticRepairsPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutomaticRepairsPolicy class.
        /// </summary>
        /// <param name="enabled">Specifies whether automatic repairs should be
        /// enabled on the virtual machine scale set. The default value is
        /// false.</param>
        /// <param name="gracePeriod">The amount of time for which automatic
        /// repairs are suspended due to a state change on VM. The grace time
        /// starts after the state change has completed. This helps avoid
        /// premature or accidental repairs. The time duration should be
        /// specified in ISO 8601 format. The minimum allowed grace period is
        /// 10 minutes (PT10M), which is also the default value. The maximum
        /// allowed grace period is 90 minutes (PT90M).</param>
        /// <param name="repairAction">Type of repair action (replace, restart,
        /// reimage) that will be used for repairing unhealthy virtual machines
        /// in the scale set. Default value is replace. Possible values
        /// include: 'Replace', 'Restart', 'Reimage'</param>
        public AutomaticRepairsPolicy(bool? enabled = default(bool?), string gracePeriod = default(string), string repairAction = default(string))
        {
            Enabled = enabled;
            GracePeriod = gracePeriod;
            RepairAction = repairAction;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies whether automatic repairs should be enabled
        /// on the virtual machine scale set. The default value is false.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the amount of time for which automatic repairs are
        /// suspended due to a state change on VM. The grace time starts after
        /// the state change has completed. This helps avoid premature or
        /// accidental repairs. The time duration should be specified in ISO
        /// 8601 format. The minimum allowed grace period is 10 minutes
        /// (PT10M), which is also the default value. The maximum allowed grace
        /// period is 90 minutes (PT90M).
        /// </summary>
        [JsonProperty(PropertyName = "gracePeriod")]
        public string GracePeriod { get; set; }

        /// <summary>
        /// Gets or sets type of repair action (replace, restart, reimage) that
        /// will be used for repairing unhealthy virtual machines in the scale
        /// set. Default value is replace. Possible values include: 'Replace',
        /// 'Restart', 'Reimage'
        /// </summary>
        [JsonProperty(PropertyName = "repairAction")]
        public string RepairAction { get; set; }

    }
}
