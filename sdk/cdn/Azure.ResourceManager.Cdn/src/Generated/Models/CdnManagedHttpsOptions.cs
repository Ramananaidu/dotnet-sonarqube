// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the certificate source parameters using CDN managed certificate for enabling SSL. </summary>
    internal partial class CdnManagedHttpsOptions : CustomDomainHttpsOptions
    {
        /// <summary> Initializes a new instance of CdnManagedHttpsOptions. </summary>
        /// <param name="protocolType"> Defines the TLS extension protocol that is used for secure delivery. </param>
        /// <param name="certificateSourceParameters"> Defines the certificate source parameters using CDN managed certificate for enabling SSL. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateSourceParameters"/> is null. </exception>
        public CdnManagedHttpsOptions(ProtocolType protocolType, CdnCertificateSourceParameters certificateSourceParameters) : base(protocolType)
        {
            if (certificateSourceParameters == null)
            {
                throw new ArgumentNullException(nameof(certificateSourceParameters));
            }

            CertificateSourceParameters = certificateSourceParameters;
            CertificateSource = CertificateSource.Cdn;
        }

        /// <summary> Defines the certificate source parameters using CDN managed certificate for enabling SSL. </summary>
        public CdnCertificateSourceParameters CertificateSourceParameters { get; }
    }
}
