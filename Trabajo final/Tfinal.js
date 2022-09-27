var edad;
edad = prompt ("Indique su edad");
if (edad >= 18){
    alert("Puede entrar, eres mayor de edad.");
    } 
    else 
    {
    alert("Usted no es mayor, entra bajo su propia responsabilidad.");
    }
    var popup = document.querySelector(".popup");
    popup.onclick = function(e){
        confirm("¿Seguro quiere cerrar su sesion?");
    }