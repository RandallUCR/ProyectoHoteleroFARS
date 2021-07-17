function modalEditCaract(id, desc) {
    $('#idCaract').val(id);
    $('#desce').val(desc);

    $('#modalEditCaract').modal("show");
}

function modalInsCaract() {
    $('#modalInsCaract').modal("show");
}

$('#caractInsForm').submit(function (e) {
    e.preventDefault();
    var form = $(this);
    var url = form.attr('action');
    $.ajax({
        type: 'post',
        url: url,
        data: form.serialize(),
        success: function (response) {
            if (response.success == true) {
                window.location.href = response.url;

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

$('#caractModForm').submit(function (e) {
    e.preventDefault();
    var form = $(this);
    var url = form.attr('action');
    $.ajax({
        type: 'post',
        url: url,
        data: form.serialize(),
        success: function (response) {
            if (response.success == true) {
                window.location.href = response.url;

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

function EliminarCaract(id) {
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
                url: '/AdministradorCaracteristicas/Eliminar',
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
