// Function that initialises a DataTable
function AddDataTable(table) {
    // The condition below only creates the DataTable when the Document Object Model is initialised
    $(document).ready(function () {
        $(table).DataTable();
    })
}

// Function to dispose of DataTable
function DataTablesDispose(table) {
    // The condition below only creates the DataTable when the Document Object Model is initialised
    // It also destroys the DataTable and removes its wrapper
    $(document).ready(function () {
        $(table).DataTable().destroy();
        var element = document.querySelector(table + '_wrapper');
        element.parentNode.removeChild(element);
    })
}

// Function to initialise a modified DataTable
function AddModifiedDataTable(table) {
    // The condition below only creates the DataTable when the Document Object Model is initialised
    $(document).ready(function () {
        $(table).DataTable({
            destroy: true,                                          // Destroys existing DataTable instances
            language: { search: "" },                               // Removes Default Search Label
            ordering: true,                                         // Allows the ordering of the table by clicking on header
            pageLength: 10,                                         // Sets the default page length to 10
            lengthChange: false,                                    // Disables changing of table length by the length module
            dom:"<'row'<'col-sm-12'tr>>" +                          // Edits the standard DataTable Layout
                "<'row'<'col-sm-5'i><'col-sm-5'p><'col-sm'f>>"
        });
    })
}