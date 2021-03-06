// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a custom preset for encoding the input content using the
    /// encoder processor.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.VideoAnalyzer.EncoderCustomPreset")]
    public partial class EncoderCustomPreset : EncoderPresetBase
    {
        /// <summary>
        /// Initializes a new instance of the EncoderCustomPreset class.
        /// </summary>
        public EncoderCustomPreset()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EncoderCustomPreset class.
        /// </summary>
        /// <param name="audioEncoder">Describes a custom preset for encoding
        /// audio.</param>
        /// <param name="videoEncoder">Describes a custom preset for encoding
        /// video.</param>
        public EncoderCustomPreset(AudioEncoderBase audioEncoder = default(AudioEncoderBase), VideoEncoderBase videoEncoder = default(VideoEncoderBase))
        {
            AudioEncoder = audioEncoder;
            VideoEncoder = videoEncoder;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets describes a custom preset for encoding audio.
        /// </summary>
        [JsonProperty(PropertyName = "audioEncoder")]
        public AudioEncoderBase AudioEncoder { get; set; }

        /// <summary>
        /// Gets or sets describes a custom preset for encoding video.
        /// </summary>
        [JsonProperty(PropertyName = "videoEncoder")]
        public VideoEncoderBase VideoEncoder { get; set; }

    }
}
