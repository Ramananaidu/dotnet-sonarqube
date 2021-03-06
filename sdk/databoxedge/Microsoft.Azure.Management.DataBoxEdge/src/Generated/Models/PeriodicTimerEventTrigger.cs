// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Trigger details.
    /// </summary>
    [Newtonsoft.Json.JsonObject("PeriodicTimerEvent")]
    [Rest.Serialization.JsonTransformation]
    public partial class PeriodicTimerEventTrigger : Trigger
    {
        /// <summary>
        /// Initializes a new instance of the PeriodicTimerEventTrigger class.
        /// </summary>
        public PeriodicTimerEventTrigger()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PeriodicTimerEventTrigger class.
        /// </summary>
        /// <param name="sourceInfo">Periodic timer details.</param>
        /// <param name="sinkInfo">Role Sink information.</param>
        /// <param name="id">The path ID that uniquely identifies the
        /// object.</param>
        /// <param name="name">The object name.</param>
        /// <param name="type">The hierarchical type of the object.</param>
        /// <param name="systemData">Trigger in DataBoxEdge Resource</param>
        /// <param name="customContextTag">A custom context tag typically used
        /// to correlate the trigger against its usage. For example, if a
        /// periodic timer trigger is intended for certain specific IoT modules
        /// in the device, the tag can be the name or the image URL of the
        /// module.</param>
        public PeriodicTimerEventTrigger(PeriodicTimerSourceInfo sourceInfo, RoleSinkInfo sinkInfo, string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), string customContextTag = default(string))
            : base(id, name, type, systemData)
        {
            SourceInfo = sourceInfo;
            SinkInfo = sinkInfo;
            CustomContextTag = customContextTag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets periodic timer details.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceInfo")]
        public PeriodicTimerSourceInfo SourceInfo { get; set; }

        /// <summary>
        /// Gets or sets role Sink information.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sinkInfo")]
        public RoleSinkInfo SinkInfo { get; set; }

        /// <summary>
        /// Gets or sets a custom context tag typically used to correlate the
        /// trigger against its usage. For example, if a periodic timer trigger
        /// is intended for certain specific IoT modules in the device, the tag
        /// can be the name or the image URL of the module.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customContextTag")]
        public string CustomContextTag { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SourceInfo == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourceInfo");
            }
            if (SinkInfo == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SinkInfo");
            }
            if (SourceInfo != null)
            {
                SourceInfo.Validate();
            }
            if (SinkInfo != null)
            {
                SinkInfo.Validate();
            }
            if (CustomContextTag != null)
            {
                if (CustomContextTag.Length > 192)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "CustomContextTag", 192);
                }
            }
        }
    }
}
