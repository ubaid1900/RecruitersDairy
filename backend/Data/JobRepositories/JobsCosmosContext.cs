using Microsoft.Azure.Cosmos;
using RecruitersDairy.Data;
using RecruitersDairy.Models;
using System;

namespace RecruitersDairy.Data.JobRepositories
{
    public class JobsCosmosContext : IJobsCosmosContext
    {
        public JobsCosmosContext()
        {
            string endPoint = "https://localhost:8081";
            string key = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";
            CosmosClient _client = new CosmosClient(endPoint, key);
            string databaseName = "RecruitersDairyDB";
            JobsContainer = _client.GetContainer(databaseName, "Jobs");
        }
        public Container JobsContainer { get; }
    }
}

