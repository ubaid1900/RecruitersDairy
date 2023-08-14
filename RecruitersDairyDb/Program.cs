using System;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Generic;
using System.Net;
using Microsoft.Azure.Cosmos;
using RecruitersDairy.Models;
namespace RecruitersDairyDb
{
    class Program
    {
        // The Azure Cosmos DB endpoint for running this sample.
        private static readonly string EndpointUri = ConfigurationManager.AppSettings["EndPointUri"];

        // The primary key for the Azure Cosmos account.
        private static readonly string PrimaryKey = ConfigurationManager.AppSettings["PrimaryKey"];

        // The Cosmos client instance
        private CosmosClient cosmosClient;

        // The database we will create
        private Database RDDatabase;

        // The container we will create.
        private Container RDContainer;

        // The name of the database and container we will create
        private string RDDatabaseId = "RecruitersDairyDB";
        private string RDContainerId = "Jobs";


        // <Main>
        public static async Task Main(string[] args)
        {
            try
            {
                Console.WriteLine("Beginning operations...\n");
                Program p = new Program();
                await p.GetStartedDemoAsync();

            }
            catch (CosmosException ce)
            {
                Exception baseException = ce.GetBaseException();
                Console.WriteLine("{0} error Occured: {1}", ce.StatusCode, ce);
            }

        }

        public async Task GetStartedDemoAsync()
        {
            this.cosmosClient = new CosmosClient(EndpointUri, PrimaryKey, new CosmosClientOptions() { ApplicationName = "RecruitersDairy" });
            await this.CreateDatabaseAsync();
            await this.CreateContainerAsync();
            //await this.ScaleContainerAsync();
            await this.AddItemsToContainerAsync();
            //await this.QueryItemsAsync();
            //await this.ReplaceFamilyItemAsync();
            //await this.DeleteFamilyItemAsync();
            //await this.DeleteDatabaseAndCleanupAsync();
        }


        private async Task CreateDatabaseAsync()
        {
            // Create a new database
            this.RDDatabase = await this.cosmosClient.CreateDatabaseIfNotExistsAsync(RDDatabaseId);
            Console.WriteLine("Created Database: {0}\n", this.RDDatabase.Id);
        }

        private async Task CreateContainerAsync()
        {
            // Create a new container
            this.RDContainer = await this.RDDatabase.CreateContainerIfNotExistsAsync(RDContainerId, "/Id", 400);
            Console.WriteLine("Created Container: {0}\n", this.RDContainer.Id);
        }

        /// <summary>
        /// Create Job Object to insert jobs in database
        /// </summary>
        /// <returns></returns>
        private async Task AddItemsToContainerAsync()
        {
            Job Jobs = new Job()

            {
                Id = "1",
                Description = "First Job",
                Location = "Hyderabad",
                Requirements = "C#,ASP.NET,SQL Server",
                ContactPer = "Mujahid Khan Mohammad",
                ContactPhone = "9898989898",
                Client = "ABC",
                PayPeriod = "Monthly",
                PayRange = "10L-20L",
                CreatedBy = "recruiter1@gmail.com",
                Created = new DateTime(),
                UpdatedBy = "recruiter1@gmail.com",
                Updated = new DateTime()
            };
            //new Job()
            //{
            //    Id = "2",
            //    Description = "Second Job",
            //    Location = "Pune",
            //    Requirements = "java",
            //    ContactPer = "Ubaid",
            //    ContactPhone = "908909890",
            //    Client = "ABC",
            //    PayPeriod = "Monthly",
            //    PayRange = "10L-20L",
            //    CreatedBy = "recruiter1@gmail.com",
            //    Created = new DateTime(),
            //    UpdatedBy = "recruiter1@gmail.com",
            //    Updated = new DateTime()
            //};
            try
            {
                // Read the item to see if it exists.  
                ItemResponse<Job> JobResponse = await this.RDContainer.ReadItemAsync<Job>(Jobs.Id, new PartitionKey(Jobs.Id));
                Console.WriteLine("Item in database with id: {0} already exists\n", JobResponse.Resource.Id);
            }
            catch (CosmosException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
            {
                // Create an item in the container representing the Job Object. Note we provide the value of the partition key for this item, which is "Jobs"
                ItemResponse<Job> JobResponse = await this.RDContainer.CreateItemAsync<Job>(Jobs, new PartitionKey(Jobs.Id));

                // Note that after creating the item, we can access the body of the item with the Resource property off the ItemResponse. We can also access the RequestCharge property to see the amount of RUs consumed on this request.
                Console.WriteLine("Created item in database with id: {0} Operation consumed {1} RUs.\n", JobResponse.Resource.Id, JobResponse.RequestCharge);
            }

        }

        //private async Task QueryItemsAsync()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

