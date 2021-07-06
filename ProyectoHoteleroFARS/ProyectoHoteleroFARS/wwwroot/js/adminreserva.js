function modal(id, fecha, idRes, cedula, nombre, apellidos, email, tarjeta, trans, llegada, salida, tipo) {

    $('#id').val(id);
    $('#fechae').val(fecha);
    $('#id_rese').val(idRes);
    $('#cedulae').val(cedula);
    $('#nombree').val(nombre);
    $('#apellidose').val(apellidos);
    $('#emaile').val(email);
    $('#tarjetae').val(tarjeta);
    $('#transe').val(trans);
    $('#rangofechase').val(llegada + " - " + salida);
    $("#tipoe").val(tipo).change();


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

function reporteReservas() {
    var doc = new jsPDF('l', 'mm', 'a4');
    doc.fromHTML('<h1 style="font-family:sans-serif"><b>Administración</b></h1>', 15, 5);
    doc.text(15, 28, 'Reporte de reservas');

    var date = new Date();
    var datetime = date.getFullYear() + "-" + (date.getMonth() + 1) + "-" + date.getDate() + " " + date.getHours() + ":" + date.getMinutes();

    doc.fromHTML('<h5 style="font-family:sans-serif">Fecha del reporte: ' + datetime + '</h5>', 15, 26);

    var acc1 = document.getElementById('acc1');
    var acc2 = document.getElementById('acc2');
    if (acc1) {
        acc1.style.display = 'none';
    }

    if (acc2) {
        acc2.style.display = 'none';
    }

    doc.autoTable({
        html: '#tablaReporte',
        startY: 43
    });

    if (acc1) {
        acc1.style.display = '';
    }

    if (acc2) {
        acc2.style.display = '';
    }

    doc.save('Reservas(' + datetime + ').pdf');
}

function reporteReserva() {
    var fecha = $('#fechae').val();
    var id = $('#id_rese').val();
    var ced = $('#cedulae').val();
    var nom = $('#nombree').val();
    var ap = $('#apellidose').val();
    var em = $('#emaile').val();
    var tar = $('#tarjetae').val();
    var tran = $('#transe').val();
    var rango = $('#rangofechase').val();
    var tipo = $("#tipoe option:selected").text(); 

    var doc = new jsPDF('p', 'mm', 'a4');
    doc.fromHTML('<h1 style="font-family:sans-serif"><b>Administración</b></h1>', 15, 5);
    doc.text(15, 28, 'Reporte de reserva '+id);

    var date = new Date();
    var datetime = date.getFullYear() + "-" + (date.getMonth() + 1) + "-" + date.getDate() + " " + date.getHours() + ":" + date.getMinutes();

    doc.fromHTML('<h5 style="font-family:sans-serif">Fecha del reporte: ' + datetime + '</h5>', 15, 26);

    doc.line(15, 43, 195, 43);  

    doc.fromHTML('<h3 style="font-family:sans-serif; color:#048ECA">Datos de la reserva</h3>', 15, 40);

    doc.fromHTML('<b style="font-family:sans-serif">Id de la reserva: </b>' + id, 15, 50);
    doc.fromHTML('<b style="font-family:sans-serif">Fecha en que se reservó: </b>' + fecha, 15, 55);
    doc.fromHTML('<b style="font-family:sans-serif">Tarjeta cobrada: </b>' + tar, 15, 60);
    doc.fromHTML('<b style="font-family:sans-serif">Transcción del cobro: </b>' + tran, 15, 65);
    doc.fromHTML('<b style="font-family:sans-serif">Rango de fechas del hospedaje: </b>' + rango, 15, 70);
    doc.fromHTML('<b style="font-family:sans-serif">Tipo de habitación reservada: </b>' + tipo, 15, 75);

    doc.line(15, 92, 195, 92);

    doc.fromHTML('<h3 style="font-family:sans-serif; color:#048ECA">Datos del cliente</h3>', 15, 89);

    doc.fromHTML('<b style="font-family:sans-serif">Cédula: </b>' + ced, 15, 99);
    doc.fromHTML('<b style="font-family:sans-serif">Nombre: </b>' + nom, 15, 104);
    doc.fromHTML('<b style="font-family:sans-serif">Apellidos: </b>' + ap, 15, 109);
    doc.fromHTML('<b style="font-family:sans-serif">Email: </b>' + em, 15, 114);

    doc.save('Reserva_'+id+'.pdf');
}