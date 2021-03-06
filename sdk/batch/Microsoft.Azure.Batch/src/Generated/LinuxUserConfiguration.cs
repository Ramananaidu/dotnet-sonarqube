// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties used to create a user account on a Linux node.
    /// </summary>
    public partial class LinuxUserConfiguration : ITransportObjectProvider<Models.LinuxUserConfiguration>, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<int?> GidProperty;
            public readonly PropertyAccessor<string> SshPrivateKeyProperty;
            public readonly PropertyAccessor<int?> UidProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.GidProperty = this.CreatePropertyAccessor<int?>(nameof(Gid), BindingAccess.Read | BindingAccess.Write);
                this.SshPrivateKeyProperty = this.CreatePropertyAccessor<string>(nameof(SshPrivateKey), BindingAccess.Read | BindingAccess.Write);
                this.UidProperty = this.CreatePropertyAccessor<int?>(nameof(Uid), BindingAccess.Read | BindingAccess.Write);
            }

            public PropertyContainer(Models.LinuxUserConfiguration protocolObject) : base(BindingState.Bound)
            {
                this.GidProperty = this.CreatePropertyAccessor(
                    protocolObject.Gid,
                    nameof(Gid),
                    BindingAccess.Read);
                this.SshPrivateKeyProperty = this.CreatePropertyAccessor(
                    protocolObject.SshPrivateKey,
                    nameof(SshPrivateKey),
                    BindingAccess.Read);
                this.UidProperty = this.CreatePropertyAccessor(
                    protocolObject.Uid,
                    nameof(Uid),
                    BindingAccess.Read);
            }
        }

        private readonly PropertyContainer propertyContainer;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LinuxUserConfiguration"/> class.
        /// </summary>
        /// <param name='uid'>The user ID of the user account.</param>
        /// <param name='gid'>The group ID of the user account.</param>
        /// <param name='sshPrivateKey'>The SSH private key for the user account.</param>
        public LinuxUserConfiguration(
            int? uid = default(int?),
            int? gid = default(int?),
            string sshPrivateKey = default(string))
        {
            this.propertyContainer = new PropertyContainer();
            this.Uid = uid;
            this.Gid = gid;
            this.SshPrivateKey = sshPrivateKey;
        }

        /// <summary>
        /// Default constructor to support mocking the <see cref="LinuxUserConfiguration"/> class.
        /// </summary>
        protected LinuxUserConfiguration()
        {
            this.propertyContainer = new PropertyContainer();
        }

        internal LinuxUserConfiguration(Models.LinuxUserConfiguration protocolObject)
        {
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region LinuxUserConfiguration

        /// <summary>
        /// Gets or sets the group ID of the user account.
        /// </summary>
        /// <remarks>
        /// The <see cref="Uid" /> and <see cref="Gid" /> properties must be specified together or not at all. If not specified, 
        /// the underlying operating system picks the gid.
        /// </remarks>
        public int? Gid
        {
            get { return this.propertyContainer.GidProperty.Value; }
            set { this.propertyContainer.GidProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the SSH private key for the user account.
        /// </summary>
        /// <remarks>
        /// The private key must not be password protected. The private key is used to automatically configure asymmetric-key 
        /// based authentication for SSH between nodes in a Linux pool when the pool's <see cref="CloudPool.InterComputeNodeCommunicationEnabled"/> 
        /// property is true (it is ignored if <see cref="CloudPool.InterComputeNodeCommunicationEnabled"/> is false). It 
        /// does this by placing the key pair into the user's .ssh directory. If not specified, password-less SSH is not 
        /// configured between nodes (no modification of the user's .ssh directory is done)
        /// </remarks>
        public string SshPrivateKey
        {
            get { return this.propertyContainer.SshPrivateKeyProperty.Value; }
            set { this.propertyContainer.SshPrivateKeyProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the user ID of the user account.
        /// </summary>
        /// <remarks>
        /// The <see cref="Uid" /> and <see cref="Gid" /> properties must be specified together or not at all. If not specified, 
        /// the underlying operating system picks the uid.
        /// </remarks>
        public int? Uid
        {
            get { return this.propertyContainer.UidProperty.Value; }
            set { this.propertyContainer.UidProperty.Value = value; }
        }

        #endregion // LinuxUserConfiguration

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            get { return this.propertyContainer.HasBeenModified; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return this.propertyContainer.IsReadOnly; }
            set { this.propertyContainer.IsReadOnly = value; }
        }

        #endregion //IPropertyMetadata

        #region Internal/private methods
        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.LinuxUserConfiguration ITransportObjectProvider<Models.LinuxUserConfiguration>.GetTransportObject()
        {
            Models.LinuxUserConfiguration result = new Models.LinuxUserConfiguration()
            {
                Gid = this.Gid,
                SshPrivateKey = this.SshPrivateKey,
                Uid = this.Uid,
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}