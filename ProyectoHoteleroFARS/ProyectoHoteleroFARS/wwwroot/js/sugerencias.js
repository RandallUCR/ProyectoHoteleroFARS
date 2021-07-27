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


function eliminarSugerencia(button) {
    Swal.fire({
        title: '¿Desea eliminar la sugerencia seleccionada?',
        showDenyButton: true,
        confirmButtonText: 'Eliminar',
        denyButtonText: 'Cancelar',
    }).then((result) => {
        if (result.isConfirmed) {
            parametros = { "id": button.id };
            $.ajax(
                {
                    data: parametros,
                    url: '/AdministradorSugerencias/eliminarSugerencia',
                    type: 'post',
                    beforeSend: function () {}, //antes de enviar

                    success: function (response) {
                        if (response == 1) {
                            actualizarTablaSugerencia();
                            Swal.fire('Sugerencia eliminada', '', 'success');
                        } else {
                            Swal.fire('Error al eliminar la sugerencia', '', 'error');
                        }
                    }
                }
            );
        } else if (result.isDenied) {
            Swal.fire('Acción cancelada', '', 'info')
        }
    });
}

function actualizarTablaSugerencia() {
    $.ajax(
        {
            url: '/AdministradorSugerencias/actualizarTablaSugerencias',
            type: 'post',
            beforeSend: function () { }, //antes de enviar
            success: function (response) {
                var lista = JSON.parse(response.resultado);

                $('#contenidoTablaSugerencias tr').remove(); //destruimos toda la tabla

                for (var x = 0; x < lista.length; x++) {
                    var info = '<tr> <th scope="row">' + lista[x].TN_Id + '</th>' +
                        '<td> <span>' + lista[x].TC_Sugerencia + '</span> </td>' +
                        '<td> <span>' + lista[x].TF_Fecha + '</span> </td >' + 
                        '<td> <button class="btn btn-danger" id="' + lista[x].TN_Id + '" onclick="eliminarSugerencia(this)">Eliminar</button></td></tr>';

                    document.getElementById('contenidoTablaSugerencias').innerHTML += info;
                }

            },
            error: function () {
                Swal.fire({
                    icon: 'error',
                    title: 'Error inesperado',
                    text: 'Ocurrió un error al actualizar la tabla, recargue la página'
                });
            }, //antes de enviar
        }
    );
}

function reporteSugerencias() {
    var doc = new jsPDF('l', 'mm', 'a4');
    doc.fromHTML('<h1 style="font-family:sans-serif"><b>Administración</b></h1>', 15, 5);
    doc.text(15, 28, 'Reporte de sugerencias');

    var date = new Date();
    var datetime = date.getFullYear() + "-" + (date.getMonth() + 1) + "-" + date.getDate() + " " + date.getHours() + ":" + date.getMinutes();

    doc.fromHTML('<h5 style="font-family:sans-serif">Fecha del reporte: ' + datetime + '</h5>', 15, 26);

    var acc = document.getElementById('acc');

    if (acc) {
        acc.style.display = 'none';
    }

    doc.autoTable({
        html: '#tablaSug',
        startY: 43
    });

    if (acc) {
        acc.style.display = '';
    }

    doc.save('Sugerencias(' + datetime + ').pdf');
}