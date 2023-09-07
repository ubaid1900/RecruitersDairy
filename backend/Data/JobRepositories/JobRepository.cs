using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Serialization.HybridRow.Schemas;
using RecruitersDairy.Models;

namespace RecruitersDairy.Data.JobRepositories
{
    public class JobRepository : IJobRepository
    {
        private readonly IJobsCosmosContext _cosmosContext;
        public JobRepository(IJobsCosmosContext cosmosContext)
        {
            _cosmosContext = cosmosContext;
        }

        public async Task<Job> AddAsync(Job Job)
        {
            var partitionKey = new Microsoft.Azure.Cosmos.PartitionKey(Job.id);
            var result = await _cosmosContext.JobsContainer.CreateItemAsync(Job, partitionKey);
            return result.Resource;
        }
        public async Task<List<Job>> Get(string cosmosQuery)
        {
            var query = _cosmosContext.JobsContainer.GetItemQueryIterator<Job>(new QueryDefinition(cosmosQuery));
            List<Job> results = new List<Job>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();
                results.AddRange(response);
            }
            return results;
        }
        public async Task<Job> GetById(string JobId, string partitionKey)
        {

            ItemResponse<Job> response = await _cosmosContext.JobsContainer.ReadItemAsync<Job>(JobId, new Microsoft.Azure.Cosmos.PartitionKey(partitionKey));
            // return (IActionResult)response.Resource;
            return response.Resource;

        }
        public async Task<Job> UpdateJob(Job job, string partitionKey)
        {
            job.id = "2";
            ItemResponse<Job> res = await _cosmosContext.JobsContainer.ReadItemAsync<Job>(job.id, new Microsoft.Azure.Cosmos.PartitionKey(partitionKey));
            //Get Existing Item
            var existingItem = res.Resource;
            //Replace existing item values with new values
            existingItem.Description = job.Description; //"testupdate"; 
            existingItem.Client = job.Client; // "testClientUpdate";//
            existingItem.Requirements = job.Requirements; // "testUpdateRequirement C#";
            existingItem.Location = job.Location; // "KY";
            existingItem.PayRange = job.PayRange; // "12300000-3450000";
            existingItem.PayPeriod = job.PayPeriod; // "24";;
            existingItem.ContactPer = job.ContactPer; // "KYM";
            existingItem.ContactPhone = job.ContactPhone;// "8595294105"; 
            existingItem.Created = existingItem.Created;
            existingItem.Updated = DateTime.Now;
            existingItem.UpdatedBy = "Mujahid Khan Mohammad";
            var updateRes = await _cosmosContext.JobsContainer.ReplaceItemAsync(existingItem, job.id, new Microsoft.Azure.Cosmos.PartitionKey(partitionKey));
            return (updateRes.Resource);
        }

        public async Task<Job> DeleteJob(string JobId, string partitionKey)
        {
            var response = await _cosmosContext.JobsContainer.DeleteItemAsync<Job>(JobId, new Microsoft.Azure.Cosmos.PartitionKey(partitionKey));
            return response.Resource;
        }
    }
}
