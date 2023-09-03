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
        public async Task<IActionResult> Get()
        {
            var sqlQuery = "SELECT * FROM c";
            var result = await _jobRepository.Get(sqlQuery);
            return Ok(result);
        }
        [HttpGet("{JobId}/{partitionKey}")]
        public async Task<IActionResult> GetById(string JobId, string partitionKey)
        {
            try
            {
                var response = await _jobRepository.GetById(JobId, partitionKey);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPut]
        public async Task<IActionResult> UpdateJob(Job Job, string partitionKey)
        {
            try
            {
                var updateRes = await _jobRepository.UpdateJob(Job, partitionKey);
                return Ok(updateRes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete]
        public async Task<IActionResult> DeleteJob(string JobId, string partitionKey)
        {
            try
            {
                var response = await _jobRepository.DeleteJob(JobId, partitionKey);
                return Ok(response); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
