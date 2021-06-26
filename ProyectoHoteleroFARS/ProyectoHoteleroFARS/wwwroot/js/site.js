// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
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

function aceptarModificarSobreNosotros() {
    parametros = { "sobreNosotros": document.getElementById('taSobreNosotros').value };
    $.ajax(
        {
            data: parametros,
            url: '/Administrador/modificarSobreNosotros',
            type: 'post',
            beforeSend: function () {
                var div = document.createElement('div');
                div.setAttribute('class', 'd-flex align-items-center justify-content-center');

                var divSpin = document.createElement('div');
                divSpin.setAttribute('class', 'spinner-grow text-primary');
                divSpin.setAttribute('style', 'width: 2em; height: 2em;');
                divSpin.setAttribute('role', 'status');

                var newSpan = document.createElement('strong');
                //newSpan.setAttribute('class', 'sr-only');
                newSpan.innerHTML = 'Guardando....';

                div.appendChild(divSpin);
                div.appendChild(newSpan);
                document.getElementById('respuestaSN').innerHTML = '';
                document.getElementById('respuestaSN').appendChild(div);
            }, //antes de enviar

            success: function (response) {
                document.getElementById('respuestaSN').innerHTML = '';
                if (response == 1) {
                    Swal.fire('Cambios guardados', '', 'success');
                } else {
                    Swal.fire('Cambios no guardados', '', 'error');
                }
            }
        }
    );
}