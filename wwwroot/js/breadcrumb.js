const breadcrumbContainer = document.getElementById("breadcrumb-container");

function updateBreadcrumb() {
    breadcrumbContainer.innerHTML = ""; // Limpiar el contenido previo

    // Añadir el elemento "Home"
    breadcrumbContainer.innerHTML += `<li class="breadcrumb-item"><a href="/">Home</a></li>`;

    // Comprobar si el controlador no es "Home"
    if (controllerName !== "Home") {
        breadcrumbContainer.innerHTML +=
            `<li class="breadcrumb-item"><a href="/${controllerName}">${controllerName}</a></li>`;
    }

    // Añadir el elemento actual
    breadcrumbContainer.innerHTML += `<li class="breadcrumb-item active" aria-current="page">${actionName}</li>`;
}

// Llamar a la función para actualizar el breadcrumb
updateBreadcrumb();
