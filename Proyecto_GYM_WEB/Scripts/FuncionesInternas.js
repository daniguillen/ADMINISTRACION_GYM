


/*
$(window).on('resize', function () {
    if (window.innerWidth < 1500) {
        $(".inscribete").removeClass("col-4");
        $(".inscribete").addClass("col-12");
        $(".inscribete").addClass("mb-5");
        $(".inscribete").addClass("mt-5");




        $(".promos").addClass("mb-5");
        $(".promos").addClass("mt-5");
        $(".promos").removeClass("col-8");
        $(".promos").addClass("col-12");
        console.log("responsive");
    } else {
        $(".inscribete").removeClass("col-12");
        $(".inscribete").addClass("col-4");
        $(".promos").removeClass("col-12");
        $(".promos").addClass("col-8");
        console.log("not responsive");
        $(".inscribete").removeClass("mb-5");
        $(".inscribete").removeClass("mt-5");

        $(".promos").removeClass("mb-5");
        $(".promos").removeClass("mt-5");
    }




});

*/

function showModalUsuarioEntrenador() {
    var modal = new bootstrap.Modal(document.getElementById('exampleModal2'));
    modal.show();
}

$(window).on('resize', function () {
    if (window.innerWidth < 768) {

        $(".promos").addClass("flex-column");
        $(".promos").addClass("align-items-center");

    }
    else {

        $(".promos").removeClass("flex-column");
        $(".promos").removeClass("align-items-center");


    };
});

document.addEventListener("DOMContentLoaded", function () {
    var observer = new IntersectionObserver(function (entries) {
        entries.forEach(function (entry) {
            if (entry.isIntersecting) {
                entry.target.classList.add('slide-in');
                observer.unobserve(entry.target); // Deja de observar una vez que la animación se ha disparado
            }
        });
    });

    // Observa todos los elementos con la clase "tranformar"
    document.querySelectorAll('.tranformar').forEach(function (element) {
        observer.observe(element);
    });
});





