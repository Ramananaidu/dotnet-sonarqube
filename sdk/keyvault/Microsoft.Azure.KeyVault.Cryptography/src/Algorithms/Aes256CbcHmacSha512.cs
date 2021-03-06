// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

namespace Microsoft.Azure.KeyVault.Cryptography.Algorithms
{
    /// <summary>
    /// JWE A256CBC-HS512: https://tools.ietf.org/html/rfc7518#section-5.2.5
    /// </summary>
    public class Aes256CbcHmacSha512 : AesCbcHmacSha2
    {
        public const string AlgorithmName = "A256CBC-HS512";

        public Aes256CbcHmacSha512() : base( AlgorithmName )
        {
        }
    }
}
