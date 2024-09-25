using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class EjercicioWhile
    {

        //Devuelve el contador del 1 al 10
        public void Ejercicio1()
        {
            int numero = 1;

            while (numero <= 10)
            {
                Console.WriteLine(numero);
                numero = numero + 1;
            }
        }

        //Devuelve la suma de numeros hasta N
        public void Ejercicio2()
        {
            Console.WriteLine("Ingrese por favor un número");
            int numero = int.Parse(Console.ReadLine());

            int contador = 1;
            int suma = 1;

            while (contador <= numero)
            {
                suma = suma + contador;
                contador = contador + 1;
            }

            Console.WriteLine("El resultado de la suma hasta " + numero + " es: " + suma);

        }

        //Devuelve la tabla de multiplicar 7
        public void Ejercicio3()
        {
            int tabla = 7;
            int contador = 1;
            int resultado = 0;

            while (contador <= 10)
            {
                resultado = tabla * contador;
                Console.WriteLine(tabla + " * " + contador + " = " + resultado);
                contador = contador + 1;
            }

            //Console.WriteLine("La tabla del 7 es: " + resultado);
        }

        //Devuelve un numero descendente
        public void Ejercicio4()
        {
            int numero = 20;

            while (numero >= 1)
            {
                Console.WriteLine(numero);
                numero = numero - 1;

            }
        }

        //Devuelve los pares entre 1 y 30
        public void Ejercicio5()
        {
            int numero = 0;



            while (numero < 30 && numero % 2 == 0)
            {
                numero = numero + 2;
                Console.WriteLine(numero);
            }
        }

        //Devuelve el factorial de un numero
        public void Ejercicio6()
        {
            Console.WriteLine("Ingrese por favor un número");
            int numero = int.Parse(Console.ReadLine());

            int contador = 1;
            int resultado = 1;

            while (contador <= numero)
            {
                resultado = resultado * contador;
                contador = contador + 1;
            }

            Console.WriteLine("El resultado es: " + resultado);
        }

        //devuelve letra por letra una cadena de texto
        public void Ejercicio7()
        {

            Console.WriteLine("Ingrese por favor una cadena de texto");
            string palabra = Console.ReadLine();

            int contador = 0;
            while (contador < palabra.Length)
            {
                Console.WriteLine(palabra[contador]);
                contador++;
            }

        }

        //devuelve la suma de digitos 
        public void Ejercicio8()
        {
            Console.WriteLine("Ingrese por favor un digito");
            string numero = Console.ReadLine();

            int contador = 0;
            int numeroInt;
            int suma = 0;

            while (contador < numero.Length)
            {
                numeroInt = Convert.ToInt32(numero[contador].ToString());
                suma += numeroInt;
                contador++;
            }
            Console.WriteLine("La suma de los digitos es igual: " + suma);

        }

        //Devuelve un numero aleatorio
        public void Ejercicio9()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 100);


            int numeroUsu = 0;
            do
            {
                Console.WriteLine("Adivine el número entre 1 y 100");
                numeroUsu = int.Parse(Console.ReadLine());

                if (numeroUsu < numeroAleatorio)
                {
                    Console.WriteLine("El número es mayor.Intente de nuevo");
                }
                else if (numeroUsu > numeroAleatorio)
                {
                    Console.WriteLine("El número es menor.Intente de nuevo.");
                }

            } while (numeroUsu != numeroAleatorio);



            Console.WriteLine("Felicidades.Adivinaste el número");

        }

        //Devuelve la cantidad de letras de una cadena

        public void Ejercicio10()
        {
            Console.WriteLine("Ingrese por favor una cadena de texto");
            string cadena = Console.ReadLine();

            int contador = 0;
            int numero = 0;


            while (contador < cadena.Length)
            {
                contador++;
            }

            Console.WriteLine("La cantidad de letras en la cadena es: " + contador);

        }

        //Devuelve un número minimo y maximo
        public void Ejercicio11()
        {
            int numero = 0;
            int menor = int.MaxValue;
            int mayor = 0;
            do
            {
                Console.WriteLine("Ingrese por favor un número, el programa se detiene cuando ingrese un número negativo");
                numero = int.Parse(Console.ReadLine());

                if (numero > mayor)
                {
                    mayor = numero;
                }
                if (numero < menor && numero > 0)
                {
                    menor = numero;
                }
            } while (numero > 0);

            Console.WriteLine("El número mayor es: " + mayor);
            Console.WriteLine("El número menor es: " + menor);
        }

        //Devuelve el promedio de numeros ingresados
        public void Ejercicio12()
        {

            int numero = 0;

            double suma = 0;
            int contador = 0;
            double promedio = 0;

            do
            {
                Console.WriteLine("Ingrese un número, el programa se detiene cuando ingrese el cero");
                numero = int.Parse(Console.ReadLine());

                if (numero != 0)
                {
                    suma += numero;
                    contador++;
                }

            } while (numero != 0);

            promedio = contador > 0 ? suma / contador : 0;

            Console.WriteLine(promedio);

        }

        //Develve la serie de fibonacci
        public void Ejercicio13()
        {
            Console.WriteLine("Serie Fibonacci");

            int numero1 = 0;
            int numero2 = 1;
            int suma;
            int contador = 0;

            while (contador < 15)
            {
                Console.WriteLine(numero1);
                suma = numero1;
                numero1 = numero2;
                numero2 = suma + numero2;
                contador++;
            }
        }

        //devuelve un numero primo 
        public void Ejercicio14()
        {
            Console.WriteLine("Ingrese por favor un número para determinar si es primo o cumpuesto");
            int numero = int.Parse(Console.ReadLine());

            bool bandera = true;
            int residuo = 2;

            if (numero <= 1)
            {
                Console.WriteLine("El número ingresado no es primo ni compuesto");
            }
            else if (numero == 2)
            {
                bandera = true;
            }

            while (residuo < numero)
            {
                if (numero % residuo == 0)
                {
                    bandera = false;
                }
                residuo++;
            }

            if (bandera)
            {
                Console.WriteLine("El número " + numero + " es primo");
            }
            else
            {
                Console.WriteLine("El número " + numero + " es compuesto");
            }

        }

        //devuelve los numeros invertidos
        public void Ejercicio15()
        {
            Console.WriteLine("Ingrese por favor un número");
            int numeroIngresado = int.Parse(Console.ReadLine());

            int numeroInvertido = 0;
            int digito = 0;

            while (numeroIngresado > 0)
            {
                digito = numeroIngresado % 10;
                numeroInvertido = numeroInvertido * 10 + digito;
                numeroIngresado /= 10;
            }
            Console.WriteLine(numeroInvertido);
        }

        //devuelve la cantidad de palabras de una frase
        public void Ejercicio16()
        {
            Console.WriteLine("Ingresa por favor una frase");
            string frase = Console.ReadLine();

            int contador = 0;
            int indice = 0;
            bool enPalabra = false;

            while (indice < frase.Length)
            {
                char caracter = frase[indice];

                if (caracter != ' ')
                {
                    if (!enPalabra)
                    {
                        contador++;
                        enPalabra = true;
                    }

                }
                else
                {
                    enPalabra = false;
                }

                indice++;

            }

            Console.WriteLine(contador);
        }

        //devuelve la suma de numeros hasta un objetivo
        public void Ejercicio17()
        {
            Console.WriteLine("ingrese por favor el objetivo de la suma");
            int objetivo = int.Parse(Console.ReadLine());

            int suma = 0;
            int numero = 0;

            while (suma < objetivo)
            {
                Console.WriteLine("Ingrese por favor un numero");
                numero = int.Parse(Console.ReadLine());

                suma += numero;

                Console.WriteLine("La suma actualmente tiene un valor de: " + suma);
            }

            Console.WriteLine("La suma ha llegado hasta su objetivo: " + suma);
        }

        //Devuelve una validacion de contraseña
        public void Ejercicio18()
        {
            string contraseñaCorrecta = "vale123";
            string contraseñaUsu = string.Empty;
            bool bandera = false;
            int contador = 0;

            while (contador < 5)
            {
                Console.WriteLine("Ingrese la contraseña.");
                contraseñaUsu = Console.ReadLine();

                if (contraseñaUsu == contraseñaCorrecta)
                {
                    Console.WriteLine("La contraseña es correcta.");
                    return;
                }
                else
                {
                    contador++;
                    Console.WriteLine("La contraseña es incorrecta.Intente de nuevo.Intentos restantes: {0}", 5 - contador);
                }
            }

            Console.WriteLine("Intentos agotados.Intenta en otro momento");
        }

        //Juego piedra,papel y tijeras
        public void Ejercicio19()
        {
            Console.WriteLine("Bienvenido al juego piedra,papel o tijeras");

            bool juego = true;

            while (juego)
            {
                Console.WriteLine("Elije que herramienta vas a usar. 'Piedra' 'Papel' o 'Tijera'.Si deseas salir del programa escribe 'Salir'");
                string usuario = Console.ReadLine();

                if (usuario == "Salir")
                {
                    juego = false;
                    Console.WriteLine("Gracias por jugar. ¡Hasta luego!");
                    continue;
                }

                if (usuario != "Piedra" && usuario != "Papel" && usuario != "Tijera")
                {
                    Console.WriteLine("Entrada no válida. Por favor, elige 'Piedra', 'Papel' o 'Tijera'.");
                    continue;
                }
                Random random = new Random();
                int programa = random.Next(0, 3);
                string eleccionPrograma;

                switch (programa)
                {
                    case 0:
                        eleccionPrograma = "Piedra";
                        break;
                    case 1:
                        eleccionPrograma = "Papel";
                        break;
                    case 2:
                        eleccionPrograma = "Tijera";
                        break;
                    default:
                        eleccionPrograma = "";
                        break;

                }
                Console.WriteLine("El programa ha elegido " + eleccionPrograma);

                if (usuario == "Piedra" && eleccionPrograma == "Tijera" || usuario == "Tijera" && eleccionPrograma == "Papel" || usuario == "Papel" && eleccionPrograma == "Piedra")
                {
                    Console.WriteLine("Felicidades.¡Haz Ganado!");
                }
                else if (usuario == "Piedra" && eleccionPrograma == "Piedra" || usuario == "Tijera" && eleccionPrograma == "Tijera" || usuario == "Papel" && eleccionPrograma == "Papel")
                {
                    Console.WriteLine("¡Es un empate!");
                }
                else
                {
                    Console.WriteLine("El programa ha ganado.");
                }



            }
        }
    }
}
