// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

#if !net452
namespace Microsoft.Rest.Azure.Authentication
{
    using Microsoft.IdentityModel.Clients.ActiveDirectory;
    using Microsoft.IdentityModel.Tokens;
    using System.Security.Cryptography;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    public class ClientAssertionCertificate : IClientAssertionCertificate
    {
        private X509Certificate2 certificate;

        public string ClientId { get; private set; }
        
        public string Thumbprint
        {
            get
            {
                return Base64UrlEncoder.Encode(certificate.GetCertHash());
            }
        }

        public ClientAssertionCertificate(string clientId, X509Certificate2 certificate)
        {
            ClientId = clientId;
            this.certificate = certificate;
        }

        public ClientAssertionCertificate(string clientId, byte[] rawCertificate, string password)
            : this(clientId, new X509Certificate2(rawCertificate, password)) { }

        public ClientAssertionCertificate(string clientId, byte[] rawCertificate) 
            : this(clientId, new X509Certificate2(rawCertificate)) { }

        public ClientAssertionCertificate(string clientId, string certificateFilePath) 
            : this(clientId, new X509Certificate2(certificateFilePath)) { }

        public ClientAssertionCertificate(string clientId, string certificateFilePath, string certificatePassword)
            : this(clientId, new X509Certificate2(certificateFilePath, certificatePassword)) { }

        public byte[] Sign(string message)
        {
            using (var key = certificate.GetRSAPrivateKey())
            {
                if (key == null)
                {
                    throw new CryptographicException("No valid private RSA key found for X509Certificate2.");
                }

                return key.SignData(Encoding.UTF8.GetBytes(message), HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
            }
        }
    }
}
#endif