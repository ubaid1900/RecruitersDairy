using Microsoft.Azure.Cosmos;
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
            var partitionKey = new PartitionKey(Job.id);
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
    }
}
