using RecruitersDairy.Models;

namespace RecruitersDairy.Data.JobRepositories
{
    public interface IJobRepository
    {
        public Task<List<Job>> Get(string cosmosQuery);
    }
        
        
}