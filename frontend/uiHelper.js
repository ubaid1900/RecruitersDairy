function getSubmissionStatusSelect(selectedId) {
    const selectElement = document.createElement('select');
    const options = getSubmissionStatuses();
    for (let index = 0; index < options.length; index++) {
        const element = options[index];
        const optionElement = document.createElement('option');
        optionElement.value = element.id; optionElement.text = element.text;
        if (element.id === selectedId) {
            optionElement.selected = true;
        }
        selectElement.append(optionElement);
    }
    return selectElement;
}

function getSubmissionStatuses() {
    return [
        {
            id: 1, text: 'Groomed'
        },
        {
            id: 2, text: 'Interview Scheduled'
        },
        {
            id: 3, text: 'Interviewed'
        },
        {
            id: 4, text: 'Accepted'
        },
        {
            id: 5, text: 'Rejected'
        },
    ];
}