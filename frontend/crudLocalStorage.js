function getJobs() {
    const jobs = JSON.parse(localStorage.getItem("jobs"));
    if (!jobs) {
        return null;
    }
    return jobs;
}
function getjob(id) {
    if (id != 0 && id != null) {
        const jobs = JSON.parse(localStorage.getItem("jobs"));
        if (!jobs) {
            return null;
        }
    }
    jobs.forEach(e => {
        if (e.jobid == id) {
            return e;
        }
    });

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
    const jobs = JSON.parse(localStorage.getItem("jobs"));
    if (!jobs) {
        return null;
    }
    var jobIndex = jobs.findIndex(e => {
        if (e.jobid == id) {
            return e.jobid;
        }
    })
    jobs.splice(jobIndex, 1, job)

    localStorage.setItem('jobs', JSON.stringify(jobs));
}

function deleteJob(id) {

    const jobs = JSON.parse(localStorage.getItem("jobs"));
    if (!jobs) {
        return null;
    }
    var jobIndex = jobs.findIndex(e => {
        if (e.jobid == id) {
            return e.jobid;
        }
    })
    jobs.splice(jobIndex, 1);
    localStorage.setItem('jobs', JSON.stringify(jobs));

}
