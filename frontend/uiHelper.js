function getSubmissionStatusSelect(selectedId, elementId) {
    const selectElement = document.createElement('select');
    selectElement.setAttribute("id","selectElementId");
    selectElement.setAttribute("class","ui selection dropdown");
    selectElement.setAttribute('title', 'Please select a submission status');
    
    if (elementId) {
        selectElement.setAttribute('name', elementId);
        selectElement.setAttribute('id', elementId);
    }
    const options = getSubmissionStatuses();
    for (let index = 0; index < options.length; index++) {
        const element = options[index];
        const optionElement = document.createElement('option');
        optionElement.setAttribute("class","item");
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

function getDateDisplay(date) {
    if (!date.toDateString) {
        return '';
    }
    return `${date.toDateString()} ${date.toLocaleTimeString()}`;
}

function createTd(text) {
    const tdVar = document.createElement("td");
    const textVar = document.createTextNode(text);
    tdVar.appendChild(textVar);
    return tdVar;
}