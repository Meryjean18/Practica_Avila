document.addEventListener('DOMContentLoaded', function () {
    menuMobile();
})

function menuMobile() {
    const menu = document.querySelector('.menu-mobile');
    menu.addEventListener('click', function () {
        const navegacion = document.querySelector('.navegacion');
        /*if (navegacion.classList.contains('mostrar')) {
            navegacion.classList.remove('mostrar');
        } else {
            navegacion.classList.add('mostrar');
        }*/
        navegacion.classList.toggle('mostrar');
    })
}