using Microsoft.AspNetCore.Mvc;
using RecruitmentsDiary.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecruitmentsDiary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        List<User> users = new List<User>()
        {
            new User()
            {
                Email="recruiter1@gmail.com", RoleId = 1, Password="Test123"
            },
            new User()
            {
                Email="recruiter2@gmail.com", RoleId = 1, Password="Test123"
            },
            new User()
            {
                Email="recruiter3@gmail.com", RoleId = 1, Password="Test123"
            },
             new User()
            {
                Email="recruiter4@gmail.com", RoleId = 1, Password="Test123"
            },

            new User()
            {
                Email="teamlead2@gmail.com",RoleId=2,Password="Test123"
            },

             new User()
            {
                Email="manager1@gmail.com",RoleId=3,Password="Test123"
            }
        };


        // GET: api/<UserController>
        [HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
        public List<User> GetAllUsers()
        {
            return users;
        }
        // GET api/<UserController>/5
        //[HttpGet("{id}")]
        //public ActionResult<User> GetUserwithRoleId(int id)
        //{
        //    var user = users.FirstOrDefault(e => e.RoleId == id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }
        //    return user;
        //}
        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IEnumerable<User> GetAllUserswithRoleId(int id)
        {
            IEnumerable<User> userMatched = users.Where(el => el.RoleId == id);
            if(userMatched == null)
            {
                return Enumerable.Empty<User>();
            }
            return userMatched;
        }
        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
