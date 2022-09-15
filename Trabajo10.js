/* Ejercicio 1*/
var saludo = "Les doy la bienvenida a ";
var nombre = "programacion " + "facil.";
var leo = " Mi nombre es leo " + "soy uno de sus compañeros.";
var fraseCompleta = saludo + nombre + leo;
console.log(fraseCompleta);

/*Ejercicio2*/
var frase = "Java script " + "es un lenguaje " + "esencial " + "para crear " + "sitios web poderosos.";
var frase2 = " Ademas de que es divertido";
var fraseCompleta = frase + frase2;
console.log(fraseCompleta);

/*Ejercicio3*/
var num1 = "10 ";
var num2 = "20 ";
var num3 = "30";
var f1 = "Messi en Argentina con la ";
var f2 = "Lo celso en Argentina con la ";
var f3 = "y Messi en el PSG con la ";
var jugadores = f1 + num1 + f2 + num2 + f3 + num3;
console.log(jugadores);

/*Ejercicio4*/
var edadNombre = edad + nombre;
edad = prompt ("Cual es su edad?");
nombre = prompt ("Cual es su nombre?");
console.warn(edadNombre);

/*Ejercicio5*/
var edad;
edad = prompt ("Indique su edad");
if (edad >= 18){
    alert("Puedes entrar, eres mayor de edad.");
    } 
    else 
    {
    alert("No puedes entrar, eres menor de edad.");
    }