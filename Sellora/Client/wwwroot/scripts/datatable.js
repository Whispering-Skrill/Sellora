function AddDataTable(table) {
    $(document).ready(function () {
        $(table).DataTable();
    })
}

function DataTablesDispose(table) {
    $(document).ready(function () {
        $(table).DataTable().destroy();
        var element = document.querySelector(table + '_wrapper');
        element.parentNode.removeChild(element);
    })
}

function AddModifiedDataTable(table) {
    $(document).ready(function () {
        $(table).DataTable({
            destroy: true,
            language: { search: "" },
            ordering: true,
            pageLength: 10,
            lengthChange: false,
            dom:"<'row'<'col-sm-12'tr>>" +
                "<'row'<'col-sm-5'i><'col-sm-5'p><'col-sm'f>>"
        });
    })
}