// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.KeyVault.Cryptography.Algorithms;
using Xunit;

namespace Microsoft.Azure.KeyVault.Cryptography.Tests
{

    /// <summary>
    /// Verify Symmetric Key.
    /// </summary>
    public class SymmetricKeyTests : IClassFixture<TestFixture>
    {

        public SymmetricKeyTests( TestFixture data )
        {
            // Intentionally empty
        }

        /// <summary>
        /// Testing AESKW128
        /// </summary>
        [Fact]
        public async Task KeyVault_SymmetricKey_AesKw128()
        {
            // Arrange
            byte[] KEK = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F };
            byte[] CEK = { 0x00, 0x11, 0x22, 0x33, 0x44, 0x55, 0x66, 0x77, 0x88, 0x99, 0xAA, 0xBB, 0xCC, 0xDD, 0xEE, 0xFF };
            byte[] EK  = { 0x1F, 0xA6, 0x8B, 0x0A, 0x81, 0x12, 0xB4, 0x47, 0xAE, 0xF3, 0x4B, 0xD8, 0xFB, 0x5A, 0x7B, 0x82, 0x9D, 0x3E, 0x86, 0x23, 0x71, 0xD2, 0xCF, 0xE5 };

            SymmetricKey key = new SymmetricKey( "KEK", KEK );

            var encrypted = await key.WrapKeyAsync( CEK, AesKw128.AlgorithmName ).ConfigureAwait( false );

            // Assert
            Assert.True( encrypted.Item1.SequenceEqual( EK ) );
            Assert.Equal("A128KW", encrypted.Item2);

            var decrypted = await key.UnwrapKeyAsync( EK, AesKw128.AlgorithmName ).ConfigureAwait( false );

            // Assert
            Assert.True( decrypted.SequenceEqual( CEK ) );
        }

        /// <summary>
        /// Testing AESKW192
        /// </summary>
        [Fact]
        public async Task KeyVault_SymmetricKey_AesKw192()
        {
            // Arrange
            byte[] KEK = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17 };
            byte[] CEK = { 0x00, 0x11, 0x22, 0x33, 0x44, 0x55, 0x66, 0x77, 0x88, 0x99, 0xAA, 0xBB, 0xCC, 0xDD, 0xEE, 0xFF };
            byte[] EK  = { 0x96, 0x77, 0x8B, 0x25, 0xAE, 0x6C, 0xA4, 0x35, 0xF9, 0x2B, 0x5B, 0x97, 0xC0, 0x50, 0xAE, 0xD2, 0x46, 0x8A, 0xB8, 0xA1, 0x7A, 0xD8, 0x4E, 0x5D };

            SymmetricKey key = new SymmetricKey( "KEK", KEK );

            var encrypted = await key.WrapKeyAsync( CEK, AesKw192.AlgorithmName ).ConfigureAwait( false );

            // Assert
            Assert.True( encrypted.Item1.SequenceEqual( EK ) );
            Assert.Equal("A192KW", encrypted.Item2);

            var decrypted = await key.UnwrapKeyAsync( EK, AesKw192.AlgorithmName ).ConfigureAwait( false );

            // Assert
            Assert.True( decrypted.SequenceEqual( CEK ) );
        }

        /// <summary>
        /// Testing AESKW256
        /// </summary>
        [Fact]
        public async Task KeyVault_SymmetricKey_AesKw256()
        {
            // Arrange
            byte[] KEK = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17, 0x18, 0x19, 0x1A, 0x1B, 0x1C, 0x1D, 0x1E, 0x1F };
            byte[] CEK = { 0x00, 0x11, 0x22, 0x33, 0x44, 0x55, 0x66, 0x77, 0x88, 0x99, 0xAA, 0xBB, 0xCC, 0xDD, 0xEE, 0xFF };
            byte[] EK  = { 0x64, 0xE8, 0xC3, 0xF9, 0xCE, 0x0F, 0x5B, 0xA2, 0x63, 0xE9, 0x77, 0x79, 0x05, 0x81, 0x8A, 0x2A, 0x93, 0xC8, 0x19, 0x1E, 0x7D, 0x6E, 0x8A, 0xE7 };

            SymmetricKey key = new SymmetricKey( "KEK", KEK );

            var encrypted = await key.WrapKeyAsync( CEK, AesKw256.AlgorithmName ).ConfigureAwait( false );

            // Assert
            Assert.True( encrypted.Item1.SequenceEqual( EK ) );
            Assert.Equal("A256KW", encrypted.Item2);

            var decrypted = await key.UnwrapKeyAsync( EK, AesKw256.AlgorithmName ).ConfigureAwait( false );

            // Assert
            Assert.True( decrypted.SequenceEqual( CEK ) );
        }

        /// <summary>
        /// Testing AESKW128
        /// </summary>
        [Fact]
        public async Task KeyVault_SymmetricKey_AesKw128_ExcessKeyMaterial()
        {
            // Arrange
            byte[] KEK = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F, 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F };
            byte[] CEK = { 0x00, 0x11, 0x22, 0x33, 0x44, 0x55, 0x66, 0x77, 0x88, 0x99, 0xAA, 0xBB, 0xCC, 0xDD, 0xEE, 0xFF };
            byte[] EK  = { 0x1F, 0xA6, 0x8B, 0x0A, 0x81, 0x12, 0xB4, 0x47, 0xAE, 0xF3, 0x4B, 0xD8, 0xFB, 0x5A, 0x7B, 0x82, 0x9D, 0x3E, 0x86, 0x23, 0x71, 0xD2, 0xCF, 0xE5 };

            SymmetricKey key = new SymmetricKey( "KEK", KEK );

            var encrypted = await key.WrapKeyAsync( CEK, AesKw128.AlgorithmName ).ConfigureAwait( false );

            // Assert
            Assert.True( encrypted.Item1.SequenceEqual( EK ) );
            Assert.Equal("A128KW", encrypted.Item2);

            var decrypted = await key.UnwrapKeyAsync( EK, AesKw128.AlgorithmName ).ConfigureAwait( false );

            // Assert
            Assert.True( decrypted.SequenceEqual( CEK ) );
        }

        /// <summary>
        /// Testing AESKW192
        /// </summary>
        [Fact]
        public async Task KeyVault_SymmetricKey_AesKw192_ExcessKeyMaterial()
        {
            // Arrange
            byte[] KEK = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17, 0x18, 0x19, 0x1A, 0x1B, 0x1C, 0x1D, 0x1E, 0x1F };
            byte[] CEK = { 0x00, 0x11, 0x22, 0x33, 0x44, 0x55, 0x66, 0x77, 0x88, 0x99, 0xAA, 0xBB, 0xCC, 0xDD, 0xEE, 0xFF };
            byte[] EK  = { 0x96, 0x77, 0x8B, 0x25, 0xAE, 0x6C, 0xA4, 0x35, 0xF9, 0x2B, 0x5B, 0x97, 0xC0, 0x50, 0xAE, 0xD2, 0x46, 0x8A, 0xB8, 0xA1, 0x7A, 0xD8, 0x4E, 0x5D };

            SymmetricKey key = new SymmetricKey( "KEK", KEK );

            var encrypted = await key.WrapKeyAsync( CEK, AesKw192.AlgorithmName ).ConfigureAwait( false );

            // Assert
            Assert.True( encrypted.Item1.SequenceEqual( EK ) );
            Assert.Equal("A192KW", encrypted.Item2);

            var decrypted = await key.UnwrapKeyAsync( EK, AesKw192.AlgorithmName ).ConfigureAwait( false );

            // Assert
            Assert.True( decrypted.SequenceEqual( CEK ) );
        }

        /// <summary>
        /// Testing AESKW256
        /// </summary>
        [Fact]
        public async Task KeyVault_SymmetricKey_AesKw256_ExcessKeyMaterial()
        {
            // Arrange
            byte[] KEK = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17, 0x18, 0x19, 0x1A, 0x1B, 0x1C, 0x1D, 0x1E, 0x1F, 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F };
            byte[] CEK = { 0x00, 0x11, 0x22, 0x33, 0x44, 0x55, 0x66, 0x77, 0x88, 0x99, 0xAA, 0xBB, 0xCC, 0xDD, 0xEE, 0xFF };
            byte[] EK  = { 0x64, 0xE8, 0xC3, 0xF9, 0xCE, 0x0F, 0x5B, 0xA2, 0x63, 0xE9, 0x77, 0x79, 0x05, 0x81, 0x8A, 0x2A, 0x93, 0xC8, 0x19, 0x1E, 0x7D, 0x6E, 0x8A, 0xE7 };

            SymmetricKey key = new SymmetricKey( "KEK", KEK );

            var encrypted = await key.WrapKeyAsync( CEK, AesKw256.AlgorithmName ).ConfigureAwait( false );

            // Assert
            Assert.True( encrypted.Item1.SequenceEqual( EK ) );
            Assert.Equal("A256KW", encrypted.Item2);

            var decrypted = await key.UnwrapKeyAsync( EK, AesKw256.AlgorithmName ).ConfigureAwait( false );

            // Assert
            Assert.True( decrypted.SequenceEqual( CEK ) );
        }
    }
}
