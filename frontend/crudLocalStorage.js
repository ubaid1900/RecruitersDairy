function getJobs() {
    const jobs = JSON.parse(localStorage.getItem("jobs"));
    if (!jobs) {
        jobs = [];
    }
    return jobs;
}
function getjob(id) {
    if (id != 0 && id != null) {
        const jobs = JSON.parse(localStorage.getItem("jobs"));
        if (!jobs) {
            jobs = [];
            return null;
        }
    }
    jobs.forEach(e => {
        if (e.jobid == id) {
            return e
        }
    });

}

function addJob(job) {
    if (!job) {
        return;
    }

    const ObjectJob = { updatedDate: Date() };

    ObjectJob.jobId = job.jobid;
    ObjectJob.description = job.jobDescription;
    ObjectJob.JobRequirements = job.jobRequirements;
    ObjectJob.jobLocation = job.jobLocation;
    ObjectJob.jobPayRange1 = job.jobPayRange1;
    ObjectJob.jobPayRange2 = job.jobPayRange2;
    ObjectJob.jobContactPer = job.jobContactPer;
    ObjectJob.jobContactPhone = job.jobContactPhone;
    ObjectJob.createdDate = job.createdDate;
    ObjectJob.createdBy = job.createdBy;

    const candidates = [];
    job.candidates.forEach(f => {
        for (let i = 0; i < f.length; i++) {
            const candidate = candidates[i];
            const objectCandidate = { updatedDate: Date() };
            objectCandidate.name = f.name;
            objectCandidate.address = f.address;
            objectCandidate.phone = f.phone;
            objectCandidate.email = f.email;
            objectCandidate.submissionStatusId = f.submissionStatusId;
            objectCandidate.notes = f.notes;
            candidate.push(objectCandidate);
            ObjectJob.candidates = candidate;
        }
    })
    localStorage.setItem('jobs1', JSON.stringify(jobs));
}


