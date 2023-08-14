//using Microsoft.AspNetCore.Mvc;
//using RecruitersDairy.Models;
//using System.Net;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace RecruitersDairy.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class JobController : ControllerBase
//    {
//        List<Job> Jobs = new List<Job>()
//        {
//             new Job()
//            {
//                Id = 1, Description ="First Job", Location="Hyderabad",Requirements="C#,ASP.NET,SQL Server",ContactPer="Mujahid Khan Mohammad",
//                ContactPhone = "9898989898",Client = "ABC", PayPeriod="Monthly", PayRange="10L-20L", CreatedBy="recruiter1@gmail.com", Created= new DateTime(),
//                UpdatedBy="recruiter1@gmail.com",Updated=new DateTime()
//            },
//             new Job()
//            {
//                Id = 2, Description ="Second Job", Location="Pune",Requirements="java",ContactPer="Ubaid",
//                ContactPhone = "908909890",Client = "ABC", PayPeriod="Monthly", PayRange="10L-20L", CreatedBy="recruiter1@gmail.com", Created = new DateTime(),
//                UpdatedBy="recruiter1@gmail.com",Updated = new DateTime()
//            },
//              new Job()
//            {
//                Id = 3, Description ="Third Job", Location="Delhi",Requirements="C#,ASP.NET,SQL Server",ContactPer="Safi Mohammad",
//                ContactPhone = "4084095849",Client = "XYZ", PayPeriod="Monthly", PayRange="12L-24L", CreatedBy="recruiter2@gmail.com", Created = new DateTime(),
//                UpdatedBy="recruiter2@gmail.com",Updated = new DateTime()
//            },
//               new Job()
//            {
//                Id = 4, Description ="Fourth Job", Location="Kolkata",Requirements="C#,ASP.NET,SQL Server",ContactPer="Mujahid Khan Mohammad",
//                ContactPhone = "9898989898",Client = "ABC", PayPeriod="Monthly", PayRange="10L-20L", CreatedBy="recruiter3@gmail.com", Created= new DateTime(),
//                UpdatedBy="recruiter3@gmail.com",Updated=new DateTime()
//            },
//                new Job()
//            {
//                Id = 5, Description ="Fifth Job", Location="Hyderabad",Requirements="Manager",ContactPer="Ubaid",
//                ContactPhone = "0984084095",Client = "XYZ", PayPeriod="Monthly", PayRange="15L-20L", CreatedBy="recruiter3@gmail.com", Created = new DateTime(),
//                UpdatedBy="recruiter3@gmail.com",Updated =new DateTime()
//            },
//        };
//        // GET: api/<JobController>
//        [HttpGet]
//        public List<Job> GetAllJobs()
//        {
//            // return new string[] { "value1", "value2" };
//            return Jobs;
//        }

//        // GET api/<JobController>/5
//        [HttpGet("{id}")]
//        public ActionResult<Job> GetJob(int id)
//        {
//            // return "value";
//            var job = Jobs.FirstOrDefault(j => j.Id == id);
//            if (job == null)
//            {
//                return NotFound();
//            }
//            return job;
//        }
//        // GET api/<JobController>/5
//        [HttpGet("{id}")]
//        public IEnumerable<Job> GetJobSearch(int id)
//        {
//            // return "value";
//            IEnumerable<Job> job = Jobs.Where(j=> j.Id == id);
//            if (job == null)
//            {
//                return  Enumerable.Empty<Job>();
//            }
//            return job;
//        }

//        // POST api/<JobController>
//        [HttpPost]
//        public void PostJob([FromBody] Job job)
//        {
//            Jobs.Add(job);
//        }

//        // PUT api/<JobController>/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] string value)
//        {
//        }

//        // DELETE api/<JobController>/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//        }
//    }
//}
