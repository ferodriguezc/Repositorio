function cambiarDiv(seccion) {
    var secciones = ['Sobre_Mi', 'Conocimientos', 'proyectos', 'conctato'];

    secciones.forEach(function (item) {
        var div = document.getElementById(item);
        div.style.display = item === seccion ? 'block' : 'none';
    });
}
