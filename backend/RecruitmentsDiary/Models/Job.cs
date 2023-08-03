using Microsoft.AspNetCore.Routing.Matching;
using System.Security.Claims;

namespace RecruitmentsDiary.Models
{
    
    public class Job
    {
        public int JobID { get; set; }
        public string? JobDescription { get; set; }
        public string? Client { get; set; }
        public string? JobRequirements { get; set; }
        public string? JobLocation { get; set; }
        public string? PayRange { get; set; }
        public string? PayPeriod { get; set; }
        public string? JobContactPer { get; set; }
        public string? JobContactPhone { get; set; }
        public DateTime CreatedDate { get; set; }
       // public Recruiter[]? CreatedBy { get; set; }
       public string? CreatedBy { get; set; }
       public DateTime UpdatedDate { get; set; }
       // public Recruiter[]? UpdatedBy { get; set; }
       public string? UpdatedBy { get; set; }   
    }

    

//Recruiter/User Details
public class User
{
   // public int UserID { get; set; }
    //public string? FirstName { get; set; }
    //public string? LastName { get; set; }
    public string? Email { get; set; }
    public int RoleId { get; set; }
    public string? Password { get; set; }
   
    public string[] teamMember { get; set; }

}

public class Roles
{
    public int RoleId { get; set; }
    public string? RoleName { get; set; }//Team Lead, Manager, Recruiter, HR
}
//Candidate Details for Job
public class Candidates
    { 
        public string? name { get; set; }
        public string? address { get; set; }
        public int phone { get; set; }
        public string? email { get; set; }
        public Status[]? submissionStatus { get; set; } 
        public string? notes { get; set; } 
        public DateTime createdDate { get; set; }
        public string? createdBy { get; set; } 
        public string? updatedBy { get; set; }
    } 
    public class Status
    {
        public int StatusID { get; set; }
        public string? StatusName { get; set; }  //Active, InActive, OnHold, Technical Round, HR Round, BGC, Selected, Rejected
    }


}
