// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The TLS properties of the connected registry login server.
    /// </summary>
    public partial class TlsProperties
    {
        /// <summary>
        /// Initializes a new instance of the TlsProperties class.
        /// </summary>
        public TlsProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TlsProperties class.
        /// </summary>
        /// <param name="status">Indicates whether HTTPS is enabled for the
        /// login server. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        /// <param name="certificate">The certificate used to configure HTTPS
        /// for the login server.</param>
        public TlsProperties(string status = default(string), TlsCertificateProperties certificate = default(TlsCertificateProperties))
        {
            Status = status;
            Certificate = certificate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets indicates whether HTTPS is enabled for the login server.
        /// Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets the certificate used to configure HTTPS for the login server.
        /// </summary>
        [JsonProperty(PropertyName = "certificate")]
        public TlsCertificateProperties Certificate { get; private set; }

    }
}
