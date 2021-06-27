const inputF = document.querySelector('.formFacilidad');
const previewF = document.querySelector('.previewFacilidad');

inputF.style.opacity = 0;

inputF.addEventListener('change', updateImageDisplayF);

function updateImageDisplayF() {
    while (previewF.firstChild) {
        previewF.removeChild(previewF.firstChild);
    }

    const curFiles = inputF.files;
    if (curFiles.length === 0) {
        const para = document.createElement('p');
        para.textContent = 'No seleccionó ningún archivo';
        previewF.appendChild(para);
    } else {
        const list = document.createElement('ol');
        previewF.appendChild(list);

        for (const file of curFiles) {
            const listItem = document.createElement('li');
            const para = document.createElement('p');

            if (validFileType(file) && file.size <= 2000000) {
                para.textContent = `Imagen ${file.name}, tamaño ${returnFileSize(file.size)}.`;
                const image = document.createElement('img');
                image.src = URL.createObjectURL(file);
                image.id = "NewImgGalery";

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
const fileTypesF = [
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

function validFileType(file) {
    return fileTypesF.includes(file.type);
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

function agregarFacilidad() {
    const curFiles = inputF.files;
    if (curFiles.length === 0) {
        Swal.fire('No se ha seleccionado ningún archivo', '', 'error');
    } else {
        var reader = new FileReader();
        reader.readAsDataURL(inputF.files[0]);
        reader.onload = function () {
            var dataURL = reader.result;

            var base64 = dataURL.split(',')[1];
            var ext = (dataURL.split(';')[0]).split('/')[1];

            //hacer llamada al controller para guardar
            parametros = { "base64": base64, "formato": ext, "descF": document.getElementById('ta_facilidad').value };
            $.ajax(
                {
                    data: parametros,
                    url: '/AdministradorPaginas/guardarNuevaFacilidad',
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
                            Swal.fire('Facilidad guardada', '', 'success');
                            window.location.href = '/Administrador/AdministrarPaginas';
                        } else {
                            Swal.fire('Error al guardar la nueva facilidad', '', 'error');
                        }
                    }
                }
            );
        };
        //esto va al final
        while (preview.firstChild) {
            preview.removeChild(preview.firstChild);
        }
        const para = document.createElement('p');
        para.textContent = 'No se ha seleccionado ningún archivo';
        preview.appendChild(para);
    }
}


function editarFacilidad(button) {
    var idFac = button.id;
    var desc = document.getElementById('ta_fac_' + idFac).value;

    parametros = { "idFac": idFac, "descripcion": desc };
    $.ajax(
        {
            data: parametros,
            url: '/AdministradorPaginas/editarFacilidad',
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
                document.getElementById('respuestaFL_' + idFac).innerHTML = '';
                document.getElementById('respuestaFL_' + idFac).appendChild(div);
            }, //antes de enviar

            success: function (response) {
                document.getElementById('respuestaFL_' + idFac).innerHTML = '';
                if (response == 1) {
                    Swal.fire('Facilidad editada', '', 'success');
                    window.location.href = '/Administrador/AdministrarPaginas';
                } else {
                    Swal.fire('Error al editar la nueva facilidad', '', 'error');
                }
            }
        }
    );
}

function eliminarFacilidad(button) {
    parametros = { "idFac": button.id};
    $.ajax(
        {
            data: parametros,
            url: '/AdministradorPaginas/eliminarFacilidad',
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
                document.getElementById('respuestaFL_' + button.id).innerHTML = '';
                document.getElementById('respuestaFL_' + button.id).appendChild(div);
            }, //antes de enviar

            success: function (response) {
                document.getElementById('respuestaFL_' + button.id).innerHTML = '';
                if (response == 1) {
                    Swal.fire('Facilidad eliminada', '', 'success');
                    window.location.href = '/Administrador/AdministrarPaginas';
                } else {
                    Swal.fire('Error al eliminar la nueva facilidad', '', 'error');
                }
            }
        }
    );
}