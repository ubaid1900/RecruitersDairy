using Microsoft.Azure.Cosmos;
using Newtonsoft.Json;
using RecruitersDairy.Data;
using RecruitersDairy.Models;
using System;
using Microsoft.Extensions.Configuration;

namespace RecruitersDairy.Data.JobRepositories
{
    public class JobsCosmosContext : IJobsCosmosContext
    {
        private IConfiguration Configuration;
        public JobsCosmosContext(IConfiguration configuration)
        {
            Configuration = configuration;
            string endPoint = Configuration["JobCosmosContext:EndPoint"];
            string key = Configuration["JobCosmosContext:Key"];
            CosmosClient _client = new CosmosClient(endPoint, key);
            string databaseName = Configuration["JobCosmosContext:DatabaseName"];
            JobsContainer = _client.GetContainer(databaseName, Configuration["JobCosmosContext:ContainerName"]);
        }
        public Container JobsContainer { get; }
    }
}

