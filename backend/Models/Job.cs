//using Newtonsoft.Json;
using Microsoft.Azure.Cosmos;
using System.Text.Json;

namespace RecruitersDairy.Models
{
    public class Job
    {
        
        [JsonProperty("id")]
        public string? id { get; set; }
        public string? Description { get; set; }
        public string? Client { get; set; }
        public string? Requirements { get; set; }
        public string? Location { get; set; }
        public string? PayRange { get; set; }
        public string? PayPeriod { get; set; }
        public string? ContactPer { get; set; }
        public string? ContactPhone { get; set; }
        public DateTime Created { get; set; }
        // public Recruiter[]? CreatedBy { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        // public Recruiter[]? UpdatedBy { get; set; }
        public string? UpdatedBy { get; set; }

        public static implicit operator ItemResponse<object>(Job v)
        {
            throw new NotImplementedException();
        }
    }

    internal class JsonPropertyAttribute : Attribute
    {
        private string v;

        public JsonPropertyAttribute(string v)
        {
            this.v = v;
        }
    }



    //Recruiter/User Details
    public class User
    {
        public string? Email { get; set; }
        public int RoleId { get; set; }
        public string? Password { get; set; }
        public string[] TeamMember { get; set; }

    }

    public class Roles
    {
        public int Id { get; set; }
        public string? Name { get; set; }//Team Lead, Manager, Recruiter, HR
    }
    //Candidate Details for Job
    public class Candidates
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int Phone { get; set; }
        public string? Email { get; set; }
        public Status[]? SubmissionStatus { get; set; }
        public string? Notes { get; set; }
        public DateTime Created { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string? updatedBy { get; set; }
    }
    public class Status
    {
        public int ID { get; set; }
        public string? Name { get; set; }  //Active, InActive, OnHold, Technical Round, HR Round, BGC, Selected, Rejected
    }

}

