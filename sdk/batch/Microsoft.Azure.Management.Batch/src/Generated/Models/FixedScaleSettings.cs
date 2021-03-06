// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Fixed scale settings for the pool.
    /// </summary>
    public partial class FixedScaleSettings
    {
        /// <summary>
        /// Initializes a new instance of the FixedScaleSettings class.
        /// </summary>
        public FixedScaleSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FixedScaleSettings class.
        /// </summary>
        /// <param name="resizeTimeout">The timeout for allocation of compute
        /// nodes to the pool.</param>
        /// <param name="targetDedicatedNodes">The desired number of dedicated
        /// compute nodes in the pool.</param>
        /// <param name="targetLowPriorityNodes">The desired number of
        /// Spot/low-priority compute nodes in the pool.</param>
        /// <param name="nodeDeallocationOption">Determines what to do with a
        /// node and its running task(s) if the pool size is
        /// decreasing.</param>
        public FixedScaleSettings(System.TimeSpan? resizeTimeout = default(System.TimeSpan?), int? targetDedicatedNodes = default(int?), int? targetLowPriorityNodes = default(int?), ComputeNodeDeallocationOption? nodeDeallocationOption = default(ComputeNodeDeallocationOption?))
        {
            ResizeTimeout = resizeTimeout;
            TargetDedicatedNodes = targetDedicatedNodes;
            TargetLowPriorityNodes = targetLowPriorityNodes;
            NodeDeallocationOption = nodeDeallocationOption;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the timeout for allocation of compute nodes to the
        /// pool.
        /// </summary>
        /// <remarks>
        /// The default value is 15 minutes. Timeout values use ISO 8601
        /// format. For example, use PT10M for 10 minutes. The minimum value is
        /// 5 minutes. If you specify a value less than 5 minutes, the Batch
        /// service rejects the request with an error; if you are calling the
        /// REST API directly, the HTTP status code is 400 (Bad Request).
        /// </remarks>
        [JsonProperty(PropertyName = "resizeTimeout")]
        public System.TimeSpan? ResizeTimeout { get; set; }

        /// <summary>
        /// Gets or sets the desired number of dedicated compute nodes in the
        /// pool.
        /// </summary>
        /// <remarks>
        /// At least one of targetDedicatedNodes, targetLowPriorityNodes must
        /// be set.
        /// </remarks>
        [JsonProperty(PropertyName = "targetDedicatedNodes")]
        public int? TargetDedicatedNodes { get; set; }

        /// <summary>
        /// Gets or sets the desired number of Spot/low-priority compute nodes
        /// in the pool.
        /// </summary>
        /// <remarks>
        /// At least one of targetDedicatedNodes, targetLowPriorityNodes must
        /// be set.
        /// </remarks>
        [JsonProperty(PropertyName = "targetLowPriorityNodes")]
        public int? TargetLowPriorityNodes { get; set; }

        /// <summary>
        /// Gets or sets determines what to do with a node and its running
        /// task(s) if the pool size is decreasing.
        /// </summary>
        /// <remarks>
        /// If omitted, the default value is Requeue. Possible values include:
        /// 'Requeue', 'Terminate', 'TaskCompletion', 'RetainedData'
        /// </remarks>
        [JsonProperty(PropertyName = "nodeDeallocationOption")]
        public ComputeNodeDeallocationOption? NodeDeallocationOption { get; set; }

    }
}
