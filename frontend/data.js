
function getDateForDaysAgo(howManyDaysAgo) {
  const dateDaysAgo = new Date(new Date().setDate(new Date().getDate() - howManyDaysAgo));
  return dateDaysAgo;
}

function setSeedData() {
  var seedData = [
    {
      "jobid": "1",
      "description": "software developer",
      "client": 'TCS',
      "requirements": '5 years of .NET, 5 years of javascript',
      "jobLocation": 'Hyderabad',
      "jobPayRange": '10L-20L',
      "payPeriod": "Yearly",
      "jobContactPer": 'Peter Hook',
      "jobContactPhone": '9874751258',
      "createdDate": getDateForDaysAgo(2),
      "updatedDate": getDateForDaysAgo(1),
      "candidates": [{
        "createdDate": getDateForDaysAgo(2),
        "updatedDate": getDateForDaysAgo(1),
        "name": "Jhon",
        "address": "Bangalore",
        "phone": "908779078",
        "email": "john@hotmail.com",
        "submissionStatusId": 1,
        "notes": "third round completed"
      },
      {
        "createdDate": new Date(),
        "updatedDate": new Date(),
        "name": "Mohd saleem",
        "address": "Banjara Hills Hyderabad",
        "phone": "06305397499",
        "email": "saleem@gmail.com",
        "submissionStatusId": 2,
        "notes": "Selected"
      },
      {
        "createdDate": new Date(),
        "updatedDate": new Date(),
        "name": "Ramchandra",
        "address": "Chanda Nagar",
        "phone": "98342132",
        "email": "ram@gmail.com",
        "submissionStatusId": 3,
        "notes": "waiting for Hr round"
      }]
    },
    {
      "jobid": "2",
      "description": "Tech support",
      "client": 'TCS',
      "requirements": '3 years of experience in a similar role',
      "jobLocation": 'Hyderabad',
      "jobPayRange": '10K-20K',
      "payPeriod": "Monthly",
      "jobContactPer": 'Peter Hook',
      "jobContactPhone": '9874751258',
      "createdDate": new Date(),
      "updatedDate": new Date(),
      "candidates": [{
        "createdDate": new Date(),
        "updatedDate": new Date(),
        "name": "Russel",
        "address": "Bangalore",
        "phone": "568999910",
        "email": "russ@gmail.com",
        "submissionStatusId": 4,
        "notes": "negotiation in HR round"
      },
      {
        "createdDate": new Date(),
        "updatedDate": new Date(),
        "name": "Chandra Shaker",
        "address": "ORR Hyderabad",
        "phone": "987663663",
        "email": "shaker@hotmail.com",
        "submissionStatusId": 1,
        "notes": "waiting for offer letter"
      },
      {
        "createdDate": new Date(),
        "updatedDate": new Date(),
        "name": "Abdul Rahman",
        "address": "Akber bagh Hyderabad",
        "phone": "98457383",
        "email": "abdul@yahoo.com",
        "submissionStatusId": 2,
        "notes": "selected"
      },
      {
        "createdDate": new Date(),
        "updatedDate": new Date(),
        "name": "kaleem",
        "address": "Wahed Nager, Hyderabad ",
        "phone": "87634343",
        "email": "kal@gamil.com",
        "submissionStatusId": 3,
        "notes": "HR round schdulded"
      },
      {
        "createdDate": new Date(),
        "updatedDate": new Date(),
        "name": "Sri laxmi",
        "address": "Ramu Nagar Hyderabad",
        "phone": "98677381",
        "email": "laxmi@yahoo.com",
        "submissionStatusId": 3,
        "notes": "Fresher first round completed."
      },
      {
        "createdDate": new Date(),
        "updatedDate": new Date(),
        "name": "Samuel",
        "address": "Banglore",
        "phone": "78883354",
        "email": "sam@gmail.com",
        "submissionStatusId": 3,
        "notes": "three rounds completed"
      }]
    },
    {
      "jobid": "3",
      "description": "Networking",
      "client": 'Infosys',
      "requirements": '3 years of experience in a similar role',
      "jobLocation": 'Hyderabad',
      "jobPayRange": '10K-20K',
      "payPeriod": "Monthly",
      "jobContactPer": 'Peter Hook',
      "jobContactPhone": '9874751258',
      "createdDate": new Date(),
      "updatedDate": new Date(),
      "candidates": [{
        "createdDate": new Date(),
        "updatedDate": new Date(),
        "name": "Srichaitanya",
        "address": "Dilsukh Nagar",
        "phone": "98747774",
        "email": "sri@gmail.com",
        "submissionStatusId": 1,
        "notes": "waiting for HR round"
      },
      {
        "createdDate": new Date(),
        "updatedDate": new Date(),
        "name": "Abdul shah",
        "address": "Amberpet Hyderabad",
        "phone": "98474774",
        "email": "shah@yahoo.com",
        "submissionStatusId": 2,
        "notes": "waiting for response"
      },
      {
        "createdDate": new Date(),
        "updatedDate": new Date(),
        "name": "Ramulu",
        "address": "Chanda Nagar Hyderabad",
        "phone": "987878343",
        "email": "ram@hotmail.com",
        "submissionStatusId": 1,
        "notes": "Looks promising"
      }]
    },
    {
      "jobid": "4",
      "description": "Finance",
      "client": 'TCS',
      "requirements": '3 years of experience in a similar role',
      "jobLocation": 'Hyderabad',
      "jobPayRange": '10K-20K',
      "payPeriod": "Monthly",
      "jobContactPer": 'Peter Hook',
      "jobContactPhone": '9874751258',
      "createdDate": new Date(),
      "updatedDate": new Date(),
      "candidates": [{
        "createdDate": new Date(),
        "updatedDate": new Date(),
        "name": "Ibrahim",
        "address": "Mothi Nagar",
        "phone": "89334433",
        "email": "shan@yahoo.com",
        "submissionStatusId": 1,
        "notes": "waiting of offer letter"
      },
      {
        "createdDate": new Date(),
        "updatedDate": new Date(),
        "name": "Abdul Asad",
        "address": "Banglore",
        "phone": "23423432",
        "email": "asad@yahoo.com",
        "submissionStatusId": 1,
        "notes": "Appointed"
      }]
    },
    {
      "jobid": "5",
      "description": "Front End",
      "client": 'TCS',
      "requirements": '3 years of experience in a similar role',
      "jobLocation": 'Hyderabad',
      "jobPayRange": '10K-20K',
      "payPeriod": "Monthly",
      "jobContactPer": 'Peter Hook',
      "jobContactPhone": '9874751258',
      "createdDate": new Date(),
      "updatedDate": new Date(),
      "candidates": [{
        "createdDate": new Date(),
        "updatedDate": new Date(),
        "name": "Mohd Arif",
        "address": "Banglore",
        "phone": "23423453",
        "email": "arif@hotmai.com",
        "submissionStatusId": 1,
        "notes": "waiting of HR round"
      },
      {
        "createdDate": new Date(),
        "updatedDate": new Date(),
        "name": "Sahik Mohammed",
        "address": "Lic colony",
        "phone": "234523423",
        "email": "mohammed@gamil.com",
        "submissionStatusId": 1,
        "notes": "three rounds completed"
      },
      {
        "createdDate": new Date(),
        "updatedDate": new Date(),
        "name": "Salman",
        "address": "Amberpet",
        "phone": "2324123",
        "email": "Salman@gmail.com",
        "submissionStatusId": 1,
        "notes": "waiting for ineterview"
      }]
    },
    {
      "jobid": "6",
      "description": "Administration",
      "client": 'TCS',
      "requirements": '3 years of experience in a similar role',
      "jobLocation": 'Hyderabad',
      "jobPayRange": '10K-20K',
      "payPeriod": "Monthly",
      "jobContactPer": 'Peter Hook',
      "jobContactPhone": '9874751258',
      "createdDate": getDateForDaysAgo(2),
      "updatedDate": getDateForDaysAgo(1),
      "candidates": [{
        "createdDate": getDateForDaysAgo(2),
        "updatedDate": getDateForDaysAgo(1),
        "name": "Swamy",
        "address": "Delhi",
        "phone": "2432343",
        "email": "sham@gmail.com",
        "submissionStatusId": 5,
        "notes": "Appointed"
      }]
    }];
  localStorage.setItem("jobs", JSON.stringify(seedData))
}

function getSeedUsers() {
  return [
    { email: 'recruiter1@gmail.com', password: 'qwert1234', roleId: 1 },
    { email: 'recruiter2@gmail.com', password: 'qwert1234', roleId: 1 },
    { email: 'recruiter3@gmail.com', password: 'qwert1234', roleId: 1 },
    {
      email: 'teamlead1@gmail.com', password: 'qwert1234', roleId: 2
      , teamMembers: ['recruiter1@gmail.com', 'recruiter2@gmail.com']
    },
    {
      email: 'teamlead2@gmail.com', password: 'qwert1234', roleId: 2
      , teamMembers: ['recruiter3@gmail.com']
    },
    { email: 'manager1@gmail.com', password: 'qwert1234', roleId: 3 },
  ];
}

function getRoles() {
  return [
    { id: 1, Description: 'Recruiter' },
    { id: 2, Description: 'Team Leader' },
    { id: 3, Description: 'Manager' },
  ];
}

function getRoleById(roleId) {
  return getRoles().find(r => r.id === roleId);
}

