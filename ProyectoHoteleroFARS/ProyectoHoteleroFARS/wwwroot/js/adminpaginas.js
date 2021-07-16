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
