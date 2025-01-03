// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Synapse.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Synapse.Samples
{
    public partial class Sample_SynapseDataMaskingPolicyResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetDataMaskingPolicy()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/DataMaskingPolicyGet.json
            // this example is just showing the usage of "DataMaskingPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseDataMaskingPolicyResource created on azure
            // for more information of creating SynapseDataMaskingPolicyResource, please refer to the document of SynapseDataMaskingPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string workspaceName = "sqlcrudtest-2080";
            string sqlPoolName = "sqlcrudtest-331";
            ResourceIdentifier synapseDataMaskingPolicyResourceId = SynapseDataMaskingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName);
            SynapseDataMaskingPolicyResource synapseDataMaskingPolicy = client.GetSynapseDataMaskingPolicyResource(synapseDataMaskingPolicyResourceId);

            // invoke the operation
            SynapseDataMaskingPolicyResource result = await synapseDataMaskingPolicy.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseDataMaskingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateDataMaskingPolicyMax()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/DataMaskingPolicyCreateOrUpdateMax.json
            // this example is just showing the usage of "DataMaskingPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseDataMaskingPolicyResource created on azure
            // for more information of creating SynapseDataMaskingPolicyResource, please refer to the document of SynapseDataMaskingPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string workspaceName = "sqlcrudtest-2080";
            string sqlPoolName = "sqlcrudtest-331";
            ResourceIdentifier synapseDataMaskingPolicyResourceId = SynapseDataMaskingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName);
            SynapseDataMaskingPolicyResource synapseDataMaskingPolicy = client.GetSynapseDataMaskingPolicyResource(synapseDataMaskingPolicyResourceId);

            // invoke the operation
            SynapseDataMaskingPolicyData data = new SynapseDataMaskingPolicyData
            {
                DataMaskingState = SynapseDataMaskingState.Enabled,
                ExemptPrincipals = "testuser;",
            };
            ArmOperation<SynapseDataMaskingPolicyResource> lro = await synapseDataMaskingPolicy.CreateOrUpdateAsync(WaitUntil.Completed, data);
            SynapseDataMaskingPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseDataMaskingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateDataMaskingPolicyMin()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/DataMaskingPolicyCreateOrUpdateMin.json
            // this example is just showing the usage of "DataMaskingPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseDataMaskingPolicyResource created on azure
            // for more information of creating SynapseDataMaskingPolicyResource, please refer to the document of SynapseDataMaskingPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string workspaceName = "sqlcrudtest-2080";
            string sqlPoolName = "sqlcrudtest-331";
            ResourceIdentifier synapseDataMaskingPolicyResourceId = SynapseDataMaskingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName);
            SynapseDataMaskingPolicyResource synapseDataMaskingPolicy = client.GetSynapseDataMaskingPolicyResource(synapseDataMaskingPolicyResourceId);

            // invoke the operation
            SynapseDataMaskingPolicyData data = new SynapseDataMaskingPolicyData
            {
                DataMaskingState = SynapseDataMaskingState.Enabled,
            };
            ArmOperation<SynapseDataMaskingPolicyResource> lro = await synapseDataMaskingPolicy.CreateOrUpdateAsync(WaitUntil.Completed, data);
            SynapseDataMaskingPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseDataMaskingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
