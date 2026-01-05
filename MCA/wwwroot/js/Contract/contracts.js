//$("#td").css("color", "blue");

$(document).ready(function () {
    $.ajax({
        url: '/Contract/GetContracts',  
        type: 'GET',
        dataType: 'json',
        success: function (response) {
            let tbody = $("table tbody");
            tbody.empty();

            $.each(response, function (index, contract) {
                let row = `
                    <tr>
                        <td>${contract.contractID}</td>
                        <td>${contract.merchantName}</td>
                        <td>${contract.merchantBusinessName}</td>
                        <td>${contract.syndicate}</td>
                        <td>${contract.iso}</td>
                        <td>₹${contract.fundsAdvance}</td>
                    </tr>
                `;
                tbody.append(row);
            });
        },
        error: function () {
            alert("Failed to load contracts");
        }
    });
})