function getSeedCandidates() {
    const candidate = {
        name: 'John Doe',
        phone: '1234567890',
        email: 'jdoe@gmail.com',
        address: '123 High street',
        submissionStatus: 'Grooming',
        notes: 'Just Started'
    }
    return [candidate];
}

function getSeedJob() {
    const job = {
        jobid: -1,
        description: 'Software Engineer',
        client: 'TCS',
        jobRequirements: '5 years of .NET, 5 years of javascript',
        jobContactPer: 'Peter Hook',
        jobContactPhone: '9874751258',
        location: 'Hyderabad',
        payRange: '10L-20L',
        candidates: getSeedCandidates()
    }
    return job;
}