// Variable para almacenar el último elemento expandido
let ultimoExpandido = null;

// Función para expandir o contraer el elemento .foto_p
function expandir(id) {
    const elementoFotoP = document.getElementById(id);

    // Verificar si el elemento ya está expandido
    const estaExpandido = elementoFotoP.classList.contains('expandir');

    // Si el último elemento expandido es diferente del actual, resetear
    if (ultimoExpandido && ultimoExpandido !== elementoFotoP) {
        ultimoExpandido.classList.remove('expandir');
        ultimoExpandido.classList.add('contraer');
    }

    // Aplicar la clase adecuada para expandir o contraer
    if (!estaExpandido) {
        elementoFotoP.classList.add('expandir');
        elementoFotoP.classList.remove('contraer');
    } else {
        elementoFotoP.classList.remove('expandir');
        elementoFotoP.classList.add('contraer');
    }

    // Actualizar el último elemento expandido
    ultimoExpandido = elementoFotoP;
}