// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Managed application artifact. </summary>
    public partial class ApplicationArtifact
    {
        /// <summary> Initializes a new instance of ApplicationArtifact. </summary>
        /// <param name="name"> The managed application artifact name. </param>
        /// <param name="uri"> The managed application artifact blob uri. </param>
        /// <param name="applicationArtifactType"> The managed application artifact type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        internal ApplicationArtifact(ApplicationArtifactName name, Uri uri, ApplicationArtifactType applicationArtifactType)
        {
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }

            Name = name;
            Uri = uri;
            ApplicationArtifactType = applicationArtifactType;
        }

        /// <summary> The managed application artifact name. </summary>
        public ApplicationArtifactName Name { get; }
        /// <summary> The managed application artifact blob uri. </summary>
        public Uri Uri { get; }
        /// <summary> The managed application artifact type. </summary>
        public ApplicationArtifactType ApplicationArtifactType { get; }
    }
}
