// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Maintenance.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Input properties for patching a Windows machine.
    /// </summary>
    public partial class InputWindowsParameters
    {
        /// <summary>
        /// Initializes a new instance of the InputWindowsParameters class.
        /// </summary>
        public InputWindowsParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InputWindowsParameters class.
        /// </summary>
        /// <param name="kbNumbersToExclude">Windows KBID to be excluded for
        /// patching.</param>
        /// <param name="kbNumbersToInclude">Windows KBID to be included for
        /// patching.</param>
        /// <param name="classificationsToInclude">Classification category of
        /// patches to be patched</param>
        /// <param name="excludeKbsRequiringReboot">Exclude patches which need
        /// reboot</param>
        public InputWindowsParameters(IList<string> kbNumbersToExclude = default(IList<string>), IList<string> kbNumbersToInclude = default(IList<string>), IList<string> classificationsToInclude = default(IList<string>), bool? excludeKbsRequiringReboot = default(bool?))
        {
            KbNumbersToExclude = kbNumbersToExclude;
            KbNumbersToInclude = kbNumbersToInclude;
            ClassificationsToInclude = classificationsToInclude;
            ExcludeKbsRequiringReboot = excludeKbsRequiringReboot;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets windows KBID to be excluded for patching.
        /// </summary>
        [JsonProperty(PropertyName = "kbNumbersToExclude")]
        public IList<string> KbNumbersToExclude { get; set; }

        /// <summary>
        /// Gets or sets windows KBID to be included for patching.
        /// </summary>
        [JsonProperty(PropertyName = "kbNumbersToInclude")]
        public IList<string> KbNumbersToInclude { get; set; }

        /// <summary>
        /// Gets or sets classification category of patches to be patched
        /// </summary>
        [JsonProperty(PropertyName = "classificationsToInclude")]
        public IList<string> ClassificationsToInclude { get; set; }

        /// <summary>
        /// Gets or sets exclude patches which need reboot
        /// </summary>
        [JsonProperty(PropertyName = "excludeKbsRequiringReboot")]
        public bool? ExcludeKbsRequiringReboot { get; set; }

    }
}
