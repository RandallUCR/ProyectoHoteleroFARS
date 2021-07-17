function irTipo() {
    var id = $('#tipoHabi').val();
    var data = { id: id }
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

function irCaract() {
    var id = $('#tipoHabi').val();
    var data = { id: id }
    $.ajax({
        type: 'post',
        url: '/AdministradorCaracteristicas/Index',
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
            var id = $('#tipoHabi').val();
            var data = { id: id }
            $.ajax({
                type: 'post',
                url: '/AdministradorHabitaciones/eliminarTipo',
                data: data,
                success: function (response) {
                    if (response.success == true) {
                        if (response.inserted == true) {
                            window.location.href = response.url;
                        } else {
                            Swal.fire({
                                position: 'center',
                                icon: 'error',
                                title: 'Imposible, promociones o habitaciones ligadas.',
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

            var data = { id: id }

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

$('#insTipoForm').submit(function (e) {
    e.preventDefault();
    
    const fileInput = document.querySelector("#img");
    // get a reference to the file
    const file = fileInput.files[0];
    // encode the file using the FileReader API
    const reader = new FileReader();
    reader.onloadend = () => {
        // use a regex to remove data url part
        const base64String = reader.result
            .replace("data:", "")
            .replace(/^.+,/, "");

        // log to console
        // logs wL2dvYWwgbW9yZ...
        //console.log(base64String);
        //alert(base64String);
        if (fileInput.files[0].size <= 2000000) {

            var form = $(this);
            var url = form.attr('action');
            var nombre = $('#nombre').val();
            var desc = $('#desc').val();
            var precio = $('#precio').val();

            var aux = fileInput.files[0].name;

            var ext = aux.substring(aux.lastIndexOf('.') + 1, aux.length);

            var data = { nombre: nombre, desc: desc, precio: precio, base64: base64String, ext: ext }
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
                                title: 'Ya existe este Tipo de Habitación',
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

                },
                error: function (response) {
                    Swal.fire({
                        position: 'center',
                        icon: 'error',
                        title: 'Error en el sistema',
                        showConfirmButton: false,
                        timer: 1500
                    });
                }
            });
        } else {
            Swal.fire({
                position: 'center',
                icon: 'error',
                title: 'El peso de la imagen debe ser igual o menor a 2 MB',
                showConfirmButton: false,
                timer: 1500
            });
        }        
    };
    reader.readAsDataURL(file);
});

$('#editTipoForm').submit(function (e) {
    e.preventDefault();

    const fileInput = document.querySelector("#inputImagen");
    // get a reference to the file
    const file = fileInput.files[0];
    // encode the file using the FileReader API
    const reader = new FileReader();


    if (fileInput.files.length == 0) {

        var form = $(this);
        var url = form.attr('action');
        var id = $('#id').val();
        var nombre = $('#nombre').val();
        var desc = $('#txtDesc').val();
        var precio = $('#precio').val();

        var data = { id: id, nombre: nombre, desc: desc, precio: precio, base64: 'NO', ext: 'NO' }
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
                            title: 'Ya existe este Tipo de Habitación',
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

            },
            error: function (response) {
                Swal.fire({
                    position: 'center',
                    icon: 'error',
                    title: 'Error en el sistema',
                    showConfirmButton: false,
                    timer: 1500
                });
            }
        });

    } else {
        reader.onloadend = () => {
            // use a regex to remove data url part
            const base64String = reader.result
                .replace("data:", "")
                .replace(/^.+,/, "");

            // log to console
            // logs wL2dvYWwgbW9yZ...
            //console.log(base64String);
            //alert(base64String);

            if (fileInput.files[0].size <= 2000000) {
                var form = $(this);
                var url = form.attr('action');
                var id = $('#id').val();
                var nombre = $('#nombre').val();
                var desc = $('#txtDesc').val();
                var precio = $('#precio').val();

                var aux = fileInput.files[0].name;

                var ext = aux.substring(aux.lastIndexOf('.') + 1, aux.length);

                var data = { id: id, nombre: nombre, desc: desc, precio: precio, base64: base64String, ext: ext }
                $.ajax({
                    type: 'post',
                    url: url,
                    data: data,
                    beforeSend: function () {
                        Swal.fire({
                            position: 'center',
                            icon: 'info',
                            title: 'Espere...',
                            showConfirmButton: false,
                            timer: 2000
                        });
                    },
                    success: function (response) {

                        if (response.success == true) {
                            if (response.inserted == true) {
                                window.location.href = response.url;
                            } else {
                                Swal.fire({
                                    position: 'center',
                                    icon: 'error',
                                    title: 'Ya existe este Tipo de Habitación',
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

                    },
                    error: function (response) {
                        Swal.fire({
                            position: 'center',
                            icon: 'error',
                            title: 'Error en el sistema',
                            showConfirmButton: false,
                            timer: 1500
                        });
                    }
                });
            } else {
                Swal.fire({
                    position: 'center',
                    icon: 'error',
                    title: 'El peso de la imagen debe ser igual o menor a 2 MB',
                    showConfirmButton: false,
                    timer: 1500
                });

            };            
        }
        reader.readAsDataURL(file);
    }

});


/*function toBase64(img) {
    const fileInput = document.querySelector("#"+img);
    // get a reference to the file
    const file = fileInput.files[0];

        // encode the file using the FileReader API
        const reader = new FileReader();
        reader.onloadend = () => {
            // use a regex to remove data url part
            const base64String = reader.result
                .replace("data:", "")
                .replace(/^.+,/, "");

            // log to console
            // logs wL2dvYWwgbW9yZ...
            console.log(base64String);
            alert(base64String);
        };
        reader.readAsDataURL(file);
}*/


