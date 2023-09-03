using Microsoft.AspNetCore.Mvc;
using RecruitersDairy.Models;

namespace RecruitersDairy.Data.JobRepositories
{
    public interface IJobRepository
    {
        public Task<List<Job>> Get(string cosmosQuery);
        public Task<Job> GetById(string JobId, string Key);
        public Task<Job> UpdateJob(Job Job, string Key);

        public Task<Job> DeleteJob(string JobId, string Key);
    }
        
        
}