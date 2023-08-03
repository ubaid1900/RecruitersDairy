//Save Applied Jobs
public class RecruitmentsRepository
{
   public Job[] Jobs {get; set;}
   public Candidates[] Candidate{get; set;}  
   public Status[] Status {get; set;}
   public string Notes {get; set;}
   public Candidate[] AppliedBy {get; set;}
   public DateTime AppliedDate {get; set;}
   public DateTime Created {get; set;}
   public Recruiter[] CreatedBy {get; set;}
   public DateTime Updated {get; set;}
   public Recruiter[] UpdatedBy { get; set;}
}

//Jobs Master List
public class Job
    {
        public int JobID { get; set; }
        public string JobDescription { get; set; } 
        public string Client { get; set; }
        public string JobRequirements { get; set; }
        public String JobContactPerson { get; set; }
        public String JobContactPhoneNumber { get; set; }
        public String JobLocation { get; set; }
        public String PayRange { get; set; }  
        public DateTime Created { get; set; }
        public Recruiter[] CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public Recruiter[] UpdatedBy { get; set; }  
    }

//Candidates profile
public Class Candidates
{
public int CandidateID {get; set;}
public string FirstName {get; set;}
public string LastName { get; set;}
public string CandidateEmail {get; set;}
public int ContactNumber {get; set;}
public CandidateAddress Address {get; set;}
}
//CandidateAddress
public Class CandidateAddress 
{
  public string Street {get; set;}
  public string city {get; set;}
  public string Country { get; set;}
  public string PinCode {get; set;}
}

//Recruiter Details
public class Recruiter
{
  public int RecruiterID { get; set;}
  public string FirstName {get; set;}
  public string LastName { get; set;}
  public string Email {get; set;}
  public Roles[] Role { get; set;}
  public string Password {get; set;} 
}

public class Roles
{
 public int RoleID { get; set;}
 public string RoleName {get; set;}//Team Lead, Manager, Recruiter, HR
}


public class Status
{
 public int StatusID { get; set;}
 public string StatusName {get; set;}  //Active, InActive, OnHold, Technical Round, HR Round, BGC, Selected, Rejected
}
