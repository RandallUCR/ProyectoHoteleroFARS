const inputFoto = document.querySelector('.formFoto');
const previewFoto = document.querySelector('.previewFoto');
inputFoto.style.opacity = 0;
inputFoto.addEventListener('change', updateImageDisplayFoto);

function updateImageDisplayFoto() {
    while (previewFoto.firstChild) {
        previewFoto.removeChild(previewFoto.firstChild);
    }

    const curFiles = inputFoto.files;
    if (curFiles.length === 0) {
        const para = document.createElement('p');
        para.textContent = 'No seleccionó ningún archivo';
        previewFoto.appendChild(para);
    } else {
        const list = document.createElement('ol');
        previewFoto.appendChild(list);

        for (const file of curFiles) {
            const listItem = document.createElement('li');
            const para = document.createElement('p');

            if (validFileType(file) && file.size <= 2000000) {
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


function aceptarModificarSobreNosotros() {
    parametros = { "sobreNosotros": document.getElementById('taSobreNosotros').value };
    $.ajax(
        {
            data: parametros,
            url: '/AdministradorPaginas/modificarSobreNosotros',
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


function aceptarModificarDescripcion() {
    parametros = { "descripcion": document.getElementById('taDescripcion').value };
    $.ajax(
        {
            data: parametros,
            url: '/AdministradorPaginas/modificarHomeDescripcion',
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
function aceptarModificarComoLlegar() {
    parametros = { "maps": document.getElementById('taMaps').value , "ubicacion": document.getElementById('taUbicacion').value }   ;
    $.ajax(
        {
            data: parametros,
            url: '/AdministradorPaginas/modificarComoLlegar',
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
function actualizarFoto() {
    const curFiles = inputFoto.files;
    if (curFiles.length === 0) {
        Swal.fire('No se ha seleccionado ningún archivo', '', 'error');
    } else {
        var reader = new FileReader();
        reader.readAsDataURL(inputFoto.files[0]);
        reader.onload = function () {
            var dataURL = reader.result;

            var base64 = dataURL.split(',')[1];
            var ext = (dataURL.split(';')[0]).split('/')[1];

            //hacer llamada al controller para guardar
            parametros = { "base64": base64, "formato": ext };
            $.ajax(
                {
                    data: parametros,
                    url: '/AdministradorPaginas/actualizarFoto',
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
                        document.getElementById('respuestaNFL').innerHTML = '';
                        document.getElementById('respuestaNFL').appendChild(div);
                    }, //antes de enviar

                    success: function (response) {
                        document.getElementById('respuestaNFL').innerHTML = '';
                        if (response == 1) {
                            Swal.fire('Foto guardada', '', 'success');
                            actualizarTabla();
                            //esto va al final
                            while (previewFoto.firstChild) {
                                previewFoto.removeChild(previewFoto.firstChild);
                            }
                            const para = document.createElement('p');
                            para.textContent = 'No seleccionó ningún archivo';
                            previewFoto.appendChild(para);
                            $('#image_foto').val('');
                        } else {
                            Swal.fire('Error al guardar la nueva foto', '', 'error');
                        }
                    }
                }
            );
        };
    }
}
