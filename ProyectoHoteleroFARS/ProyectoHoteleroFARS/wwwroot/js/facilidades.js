const inputF = document.querySelector('.formFacilidad');
const previewF = document.querySelector('.previewFacilidad');

inputF.style.opacity = 0;

inputF.addEventListener('change', updateImageDisplay);

function updateImageDisplay() {
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

function guardarFacilidad() {
    alert('Hola');
}

function editarFacilidad(button) {

}

function eliminarFacilidad(button) {

}