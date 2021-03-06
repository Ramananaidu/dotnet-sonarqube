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
    /// A file to be downloaded to a compute node from Azure Blob Storage, such as task executables and task input data files.
    /// </summary>
    public partial class ResourceFile : ITransportObjectProvider<Models.ResourceFile>, IPropertyMetadata
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceFile"/> class.
        /// </summary>
        /// <param name='httpUrl'>The URL of the file to download.</param>
        /// <param name='fileMode'>The file permission mode attribute in octal format.</param>
        /// <param name='filePath'>The location on the compute node to which to download the file(s), relative to the task's working directory.</param>
        /// <param name='storageContainerUrl'>The URL of the blob container within Azure Blob Storage.</param>
        /// <param name='autoStorageContainerName'>The storage container name in the auto storage account.</param>
        /// <param name='blobPrefix'>The blob prefix to use when downloading blobs from an Azure Storage container. Only the blobs whose names begin 
        /// with the specified prefix will be downloaded.</param>
        /// <param name='identityReference'>The reference to the user assigned identity to use to access Azure Blob Storage specified by storageContainerUrl 
        /// or httpUrl</param>
        internal ResourceFile(
            string httpUrl = default(string),
            string fileMode = default(string),
            string filePath = default(string),
            string storageContainerUrl = default(string),
            string autoStorageContainerName = default(string),
            string blobPrefix = default(string),
            ComputeNodeIdentityReference identityReference = default(ComputeNodeIdentityReference))
        {
            this.HttpUrl = httpUrl;
            this.FileMode = fileMode;
            this.FilePath = filePath;
            this.StorageContainerUrl = storageContainerUrl;
            this.AutoStorageContainerName = autoStorageContainerName;
            this.BlobPrefix = blobPrefix;
            this.IdentityReference = identityReference;
        }

        internal ResourceFile(Models.ResourceFile protocolObject)
        {
            this.AutoStorageContainerName = protocolObject.AutoStorageContainerName;
            this.BlobPrefix = protocolObject.BlobPrefix;
            this.FileMode = protocolObject.FileMode;
            this.FilePath = protocolObject.FilePath;
            this.HttpUrl = protocolObject.HttpUrl;
            this.IdentityReference = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.IdentityReference, o => new ComputeNodeIdentityReference(o).Freeze());
            this.StorageContainerUrl = protocolObject.StorageContainerUrl;
        }

        #endregion Constructors

        #region ResourceFile

        /// <summary>
        /// Gets the storage container name in the auto storage account.
        /// </summary>
        public string AutoStorageContainerName { get; }

        /// <summary>
        /// Gets the blob prefix to use when downloading blobs from an Azure Storage container. Only the blobs whose names 
        /// begin with the specified prefix will be downloaded.
        /// </summary>
        /// <remarks>
        /// This property is valid only when <see cref="AutoStorageContainerName" /> or <see cref="StorageContainerUrl" /> 
        /// is used. This prefix can be a partial filename or a subdirectory. If a prefix is not specified, all the files 
        /// in the container will be downloaded.
        /// </remarks>
        public string BlobPrefix { get; }

        /// <summary>
        /// Gets the file permission mode attribute in octal format.
        /// </summary>
        /// <remarks>
        /// <para>This property is applicable only if the resource file is downloaded to a Linux node. This property will 
        /// be ignored if it is specified for a <see cref="ResourceFile"/> which will be downloaded to a Windows node. If 
        /// this property is not specified for a Linux node, then the default value is 0770.</para>
        /// </remarks>
        public string FileMode { get; }

        /// <summary>
        /// Gets the location on the compute node to which to download the file(s), relative to the task's working directory.
        /// </summary>
        /// <remarks>
        /// If the <see cref="HttpUrl" /> property is specified, this is required and describes the path which the file will 
        /// be downloaded to, including the filename. Otherwise, if the <see cref="AutoStorageContainerName" /> or <see cref="StorageContainerUrl" 
        /// /> property is specified, this is optional and is the directory to download the files to. In the case where this 
        /// is used as a directory, any directory structure already associated with the input data will be retained in full 
        /// and appended to the specified <see cref="FilePath" /> directory. The specified relative path cannot break out 
        /// of the task's working directory (for example by using '..').
        /// </remarks>
        public string FilePath { get; }

        /// <summary>
        /// Gets the URL of the file to download.
        /// </summary>
        /// <remarks>
        /// If the URL is Azure Blob Storage, it must be readable using anonymous access; that is, the Batch service does 
        /// not present any credentials when downloading the blob. There are two ways to get such a URL for a blob in Azure 
        /// storage: include a Shared Access Signature (SAS) granting read permissions on the blob, or set the ACL for the 
        /// blob or its container to allow public access.
        /// </remarks>
        public string HttpUrl { get; }

        /// <summary>
        /// Gets the reference to the user assigned identity to use to access Azure Blob Storage specified by storageContainerUrl 
        /// or httpUrl
        /// </summary>
        public ComputeNodeIdentityReference IdentityReference { get; }

        /// <summary>
        /// Gets the URL of the blob container within Azure Blob Storage.
        /// </summary>
        /// <remarks>
        /// This URL must be readable and listable using anonymous access; that is, the Batch service does not present any 
        /// credentials when downloading blobs from the container. There are two ways to get such a URL for a container in 
        /// Azure storage: include a Shared Access Signature (SAS) granting read permissions on the container, or set the 
        /// ACL for the container to allow public access.
        /// </remarks>
        public string StorageContainerUrl { get; }

        #endregion // ResourceFile

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata

        #region Internal/private methods

        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.ResourceFile ITransportObjectProvider<Models.ResourceFile>.GetTransportObject()
        {
            Models.ResourceFile result = new Models.ResourceFile()
            {
                AutoStorageContainerName = this.AutoStorageContainerName,
                BlobPrefix = this.BlobPrefix,
                FileMode = this.FileMode,
                FilePath = this.FilePath,
                HttpUrl = this.HttpUrl,
                IdentityReference = UtilitiesInternal.CreateObjectWithNullCheck(this.IdentityReference, (o) => o.GetTransportObject()),
                StorageContainerUrl = this.StorageContainerUrl,
            };

            return result;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects.
        /// </summary>
        internal static IList<ResourceFile> ConvertFromProtocolCollection(IEnumerable<Models.ResourceFile> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<ResourceFile> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new ResourceFile(o));

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, in a frozen state.
        /// </summary>
        internal static IList<ResourceFile> ConvertFromProtocolCollectionAndFreeze(IEnumerable<Models.ResourceFile> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<ResourceFile> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new ResourceFile(o).Freeze());

            converted = UtilitiesInternal.CreateObjectWithNullCheck(converted, o => o.Freeze());

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, with each object marked readonly
        /// and returned as a readonly collection.
        /// </summary>
        internal static IReadOnlyList<ResourceFile> ConvertFromProtocolCollectionReadOnly(IEnumerable<Models.ResourceFile> protoCollection)
        {
            IReadOnlyList<ResourceFile> converted =
                UtilitiesInternal.CreateObjectWithNullCheck(
                    UtilitiesInternal.CollectionToNonThreadSafeCollection(
                        items: protoCollection,
                        objectCreationFunc: o => new ResourceFile(o).Freeze()), o => o.AsReadOnly());

            return converted;
        }

        #endregion // Internal/private methods
    }
}