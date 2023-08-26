using Microsoft.AspNetCore.Mvc;
using RecruitersDairy.Models;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecruitersDairy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        List<Job> Jobs = new List<Job>()
        {
            
        };
        // GET: api/<JobController>
        [HttpGet]
        public List<Job> GetAllJobs()
        {
            // return new string[] { "value1", "value2" };
            return Jobs;
        }

        // GET api/<JobController>/5
        [HttpGet("{id}")]
        public ActionResult<Job> GetJob(int id)
        {
            // return "value";
            var job = Jobs.FirstOrDefault(j => Convert.ToInt32(j.id) == id);
            if (job == null)
            {
                return NotFound();
            }
            return job;
        }
        // GET api/<JobController>/5
        [HttpGet("{id}")]
        public IEnumerable<Job> GetJobSearch(int id)
        {
            // return "value";
            IEnumerable<Job> job = Jobs.Where(j => Convert.ToInt32(j.id) == id);
            if (job == null)
            {
                return Enumerable.Empty<Job>();
            }
            return job;
        }

        // POST api/<JobController>
        [HttpPost]
        public void PostJob([FromBody] Job job)
        {
            Jobs.Add(job);
        }

        // PUT api/<JobController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<JobController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
