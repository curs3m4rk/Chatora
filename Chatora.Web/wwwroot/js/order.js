var dataTable;

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: "/order/GetAll" },
        "columns": [
            { data: 'orderHeaderId', "width": "5%" },
            { data: 'email', "width": "25%" }
        ]
    })
}