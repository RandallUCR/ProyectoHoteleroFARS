function modalInsTipo() {
    $('#modalInsertTipo').modal("show");
}

function modalInsHabi() {
    $('#modalInsertHabi').modal("show");
}

function eliminarTipo(id) {
    alert(id);
}

function eliminarHabi(id) {
    alert(id);
}

function modalInsHabi(id,num,estado){
    $('#idhabi').val(id);
    $('#nume').val(num);
    if (estado == 0) {
        $('#estadoe').attr('checked', false);
    } else {
        $('#estadoe').attr('checked', true);
    }

    $('#modalEditHabi').modal("show");
}