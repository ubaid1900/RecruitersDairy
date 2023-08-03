using Microsoft.AspNetCore.Mvc;
using RecruitmentsDiary.Models;
using System.Net;
 

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecruitmentsDiary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {

        List<Job> jobs = new List<Job>()
        {
            new Job()
            {
                JobID = 1, JobDescription ="First Job", JobLocation="Hyderabad",JobRequirements="C#,ASP.NET,SQL Server",JobContactPer="Mujahid Khan Mohammad",
                JobContactPhone = "9898989898",Client = "ABC", PayPeriod="Monthly", PayRange="10L-20L", CreatedBy="recruiter1@gmail.com", CreatedDate= new DateTime(),
                UpdatedBy="recruiter1@gmail.com",UpdatedDate=new DateTime()
            },
             new Job()
            {
                JobID = 2, JobDescription ="Secon Job", JobLocation="Pune",JobRequirements="java",JobContactPer="Ubaid",
                JobContactPhone = "908909890",Client = "ABC", PayPeriod="Monthly", PayRange="10L-20L", CreatedBy="recruiter1@gmail.com", CreatedDate= new DateTime(),
                UpdatedBy="recruiter1@gmail.com",UpdatedDate=new DateTime()
            },
              new Job()
            {
                JobID = 3, JobDescription ="Third Job", JobLocation="Delhi",JobRequirements="C#,ASP.NET,SQL Server",JobContactPer="Safi Mohammad",
                JobContactPhone = "4084095849",Client = "XYZ", PayPeriod="Monthly", PayRange="12L-24L", CreatedBy="recruiter2@gmail.com", CreatedDate= new DateTime(),
                UpdatedBy="recruiter2@gmail.com",UpdatedDate=new DateTime()
            },
               new Job()
            {
                JobID = 4, JobDescription ="Fourth Job", JobLocation="Kolkata",JobRequirements="C#,ASP.NET,SQL Server",JobContactPer="Mujahid Khan Mohammad",
                JobContactPhone = "9898989898",Client = "ABC", PayPeriod="Monthly", PayRange="10L-20L", CreatedBy="recruiter3@gmail.com", CreatedDate= new DateTime(),
                UpdatedBy="recruiter3@gmail.com",UpdatedDate=new DateTime()
            },
                new Job()
            {
                JobID = 5, JobDescription ="Fifth Job", JobLocation="Hyderabad",JobRequirements="Manager",JobContactPer="Ubaid",
                JobContactPhone = "0984084095",Client = "XYZ", PayPeriod="Monthly", PayRange="15L-20L", CreatedBy="recruiter3@gmail.com", CreatedDate= new DateTime(),
                UpdatedBy="recruiter3@gmail.com",UpdatedDate=new DateTime()
            },

        };


        // GET: api/<JobsController>
        [HttpGet]
        //public IEnumerable<string> GetJobs()
        //{
        //    return new string[] { "value1", "value2" };
        //}
        public List<Job> GetAllJobs()
        {
            return jobs;
        }

        // GET api/<JobsController>/5
        [HttpGet("{id}")]
        public ActionResult<Job> GetJob(int id)
        {
            //Return a single employee detail
           var job = jobs.FirstOrDefault(e => e.JobID == id);
            if (job == null)
            {
                return NotFound();
            }
            return job;
        }

        // POST api/<JobsController>
        [HttpPost]
        public void PostJob([FromBody] Job job)
        {
            jobs.Add(job);
        }

        // PUT api/<JobsController>/5
        [HttpPut("{id}")]
        public void PutJob(int id, [FromBody] Job job)
        {
           //Add implementation here 
        }

        // DELETE api/<JobsController>/5
        [HttpDelete("{id}")]
        public void DeleteJob(int id)
        {
        }
    }
}
