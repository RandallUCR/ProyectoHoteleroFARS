function modal(id, fecha, idRes, cedula, nombre, apellidos, email, tarjeta, trans, llegada, salida, tipo) {

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
                url: '/AdministradorReservas/EliminarReserva',
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