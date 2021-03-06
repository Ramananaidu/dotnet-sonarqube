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
    /// Video preview image URLs. These URLs can be used in conjunction with
    /// the video content authorization token to download the most recent still
    /// image from the video archive in different resolutions. They are
    /// available when the video type is 'archive' and preview images are
    /// enabled.
    /// </summary>
    public partial class VideoPreviewImageUrls
    {
        /// <summary>
        /// Initializes a new instance of the VideoPreviewImageUrls class.
        /// </summary>
        public VideoPreviewImageUrls()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VideoPreviewImageUrls class.
        /// </summary>
        /// <param name="small">Low resolution preview image URL.</param>
        /// <param name="medium">Medium resolution preview image URL.</param>
        /// <param name="large">High resolution preview image URL.</param>
        public VideoPreviewImageUrls(string small = default(string), string medium = default(string), string large = default(string))
        {
            Small = small;
            Medium = medium;
            Large = large;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets low resolution preview image URL.
        /// </summary>
        [JsonProperty(PropertyName = "small")]
        public string Small { get; set; }

        /// <summary>
        /// Gets or sets medium resolution preview image URL.
        /// </summary>
        [JsonProperty(PropertyName = "medium")]
        public string Medium { get; set; }

        /// <summary>
        /// Gets or sets high resolution preview image URL.
        /// </summary>
        [JsonProperty(PropertyName = "large")]
        public string Large { get; set; }

    }
}
