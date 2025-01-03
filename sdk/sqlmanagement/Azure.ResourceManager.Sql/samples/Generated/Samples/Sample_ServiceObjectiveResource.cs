// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_ServiceObjectiveResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAServiceObjective()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/stable/2014-04-01/examples/ServiceObjectiveGet.json
            // this example is just showing the usage of "ServiceObjectives_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceObjectiveResource created on azure
            // for more information of creating ServiceObjectiveResource, please refer to the document of ServiceObjectiveResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "group1";
            string serverName = "sqlcrudtest";
            string serviceObjectiveName = "29dd7459-4a7c-4e56-be22-f0adda49440d";
            ResourceIdentifier serviceObjectiveResourceId = ServiceObjectiveResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, serviceObjectiveName);
            ServiceObjectiveResource serviceObjective = client.GetServiceObjectiveResource(serviceObjectiveResourceId);

            // invoke the operation
            ServiceObjectiveResource result = await serviceObjective.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceObjectiveData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
