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
    /// Base type for all audio encoder presets, which define the recipe or
    /// instructions on how audio should be processed.
    /// </summary>
    public partial class AudioEncoderBase
    {
        /// <summary>
        /// Initializes a new instance of the AudioEncoderBase class.
        /// </summary>
        public AudioEncoderBase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AudioEncoderBase class.
        /// </summary>
        /// <param name="bitrateKbps">Bitrate, in kilobits per second or Kbps,
        /// at which audio should be encoded (2-channel stereo audio at a
        /// sampling rate of 48 kHz). Allowed values are 96, 112, 128, 160,
        /// 192, 224, and 256. If omitted, the bitrate of the input audio is
        /// used.</param>
        public AudioEncoderBase(string bitrateKbps = default(string))
        {
            BitrateKbps = bitrateKbps;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets bitrate, in kilobits per second or Kbps, at which
        /// audio should be encoded (2-channel stereo audio at a sampling rate
        /// of 48 kHz). Allowed values are 96, 112, 128, 160, 192, 224, and
        /// 256. If omitted, the bitrate of the input audio is used.
        /// </summary>
        [JsonProperty(PropertyName = "bitrateKbps")]
        public string BitrateKbps { get; set; }

    }
}
