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
    /// Represents an Azure Batch JobManager task.
    /// </summary>
    /// <remarks>
    /// Batch will retry tasks when a recovery operation is triggered on a compute node. Examples of recovery operations 
    /// include (but are not limited to) when an unhealthy compute node is rebooted or a compute node disappeared due to 
    /// host failure. Retries due to recovery operations are independent of and are not counted against the <see cref="TaskConstraints.MaxTaskRetryCount" 
    /// />. Even if the <see cref="TaskConstraints.MaxTaskRetryCount" /> is 0, an internal retry due to a recovery operation 
    /// may occur. Because of this, all tasks should be idempotent. This means tasks need to tolerate being interrupted and 
    /// restarted without causing any corruption or duplicate data. The best practice for long running tasks is to use some 
    /// form of checkpointing.
    /// </remarks>
    public partial class JobManagerTask : ITransportObjectProvider<Models.JobManagerTask>, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<bool?> AllowLowPriorityNodeProperty;
            public readonly PropertyAccessor<IList<ApplicationPackageReference>> ApplicationPackageReferencesProperty;
            public readonly PropertyAccessor<AuthenticationTokenSettings> AuthenticationTokenSettingsProperty;
            public readonly PropertyAccessor<string> CommandLineProperty;
            public readonly PropertyAccessor<TaskConstraints> ConstraintsProperty;
            public readonly PropertyAccessor<TaskContainerSettings> ContainerSettingsProperty;
            public readonly PropertyAccessor<string> DisplayNameProperty;
            public readonly PropertyAccessor<IList<EnvironmentSetting>> EnvironmentSettingsProperty;
            public readonly PropertyAccessor<string> IdProperty;
            public readonly PropertyAccessor<bool?> KillJobOnCompletionProperty;
            public readonly PropertyAccessor<IList<OutputFile>> OutputFilesProperty;
            public readonly PropertyAccessor<int?> RequiredSlotsProperty;
            public readonly PropertyAccessor<IList<ResourceFile>> ResourceFilesProperty;
            public readonly PropertyAccessor<bool?> RunExclusiveProperty;
            public readonly PropertyAccessor<UserIdentity> UserIdentityProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.AllowLowPriorityNodeProperty = this.CreatePropertyAccessor<bool?>(nameof(AllowLowPriorityNode), BindingAccess.Read | BindingAccess.Write);
                this.ApplicationPackageReferencesProperty = this.CreatePropertyAccessor<IList<ApplicationPackageReference>>(nameof(ApplicationPackageReferences), BindingAccess.Read | BindingAccess.Write);
                this.AuthenticationTokenSettingsProperty = this.CreatePropertyAccessor<AuthenticationTokenSettings>(nameof(AuthenticationTokenSettings), BindingAccess.Read | BindingAccess.Write);
                this.CommandLineProperty = this.CreatePropertyAccessor<string>(nameof(CommandLine), BindingAccess.Read | BindingAccess.Write);
                this.ConstraintsProperty = this.CreatePropertyAccessor<TaskConstraints>(nameof(Constraints), BindingAccess.Read | BindingAccess.Write);
                this.ContainerSettingsProperty = this.CreatePropertyAccessor<TaskContainerSettings>(nameof(ContainerSettings), BindingAccess.Read | BindingAccess.Write);
                this.DisplayNameProperty = this.CreatePropertyAccessor<string>(nameof(DisplayName), BindingAccess.Read | BindingAccess.Write);
                this.EnvironmentSettingsProperty = this.CreatePropertyAccessor<IList<EnvironmentSetting>>(nameof(EnvironmentSettings), BindingAccess.Read | BindingAccess.Write);
                this.IdProperty = this.CreatePropertyAccessor<string>(nameof(Id), BindingAccess.Read | BindingAccess.Write);
                this.KillJobOnCompletionProperty = this.CreatePropertyAccessor<bool?>(nameof(KillJobOnCompletion), BindingAccess.Read | BindingAccess.Write);
                this.OutputFilesProperty = this.CreatePropertyAccessor<IList<OutputFile>>(nameof(OutputFiles), BindingAccess.Read | BindingAccess.Write);
                this.RequiredSlotsProperty = this.CreatePropertyAccessor<int?>(nameof(RequiredSlots), BindingAccess.Read | BindingAccess.Write);
                this.ResourceFilesProperty = this.CreatePropertyAccessor<IList<ResourceFile>>(nameof(ResourceFiles), BindingAccess.Read | BindingAccess.Write);
                this.RunExclusiveProperty = this.CreatePropertyAccessor<bool?>(nameof(RunExclusive), BindingAccess.Read | BindingAccess.Write);
                this.UserIdentityProperty = this.CreatePropertyAccessor<UserIdentity>(nameof(UserIdentity), BindingAccess.Read | BindingAccess.Write);
            }

            public PropertyContainer(Models.JobManagerTask protocolObject) : base(BindingState.Bound)
            {
                this.AllowLowPriorityNodeProperty = this.CreatePropertyAccessor(
                    protocolObject.AllowLowPriorityNode,
                    nameof(AllowLowPriorityNode),
                    BindingAccess.Read | BindingAccess.Write);
                this.ApplicationPackageReferencesProperty = this.CreatePropertyAccessor(
                    ApplicationPackageReference.ConvertFromProtocolCollection(protocolObject.ApplicationPackageReferences),
                    nameof(ApplicationPackageReferences),
                    BindingAccess.Read | BindingAccess.Write);
                this.AuthenticationTokenSettingsProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.AuthenticationTokenSettings, o => new AuthenticationTokenSettings(o)),
                    nameof(AuthenticationTokenSettings),
                    BindingAccess.Read | BindingAccess.Write);
                this.CommandLineProperty = this.CreatePropertyAccessor(
                    protocolObject.CommandLine,
                    nameof(CommandLine),
                    BindingAccess.Read | BindingAccess.Write);
                this.ConstraintsProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.Constraints, o => new TaskConstraints(o)),
                    nameof(Constraints),
                    BindingAccess.Read | BindingAccess.Write);
                this.ContainerSettingsProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.ContainerSettings, o => new TaskContainerSettings(o).Freeze()),
                    nameof(ContainerSettings),
                    BindingAccess.Read);
                this.DisplayNameProperty = this.CreatePropertyAccessor(
                    protocolObject.DisplayName,
                    nameof(DisplayName),
                    BindingAccess.Read | BindingAccess.Write);
                this.EnvironmentSettingsProperty = this.CreatePropertyAccessor(
                    EnvironmentSetting.ConvertFromProtocolCollection(protocolObject.EnvironmentSettings),
                    nameof(EnvironmentSettings),
                    BindingAccess.Read | BindingAccess.Write);
                this.IdProperty = this.CreatePropertyAccessor(
                    protocolObject.Id,
                    nameof(Id),
                    BindingAccess.Read | BindingAccess.Write);
                this.KillJobOnCompletionProperty = this.CreatePropertyAccessor(
                    protocolObject.KillJobOnCompletion,
                    nameof(KillJobOnCompletion),
                    BindingAccess.Read | BindingAccess.Write);
                this.OutputFilesProperty = this.CreatePropertyAccessor(
                    OutputFile.ConvertFromProtocolCollection(protocolObject.OutputFiles),
                    nameof(OutputFiles),
                    BindingAccess.Read | BindingAccess.Write);
                this.RequiredSlotsProperty = this.CreatePropertyAccessor(
                    protocolObject.RequiredSlots,
                    nameof(RequiredSlots),
                    BindingAccess.Read);
                this.ResourceFilesProperty = this.CreatePropertyAccessor(
                    ResourceFile.ConvertFromProtocolCollection(protocolObject.ResourceFiles),
                    nameof(ResourceFiles),
                    BindingAccess.Read | BindingAccess.Write);
                this.RunExclusiveProperty = this.CreatePropertyAccessor(
                    protocolObject.RunExclusive,
                    nameof(RunExclusive),
                    BindingAccess.Read | BindingAccess.Write);
                this.UserIdentityProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.UserIdentity, o => new UserIdentity(o)),
                    nameof(UserIdentity),
                    BindingAccess.Read | BindingAccess.Write);
            }
        }

        private readonly PropertyContainer propertyContainer;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="JobManagerTask"/> class.
        /// </summary>
        /// <param name='id'>The id of the task.</param>
        /// <param name='commandLine'>The command line of the task.</param>
        public JobManagerTask(
            string id,
            string commandLine)
        {
            this.propertyContainer = new PropertyContainer();
            this.Id = id;
            this.CommandLine = commandLine;
        }

        internal JobManagerTask(Models.JobManagerTask protocolObject)
        {
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region JobManagerTask

        /// <summary>
        /// Gets or sets whether the Job Manager task may run on a low-priority compute node. If omitted, the default is 
        /// true.
        /// </summary>
        public bool? AllowLowPriorityNode
        {
            get { return this.propertyContainer.AllowLowPriorityNodeProperty.Value; }
            set { this.propertyContainer.AllowLowPriorityNodeProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a list of application packages that the Batch service will deploy to the compute node before running 
        /// the command line.
        /// </summary>
        public IList<ApplicationPackageReference> ApplicationPackageReferences
        {
            get { return this.propertyContainer.ApplicationPackageReferencesProperty.Value; }
            set
            {
                this.propertyContainer.ApplicationPackageReferencesProperty.Value = ConcurrentChangeTrackedModifiableList<ApplicationPackageReference>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets the settings for an authentication token that the task can use to perform Batch service operations.
        /// </summary>
        /// <remarks>
        /// If this property is set, the Batch service provides the task with an authentication token which can be used to 
        /// authenticate Batch service operations without requiring an account access key. The token is provided via the 
        /// AZ_BATCH_AUTHENTICATION_TOKEN environment variable. The operations that the task can carry out using the token 
        /// depend on the settings. For example, a task can request job permissions in order to add other tasks to the job, 
        /// or check the status of the job or of other tasks.
        /// </remarks>
        public AuthenticationTokenSettings AuthenticationTokenSettings
        {
            get { return this.propertyContainer.AuthenticationTokenSettingsProperty.Value; }
            set { this.propertyContainer.AuthenticationTokenSettingsProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the command line of the task.
        /// </summary>
        /// <remarks>
        /// The command line does not run under a shell, and therefore cannot take advantage of shell features such as environment 
        /// variable expansion. If you want to take advantage of such features, you should invoke the shell in the command 
        /// line, for example using "cmd /c MyCommand" in Windows or "/bin/sh -c MyCommand" in Linux. If the command line 
        /// refers to file paths, it should use a relative path (relative to the task working directory), or use the Batch 
        /// provided environment variables (https://docs.microsoft.com/en-us/azure/batch/batch-compute-node-environment-variables).
        /// </remarks>
        public string CommandLine
        {
            get { return this.propertyContainer.CommandLineProperty.Value; }
            set { this.propertyContainer.CommandLineProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the execution constraints for this JobManager task.
        /// </summary>
        public TaskConstraints Constraints
        {
            get { return this.propertyContainer.ConstraintsProperty.Value; }
            set { this.propertyContainer.ConstraintsProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the settings for the container under which the task runs.
        /// </summary>
        /// <remarks>
        /// If the pool that will run this task has <see cref="VirtualMachineConfiguration.ContainerConfiguration"/> set, 
        /// this must be set as well. If the pool that will run this task doesn't have <see cref="VirtualMachineConfiguration.ContainerConfiguration"/> 
        /// set, this must not be set. When this is specified, all directories recursively below the AZ_BATCH_NODE_ROOT_DIR 
        /// (the root of Azure Batch directories on the node) are mapped into the container, all task environment variables 
        /// are mapped into the container, and the task command line is executed in the container. Files produced in the 
        /// container outside of AZ_BATCH_NODE_ROOT_DIR might not be reflected to the host disk, meaning that Batch file 
        /// APIs will not be able to access them.
        /// </remarks>
        public TaskContainerSettings ContainerSettings
        {
            get { return this.propertyContainer.ContainerSettingsProperty.Value; }
            set { this.propertyContainer.ContainerSettingsProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the display name of the JobManager task.
        /// </summary>
        public string DisplayName
        {
            get { return this.propertyContainer.DisplayNameProperty.Value; }
            set { this.propertyContainer.DisplayNameProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a set of environment settings for the JobManager task.
        /// </summary>
        public IList<EnvironmentSetting> EnvironmentSettings
        {
            get { return this.propertyContainer.EnvironmentSettingsProperty.Value; }
            set
            {
                this.propertyContainer.EnvironmentSettingsProperty.Value = ConcurrentChangeTrackedModifiableList<EnvironmentSetting>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets the id of the task.
        /// </summary>
        public string Id
        {
            get { return this.propertyContainer.IdProperty.Value; }
            set { this.propertyContainer.IdProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether to terminate all tasks in the job and complete the job when the job 
        /// manager task completes.
        /// </summary>
        public bool? KillJobOnCompletion
        {
            get { return this.propertyContainer.KillJobOnCompletionProperty.Value; }
            set { this.propertyContainer.KillJobOnCompletionProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a list of files that the Batch service will upload from the compute node after running the command 
        /// line.
        /// </summary>
        public IList<OutputFile> OutputFiles
        {
            get { return this.propertyContainer.OutputFilesProperty.Value; }
            set
            {
                this.propertyContainer.OutputFilesProperty.Value = ConcurrentChangeTrackedModifiableList<OutputFile>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets the number of scheduling slots that the Task required to run.
        /// </summary>
        /// <remarks>
        /// The default is 1. A Task can only be scheduled to run on a compute node if the node has enough free scheduling 
        /// slots available. For multi-instance Tasks, this property is not supported and must not be specified.
        /// </remarks>
        public int? RequiredSlots
        {
            get { return this.propertyContainer.RequiredSlotsProperty.Value; }
            set { this.propertyContainer.RequiredSlotsProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a list of files that the Batch service will download to the compute node before running the command 
        /// line.
        /// </summary>
        /// <remarks>
        /// There is a maximum size for the list of resource files. When the max size is exceeded, the request will fail 
        /// and the response error code will be RequestEntityTooLarge. If this occurs, the collection of resource files must 
        /// be reduced in size. This can be achieved using .zip files, Application Packages, or Docker Containers.
        /// </remarks>
        public IList<ResourceFile> ResourceFiles
        {
            get { return this.propertyContainer.ResourceFilesProperty.Value; }
            set
            {
                this.propertyContainer.ResourceFilesProperty.Value = ConcurrentChangeTrackedModifiableList<ResourceFile>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets whether the Job Manager task requires exclusive use of the compute node where it runs.
        /// </summary>
        public bool? RunExclusive
        {
            get { return this.propertyContainer.RunExclusiveProperty.Value; }
            set { this.propertyContainer.RunExclusiveProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the user identity under which the task runs.
        /// </summary>
        /// <remarks>
        /// If omitted, the task runs as a non-administrative user unique to the task.
        /// </remarks>
        public UserIdentity UserIdentity
        {
            get { return this.propertyContainer.UserIdentityProperty.Value; }
            set { this.propertyContainer.UserIdentityProperty.Value = value; }
        }

        #endregion // JobManagerTask

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
        Models.JobManagerTask ITransportObjectProvider<Models.JobManagerTask>.GetTransportObject()
        {
            Models.JobManagerTask result = new Models.JobManagerTask()
            {
                AllowLowPriorityNode = this.AllowLowPriorityNode,
                ApplicationPackageReferences = UtilitiesInternal.ConvertToProtocolCollection(this.ApplicationPackageReferences),
                AuthenticationTokenSettings = UtilitiesInternal.CreateObjectWithNullCheck(this.AuthenticationTokenSettings, (o) => o.GetTransportObject()),
                CommandLine = this.CommandLine,
                Constraints = UtilitiesInternal.CreateObjectWithNullCheck(this.Constraints, (o) => o.GetTransportObject()),
                ContainerSettings = UtilitiesInternal.CreateObjectWithNullCheck(this.ContainerSettings, (o) => o.GetTransportObject()),
                DisplayName = this.DisplayName,
                EnvironmentSettings = UtilitiesInternal.ConvertToProtocolCollection(this.EnvironmentSettings),
                Id = this.Id,
                KillJobOnCompletion = this.KillJobOnCompletion,
                OutputFiles = UtilitiesInternal.ConvertToProtocolCollection(this.OutputFiles),
                RequiredSlots = this.RequiredSlots,
                ResourceFiles = UtilitiesInternal.ConvertToProtocolCollection(this.ResourceFiles),
                RunExclusive = this.RunExclusive,
                UserIdentity = UtilitiesInternal.CreateObjectWithNullCheck(this.UserIdentity, (o) => o.GetTransportObject()),
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}