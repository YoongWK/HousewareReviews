function AddDataTable(table, text="Search") {
    $(document).ready(function () {
        if ($.fn.dataTable.isDataTable(table)) {
            $(table).DataTable().destroy();
            var element = document.querySelector(table + '_wrapper');
            element.parentNode.removeChild(element);
        }

        $(table).DataTable({
            "dom": 'ft<"d-flex justify-content-between align-items-center"ip>',
            "language": {
                "search": "",
                "searchPlaceholder": text
            },
            drawCallback: function () {
                $('.dataTables_paginate ul li a').addClass('shadow-none');
                if (!$('.dataTables_paginate ul li a').prop('disabled')) {
                    $('.dataTables_paginate ul li a').css('cursor', 'pointer');
                };
            },
            initComplete: function () {
                $('.dataTables_filter label').addClass('w-100');
                $('.dataTables_filter input').addClass('bg-transparent border-0 shadow-none m-0 p-0 w-100 pe-2 search-box');
                $('.dataTables_paginate ul').addClass('m-0');
                $('.dataTables_info').addClass("p-0");
                $('.dataTables_info').css('font-size', '0.9rem');

                $('.dataTables_filter input').wrap('<div class="search-wrapper d-flex align-items-center bg-white rounded-2 mt-3" style="color:var(--darkgray);"></div>');
                $('.search-wrapper').prepend('<span class="oi oi-magnifying-glass bg-transparent h-100 px-2" style="cursor:text;"></span>');
                $('.dataTables_filter span').on('click', function () {
                    $('.dataTables_filter input').focus();
                });
            }
        });
    })
}
function DataTablesDispose(table) {
    $(document).ready(function () {
        $(table).DataTable().destroy();
        var element = document.querySelector(table + '_wrapper');
        element.parentNode.removeChild(element);
    })
}