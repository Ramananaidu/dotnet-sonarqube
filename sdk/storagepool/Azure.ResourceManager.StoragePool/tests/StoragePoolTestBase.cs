// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;

namespace Azure.ResourceManager.StoragePool.Tests
{
    public class StoragePoolTestBase : ManagementRecordedTestBase<StoragePoolManagementTestEnvironment>
    {
        protected AzureLocation DefaultLocation => AzureLocation.AustraliaEast;
        protected ArmClient Client { get; private set; }
        protected Subscription DefaultSubscription { get; private set; }
        public StoragePoolTestBase(bool isAsync) : base(isAsync)
        {
        }

        public StoragePoolTestBase(bool isAsync, RecordedTestMode mode) : base(isAsync, mode)
        {
        }

        [SetUp]
        public async Task CreateCommonClient()
        {
            Client = GetArmClient();
            DefaultSubscription = await Client.GetDefaultSubscriptionAsync().ConfigureAwait(false);
        }

        protected async Task<ResourceGroup> CreateResourceGroupAsync(string resourceGroupName)
        {
            var rgOp = await DefaultSubscription.GetResourceGroups().CreateOrUpdateAsync(
                WaitUntil.Completed,
                resourceGroupName,
                new ResourceGroupData(DefaultLocation)
                {
                    Tags =
                    {
                        { "test", "env" }
                    }
                });
            return rgOp.Value;
        }
    }
}
