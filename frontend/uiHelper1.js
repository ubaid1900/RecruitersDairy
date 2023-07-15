function getPayPeriod(selectedId) {
    // var divpay = document.getElementById("payPeriod");
    // var payPeriodLbl = document.createElement("label");
    // payPeriodLbl.innerText = "Pay Period";
    const selectElement = document.createElement('select');
    selectElement.setAttribute("id", "payPeriodId");
    selectElement.setAttribute('title', 'Please select a PayType');

    // divpay.appendChild(payPeriodLbl);
    // divpay.appendChild(selectElement);
    
    const options = getPayPeriodOptions();
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

function getPayPeriodOptions() {
    return [
        {
            id: 1, text: 'Monthly'
        },
        {
            id: 2, text: 'Yearly'
        }

    ];
}
