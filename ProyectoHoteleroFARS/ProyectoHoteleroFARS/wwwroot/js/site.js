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


function modal(id,fecha, idRes, cedula,nombre, apellidos, email, tarjeta, trans, llegada, salida, tipo) {

    $('#id').val(id);
    $('#fecha').val(fecha);
    $('#id_res').val(idRes);
    $('#cedula').val(cedula);
    $('#nombre').val(nombre);
    $('#apellidos').val(apellidos);
    $('#email').val(email);
    $('#tarjeta').val(tarjeta);
    $('#trans').val(trans);
    $('#rangofechas').val(llegada + " - " + salida);
    $("#tipo").val(tipo).change();


    $('#modalEdit').modal("show");
}

$('#resModForm').submit(function (e) {
    e.preventDefault();
    var form = $(this);
    var url = form.attr('action');
    $.ajax({
        type: 'post',
        url: url,
        data: form.serialize(),
        success: function (response) {
            if (response.success == true) {
                if (response.inserted == true) {
                    window.location.href = response.url;
                } else {
                    Swal.fire({
                        position: 'center',
                        icon: 'error',
                        title: 'Sin habitaciones disponibles.',
                        showConfirmButton: false,
                        timer: 1500
                    });
                }
            } else {
                Swal.fire({
                    position: 'center',
                    icon: 'error',
                    title: 'Error en el sistema.',
                    showConfirmButton: false,
                    timer: 1500
                });
            }
        },
        error: function (response) {
            Swal.fire({
                position: 'center',
                icon: 'error',
                title: 'Error en el sistema.',
                showConfirmButton: false,
                timer: 1500
            });
        }
    });
});


function EliminarReserva(id) {
    Swal.fire({
        title: '¿Seguro?',
        text: 'No se podrán revertir los cambios',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonText: 'Si, eliminar',
        cancelButtonText: 'Cancelar'
    }).then((result) => {
        if (result.value) {
            // Proceso de eliminacion de datos
            var data = { id: id }
            $.ajax({
                url: '/Administrador/EliminarReserva',
                type: 'POST',
                data: data,
                success: function (response) {
                    if (response.success == true) {
                        window.location.href = response.url;
                    } else {
                        Swal.fire({
                            position: 'center',
                            icon: 'error',
                            title: 'Error al eliminar.',
                            showConfirmButton: false,
                            timer: 1500
                        });
                    }
                },
                error: function (response) {
                    Swal.fire({
                        position: 'center',
                        icon: 'error',
                        title: 'Error en el sistema.',
                        showConfirmButton: false,
                        timer: 1500
                    });
                }
            });
        }
    })
}

function InsertarReserva() {
    $('#modalInsert').modal("show");
}

$('#resInsForm').submit(function (e) {
    e.preventDefault();
    var form = $(this);
    var url = form.attr('action');
    $.ajax({
        type: 'post',
        url: url,
        data: form.serialize(),
        success: function (response) {
            if (response.success == true) {
                if (response.inserted == true) {
                    window.location.href = response.url;
                } else {
                    Swal.fire({
                        position: 'center',
                        icon: 'error',
                        title: 'Sin habitaciones disponibles.',
                        showConfirmButton: false,
                        timer: 1500
                    });
                }
            } else {
                Swal.fire({
                    position: 'center',
                    icon: 'error',
                    title: 'Error en el sistema.',
                    showConfirmButton: false,
                    timer: 1500
                });
            }
        },
        error: function (response) {
            Swal.fire({
                position: 'center',
                icon: 'error',
                title: 'Error en el sistema.',
                showConfirmButton: false,
                timer: 1500
            });
        }
    });
});

$('#sugForm').submit(function (e) {
    e.preventDefault();
    var form = $(this);
    var url = form.attr('action');
    $.ajax({
        type: 'post',
        url: url,
        data: form.serialize(),
        success: function (response) {
            if (response.success == true) {
                Swal.fire({
                    position: 'center',
                    icon: 'success',
                    title: 'Sugerencia enviada.',
                    showConfirmButton: false,
                    timer: 1500
                });
            } else {
                Swal.fire({
                    position: 'center',
                    icon: 'error',
                    title: 'Error al enviar.',
                    showConfirmButton: false,
                    timer: 1500
                });
            }
            $('#sug').val('');
        },
        error: function (response) {
            Swal.fire({
                position: 'center',
                icon: 'error',
                title: 'Error en el sistema.',
                showConfirmButton: false,
                timer: 1500
            });
        }
    });
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