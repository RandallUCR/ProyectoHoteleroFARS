﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var start = moment().add(1, 'days');
var end = moment().add(2, 'days');

$('input[name="rangofechas"]').daterangepicker({
    startDate: start,
    endDate: end,
    minDate: start,
    locale: {
        format: 'YYYY-MM-DD'
    }
});

$('input[name="rangofechas"]').on('apply.daterangepicker', function (ev, picker) {
    var uno = picker.startDate.format('YYYY-MM-DD');
    var dos = picker.endDate.format('YYYY-MM-DD');

    var ver = moment(uno).isSame(dos);

    if (ver) {
        picker.setEndDate(moment(uno).add(1, 'days'));
    } 
});

$('input[name="rangofechasNo"]').daterangepicker({
    startDate: start,
    endDate: end,
    locale: {
        format: 'YYYY-MM-DD'
    }
});

$('input[name="rangofechasNo"]').on('apply.daterangepicker', function (ev, picker) {
    var uno = picker.startDate.format('YYYY-MM-DD');
    var dos = picker.endDate.format('YYYY-MM-DD');

    var ver = moment(uno).isSame(dos);

    if (ver) {
        picker.setEndDate(moment(uno).add(1, 'days'));
    }
});

$('#example2').DataTable({
    "lengthChange": false,
    "searching": false,
    "lengthMenu": [5],
    "ordering": false,
    "language": {
        "infoEmpty": "No hay registros disponibles",
        "info": "Mostrando página _PAGE_ de _PAGES_",
        "oPaginate": {
            "sNext": "Siguiente",
            "sPrevious": "Anterior"
        }
    }
});

$('#example1').DataTable({
    "lengthChange": false,
    "searching": false,
    "lengthMenu": [7],
    "ordering": false,
    "language": {
        "infoEmpty": "No hay registros disponibles",
        "info": "Mostrando página _PAGE_ de _PAGES_",
        "oPaginate": {
            "sNext": "Siguiente",
            "sPrevious": "Anterior"
        }
    }
});
