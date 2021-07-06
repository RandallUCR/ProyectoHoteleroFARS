const inputP = document.querySelector('.formPublicidad');
const previewP = document.querySelector('.previewPublicidad');

inputP.style.opacity = 0;

inputP.addEventListener('change', updateImageDisplayP);

function updateImageDisplayP() {
    while (previewP.firstChild) {
        previewP.removeChild(previewP.firstChild);
    }

    const curFiles = inputP.files;
    if (curFiles.length === 0) {
        const para = document.createElement('p');
        para.textContent = 'No seleccionó ningún archivo';
        previewP.appendChild(para);
    } else {
        const list = document.createElement('ol');
        previewP.appendChild(list);

        for (const file of curFiles) {
            const listItem = document.createElement('li');
            const para = document.createElement('p');

            if (validFileTypeP(file) && file.size <= 2000000) {
                para.textContent = `Imagen ${file.name}, tamaño ${returnFileSize(file.size)}.`;
                const image = document.createElement('img');
                image.src = URL.createObjectURL(file);
                //image.id = "NewImgGalery";

                listItem.appendChild(image);
                listItem.appendChild(para);
            } else {
                if (file.size > 2000000) {
                    para.textContent = `Archivo ${file.name}: Tamaño de imagen no valido. Seleccione imágenes menores a 2MB.`;
                } else {
                    para.textContent = `Archivo ${file.name}: Extensión de imagen no válida. Seleccione una extensión válida .`;
                }
                listItem.appendChild(para);
            }

            list.appendChild(listItem);
        }
    }
}

// https://developer.mozilla.org/en-US/docs/Web/Media/Formats/Image_types
const fileTypesP = [
    'image/apng',
    'image/bmp',
    'image/gif',
    'image/jpeg',
    'image/pjpeg',
    'image/png',
    'image/svg+xml',
    'image/tiff',
    'image/webp',
    `image/x-icon`
];

function validFileTypeP(file) {
    return fileTypesP.includes(file.type);
}

function returnFileSize(number) {
    if (number < 1024) {
        return number + 'bytes';
    } else if (number > 1024 && number < 1048576) {
        return (number / 1024).toFixed(1) + 'KB';
    } else if (number > 1048576) {
        return (number / 1048576).toFixed(1) + 'MB';
    }
}

function agregarPublicidad() {
    const curFiles = inputP.files;
    if (curFiles.length === 0) {
        Swal.fire('No se ha seleccionado ningún archivo', '', 'error');
    } else {
        if (document.getElementById('in_publicidad').value == '') {
            Swal.fire('No se ha ingresado ningún link', '', 'error');
        } else {
            var reader = new FileReader();
            reader.readAsDataURL(inputP.files[0]);
            reader.onload = function () {
                var dataURL = reader.result;

                var base64 = dataURL.split(',')[1];
                var ext = (dataURL.split(';')[0]).split('/')[1];

                //hacer llamada al controller para guardar
                parametros = { "base64": base64, "formato": ext, "linkP": document.getElementById('in_publicidad').value };
                $.ajax(
                    {
                        data: parametros,
                        url: '/AdministradorPublicidad/guardarNuevaPublicidad',
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
                            document.getElementById('respuestaNPL').innerHTML = '';
                            document.getElementById('respuestaNPL').appendChild(div);
                        }, //antes de enviar

                        success: function (response) {
                            document.getElementById('respuestaNPL').innerHTML = '';
                            if (response == 1) {
                                Swal.fire('Publicidad guardada', '', 'success');
                                actualizarTablaPublicidad();
                                document.getElementById('in_publicidad').value = '';
                                //esto va al final
                                while (previewP.firstChild) {
                                    previewP.removeChild(previewP.firstChild);
                                }
                                const para = document.createElement('p');
                                para.textContent = 'No seleccionó ningún archivo';
                                previewP.appendChild(para);
                                $('#image_publicidad').val('');
                            } else {
                                Swal.fire('Error al guardar la nueva publicidad', '', 'error');
                            }
                        }
                    }
                );
            };
        }
    }
}

function editarLinkPublicidad(button) {
    Swal.fire({
        title: '¿Desea editar la publicidad seleccionada?',
        showDenyButton: true,
        confirmButtonText: 'Editar',
        denyButtonText: 'Cancelar',
    }).then((result) => {
        /* Read more about isConfirmed, isDenied below */
        if (result.isConfirmed) {
            var idFac = button.id;
            var desc = document.getElementById('in_pub_' + idFac).value;

            parametros = { "id": idFac, "linkP": desc };
            $.ajax(
                {
                    data: parametros,
                    url: '/AdministradorPublicidad/editarLinkPublicidad',
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
                        newSpan.innerHTML = 'Editando....';

                        div.appendChild(divSpin);
                        div.appendChild(newSpan);
                        document.getElementById('respuestaPL_' + idFac).innerHTML = '';
                        document.getElementById('respuestaPL_' + idFac).appendChild(div);
                    }, //antes de enviar

                    success: function (response) {
                        document.getElementById('respuestaPL_' + idFac).innerHTML = '';
                        if (response == 1) {
                            actualizarTabla();
                            Swal.fire('Publicidad editada', '', 'success');
                        } else {
                            Swal.fire('Error al editar la publicidad', '', 'error');
                        }
                    }
                }
            );
        } else if (result.isDenied) {
            Swal.fire('Acción cancelada', '', 'info')
        }
    });
}
alert('XD');
function eliminarPublicidad(button) {
    Swal.fire({
        title: '¿Desea eliminar la publicidad seleccionada?',
        showDenyButton: true,
        confirmButtonText: 'Eliminar',
        denyButtonText: 'Cancelar',
    }).then((result) => {
        if (result.isConfirmed) {
            parametros = { "id": button.id };
            $.ajax(
                {
                    data: parametros,
                    url: '/AdministradorPublicidad/eliminarPublicidad',
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
                        newSpan.innerHTML = 'Eliminando....';

                        div.appendChild(divSpin);
                        div.appendChild(newSpan);
                        document.getElementById('respuestaPL_' + button.id).innerHTML = '';
                        document.getElementById('respuestaPL_' + button.id).appendChild(div);
                    }, //antes de enviar

                    success: function (response) {
                        document.getElementById('respuestaPL_' + button.id).innerHTML = '';
                        if (response == 1) {
                            actualizarTablaPublicidad();
                            Swal.fire('Publicidad eliminada', '', 'success');
                        } else {
                            Swal.fire('Error al eliminar la publicidad', '', 'error');
                        }
                    }
                }
            );
        } else if (result.isDenied) {
            Swal.fire('Acción cancelada', '', 'info')
        }
    });
}

function actualizarTablaPublicidad() {
    $.ajax(
        {
            url: '/AdministradorPublicidad/actualizarTablaPublicidad',
            type: 'post',
            beforeSend: function () { }, //antes de enviar
            success: function (response) {
                var lista = JSON.parse(response.resultado);

                $('#contenidoTablaPublicidad tr').remove(); //destruimos toda la tabla

                for (var x = 0; x < lista.length; x++) {
                    var info = '<tr> <th scope="row">' + lista[x].TN_Id + '</th>' +
                        '<td>' +
                        '<img height="200" width="250" style="max-height:inherit; max-width:inherit" src="data:image/' + lista[x].galeria.TC_Formato + ';base64,' + lista[x].galeria.TV_Archivo + '"/>' +
                        '</td> <td> <form> <div> <span>Link</span><br />' +
                        '<input class="form-control" style="font-family: Century Gothic; margin-top: 0.5em" id="in_pub_' + lista[x].TN_Id + '" name="in_pub_' + lista[x].TN_Id + '" value="' + lista[x].TC_Link + '">' +
                        '</div>' +
                        '<div>' +
                        '<button type="button" id="' + lista[x].TN_Id + '" onclick="editarLinkPublicidad(this)"> Guardar</button> <br/>' +
                        '<span id="respuestaPL_' + lista[x].TN_Id + '"></span> </div > </form> </td > <td>' +
                        '<button class="btn btn-danger" id="' + lista[x].TN_Id + '" onclick="eliminarPublicidad(this)">Eliminar</button> </td> </tr>';

                    document.getElementById('contenidoTablaPublicidad').innerHTML += info;
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