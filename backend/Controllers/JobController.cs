using Microsoft.AspNetCore.Mvc;
using RecruitersDairy.Models;
using System.Net;
using RecruitersDairy.Data.JobRepositories;
using Microsoft.Azure.Cosmos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecruitersDairy.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {

        public IJobRepository _jobRepository; 
        public JobController(IJobRepository jobRepository) { _jobRepository = jobRepository; }

        // GET: api/<JobController>
        [HttpGet]
        //public List<Job> GetAllJobs()
        public async Task<IActionResult> Get()
        {
            var sqlQuery = "SELECT * FROM c";
            var result = await _jobRepository.Get(sqlQuery);
            return Ok(result);
        }

        
    }
}
