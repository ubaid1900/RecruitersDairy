function getJobs() {
    let jobs = JSON.parse(localStorage.getItem("jobs"));
    if (!jobs) {
        return jobs=[];
    }
    return jobs;
}
function getJob(id) {
    let jobs = JSON.parse(localStorage.getItem("jobs"));
    if (id != 0 && id != null) {
        if (!jobs) {
            return jobs=[];
        }
    }
    let job;
     job=jobs.find(e => {
     return e.jobid == id;
        
    });
    return job;

}

function addJob(job) {
    if (!job) {
        return;
    }
    let jobs = JSON.parse(localStorage.getItem("jobs"));
    if (jobs) {
        jobs.push(job);
    }
    else {
        jobs = [];
        jobs.push(job);
    }
    localStorage.setItem('jobs', JSON.stringify(jobs));
}

function updateJob(id, job) {
    let jobs = JSON.parse(localStorage.getItem("jobs"));
    if (!jobs) {
        return jobs=[];
    }
    var jobIndex = jobs.foreach(e => {
        if (e.jobid == id) {
            return e.jobid;
        }
    })
    jobs[jobIndex]= job;

    localStorage.setItem('jobs', JSON.stringify(jobs));
}

function deleteJob(id) {

    let jobs = getJobs();
    if (!jobs) {
        return jobs=[];
    }
    var jobIndex = jobs.findIndex(e => {
        if (e.jobid == id) {
            return e.jobid;
        }
    })
    jobs.splice(jobIndex, 1);
    localStorage.setItem('jobs', JSON.stringify(jobs));

}

function setJobs(jobs) {
    localStorage.setItem('jobs', JSON.stringify(jobs));
}
