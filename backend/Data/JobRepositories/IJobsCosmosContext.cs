

using Microsoft.Azure.Cosmos;

namespace RecruitersDairy.Data.JobRepositories
{
    public interface IJobsCosmosContext
    {
         Container JobsContainer { get; }
    }
}
