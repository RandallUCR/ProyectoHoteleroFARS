function irTipo() {
    var id = $('#tipoHabi').val();
    var data = {id : id}
    $.ajax({
        type: 'post',
        url: '/AdministradorHabitaciones/irTipo',
        data: data,
        success: function (response) {
            window.location.href = response.url;
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

function modalInsTipo() {
    $('#modalInsertTipo').modal("show");
}

function modalInsHabi() {
    $('#modalInsertHabi').modal("show");
}

function modalEditHabi(id, num, estado) {
    $('#idhabi').val(id);
    $('#nume').val(num);
    if (estado == 'True') {
        $('#estadoe').attr('checked', true);
    } else {
        $('#estadoe').attr('checked', false);
    }

    $('#modalEditHabi').modal("show");
}

$('#insHabiForm').submit(function (e) {
    e.preventDefault();
    var form = $(this);
    var url = form.attr('action');
    var data = { num: $('#num').val(), estado: $('#estado').prop('checked') }

    $.ajax({
        type: 'post',
        url: url,
        data: data,
        success: function (response) {
            if (response.success == true) {
                if (response.inserted == true) {
                    window.location.href = response.url;
                } else {
                    Swal.fire({
                        position: 'center',
                        icon: 'error',
                        title: 'Ya existe una habitación con ese número',
                        showConfirmButton: false,
                        timer: 1500
                    });
                }
            } else {
                Swal.fire({
                    position: 'center',
                    icon: 'error',
                    title: 'Error en el sistema',
                    showConfirmButton: false,
                    timer: 1500
                });
            }

        }, error: function (response) {
            Swal.fire({
                position: 'center',
                icon: 'error',
                title: 'Error en el sistema',
                showConfirmButton: false,
                timer: 1500
            });
        }
    });

});

$('#editHabiForm').submit(function (e) {
    e.preventDefault();
    var form = $(this);
    var url = form.attr('action');
    var data = { num: $('#nume').val(), estado: $('#estadoe').prop('checked'), id: $('#idhabi').val() }

    $.ajax({
        type: 'post',
        url: url,
        data: data,
        success: function (response) {
            if (response.success == true) {
                if (response.inserted == true) {
                    window.location.href = response.url;
                } else {
                    Swal.fire({
                        position: 'center',
                        icon: 'error',
                        title: 'Ya existe una habitación con ese número',
                        showConfirmButton: false,
                        timer: 1500
                    });
                }
            } else {
                Swal.fire({
                    position: 'center',
                    icon: 'error',
                    title: 'Error en el sistema',
                    showConfirmButton: false,
                    timer: 1500
                });
            }

        }, error: function (response) {
            Swal.fire({
                position: 'center',
                icon: 'error',
                title: 'Error en el sistema',
                showConfirmButton: false,
                timer: 1500
            });
        }
    });

});

function eliminarTipo(id) {
    alert(id);
}

function eliminarHabi(id) {

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

    var data = { id : id}

    $.ajax({
        type: 'post',
        url: '/AdministradorHabitaciones/eliminarHabitacion',
        data: data,
        success: function (response) {
            if (response.success == true) {
                if (response.inserted == true) {
                    window.location.href = response.url;
                } else {
                    Swal.fire({
                        position: 'center',
                        icon: 'error',
                        title: 'Imposible, hay reservas con esta habitación',
                        showConfirmButton: false,
                        timer: 1500
                    });
                }
            } else {
                Swal.fire({
                    position: 'center',
                    icon: 'error',
                    title: 'Error en el sistema',
                    showConfirmButton: false,
                    timer: 1500
                });
            }

        }, error: function (response) {
            Swal.fire({
                position: 'center',
                icon: 'error',
                title: 'Error en el sistema',
                showConfirmButton: false,
                timer: 1500
            });
        }
    });

        }
    })
}

