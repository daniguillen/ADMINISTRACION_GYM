
let time = false;
let contador = 0


var intervalo=setInterval(function activar () {

    if (!time) {

        $(".daniel").css({ "display": "none" });
        time = true;
        console.log("hola")
       
    } else {
        $(".daniel").css({ "display": "flex" });
        time = false;
        console.log("chao")

    }
    contador++

    console.log(contador)

if (contador == 10) {
    clearTimeout(intervalo)
    console.log("stop")
}
}, 1000);




