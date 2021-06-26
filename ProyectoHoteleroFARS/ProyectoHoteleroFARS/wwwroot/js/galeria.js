const input = document.querySelector('.formGalery');
const preview = document.querySelector('.preview');

input.style.opacity = 0;

input.addEventListener('change', updateImageDisplay);

function updateImageDisplay() {
    while (preview.firstChild) {
        preview.removeChild(preview.firstChild);
    }

    const curFiles = input.files;
    if (curFiles.length === 0) {
        const para = document.createElement('p');
        para.textContent = 'No seleccionó ningún archivo';
        preview.appendChild(para);
    } else {
        const list = document.createElement('ol');
        preview.appendChild(list);

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
const fileTypes = [
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
    return fileTypes.includes(file.type);
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

function guardarImgGaleria() {
    const curFiles = input.files;
    if (curFiles.length === 0) {
        Swal.fire('No se ha seleccionado ningún archivo', '', 'error');
    } else {
        var reader = new FileReader();
        reader.readAsDataURL(input.files[0]);
        reader.onload = function () {
            alert(reader.result)
            var dataURL = reader.result;

            var base64 = dataURL.split(',')[1];
            var ext = (dataURL.split(';')[0]).split('/')[1];

            //hacer llamada al controller para guardar
            parametros = { "base64": base64, "formato": ext };
            $.ajax(
                {
                    data: parametros,
                    url: '/Administrador/guardarImagenGaleria',
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
                        document.getElementById('respuestaGL').innerHTML = '';
                        document.getElementById('respuestaGL').appendChild(div);
                    }, //antes de enviar

                    success: function (response) {
                        document.getElementById('respuestaGL').innerHTML = '';
                        alert(response);
                        if (response == 1) {
                            Swal.fire('Imagen guardada', '', 'success');
                        } else {
                            Swal.fire('Error al guardar la imagen', '', 'error');
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

function eliminarImgGaleria(button) {
    //hacer llamada al controller para guardar
    parametros = { "idImg": button.id };
    $.ajax(
        {
            data: parametros,
            url: '/Administrador/eliminarImagenGaleria',
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
                document.getElementById('respuestaGL').innerHTML = '';
                document.getElementById('respuestaGL').appendChild(div);
            }, //antes de enviar

            success: function (response) {
                document.getElementById('respuestaGL').innerHTML = '';
                alert(response);
                if (response == 1) {
                    Swal.fire('Imagen eliminada', '', 'success');
                } else {
                    Swal.fire('Error al eliminar la imagen', '', 'error');
                }
            }
        }
    );
}