function reporteEstados(fecha) {
    var doc = new jsPDF('l', 'mm', 'a4');
    doc.fromHTML('<h1 style="font-family:sans-serif"><b>Administración</b></h1>', 15, 5);
    doc.text(15, 28, 'Estado de habitaciones diario');

    doc.fromHTML('<h5 style="font-family:sans-serif">Fecha del reporte: ' + fecha + '</h5>', 15, 26);

    doc.autoTable({
        html: '#testados',
        startY: 43
    });

    doc.save('EstadoHabitaciones(' + fecha + ').pdf');
}