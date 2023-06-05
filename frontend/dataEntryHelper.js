function getSeedCandidates() {
    const candidate = {
        name: 'John Doe',
        phone: '1234567890',
        email: 'jdoe@gmail.com',
        address: '123 High street',
        status: 'Grooming',
        notes: 'Just Started'
    }
    return [candidate];
}
function getSeedJob() {
    const job = {
        jobid: -1,
        description: 'Software Engineer',
        client: 'TCS',
        requirements: '5 years of .NET, 5 years of javascript',
        location: 'Hyderabad',
        payRange: '10L-20L',
        candidates: getSeedCandidates()
    }
    return job;
}