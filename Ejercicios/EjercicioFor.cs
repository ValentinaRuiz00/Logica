﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class EjercicioFor
    {
        //devuelve los numeros del 1 al 10
        public void Ejercicio1()
        {
            Console.WriteLine("Numeros del 1 al 10");

            int numeros = 0;
            for (numeros = 1; numeros <= 10; numeros = numeros + 1)
            {
                Console.WriteLine(numeros);
            }
        }

        //devuelve la suma de los primeros 10 numeros
        public void Ejercicio2()
        {
            Console.WriteLine("Suma de los primeros 10 numeros");

            int numeros = 0;
            int suma = 0;

            for (numeros = 1; numeros <= 10; numeros = numeros + 1)
            {
                suma += numeros;
            }

            Console.WriteLine("La suma de los primeros 10 números es: " + suma);


        }

        //devuelve tabla de multiplicar
        public void Ejercicio3()
        {
            Console.WriteLine("Tabla de multiplicar del 5");

            int numero = 0;
            int multiplicacion = 5;
            int resultado = 0;

            for (numero = 1; numero <= 10; numero = numero + 1)
            {
                resultado = multiplicacion * numero;
                Console.WriteLine(multiplicacion + " * " + numero + " = " + resultado);
            }

        }

        //devuelve los numeros del 10 al 1
        public void Ejercicio4()
        {
            Console.WriteLine("Numeros del 10 al 1");

            int numero;

            for (numero = 10; numero >= 1; numero = numero - 1)
            {
                Console.WriteLine(numero);
            }
        }

        //devuelve los numeros pares del 1 al 20
        public void Ejercicio5()
        {
            Console.WriteLine("Numeros pares");

            int numero;

            for (numero = 1; numero <= 20; numero = numero + 1)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero);
                }
            }
        }

        //devuelve el factorial de un numero
        public void Ejercicio6()
        {
            Console.WriteLine("Ingrese por favor un numero para saber su factorial");
            int numero = int.Parse(Console.ReadLine());

            int contador;
            int resutado = 1;

            for (contador = 1; contador <= numero; contador++)
            {
                resutado = resutado * contador;
            }
            Console.WriteLine("El factorial del número es: " + resutado);

        }

        //devuelve los numeros impares
        public void Ejercicio7()
        {
            Console.WriteLine("Numeros impareas entre 1 y 50");

            int numero;
            for (numero = 1; numero <= 50; numero++)
            {
                if (numero % 2 != 0)
                {
                    Console.WriteLine(numero);
                }
            }
        }

        //devuelve la serie fobonacci
        public void Ejercicio8()
        {
            Console.WriteLine("Serie Fibonacci");

            int contador;
            int numero = 0;
            int numero2 = 1;
            int suma;

            for (contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine(numero);
                suma = numero;
                numero = numero2;
                numero2 = suma + numero2;
            }
        }

        //devuelve el promedio de numeros
        public void Ejercicio9()
        {
            int contador;
            int suma = 0;
            int promedio;
            int numero;

            for (contador = 1; contador <= 5; contador++)
            {
                Console.WriteLine("Ingrese por favor un numero");
                numero = int.Parse(Console.ReadLine());

                suma += numero;

            }
            promedio = suma / 5;

            Console.WriteLine("El promedio de los cinco números es: " + promedio);
        }

        //devuelve el cuadrado de un numero
        public void Ejercicio10()
        {
            Console.WriteLine("Cuadrado de un numero");

            int numero;
            int resultado;

            for (numero = 1; numero <= 10; numero++)
            {
                resultado = numero * numero;
                Console.WriteLine(numero + " * " + numero + " = " + resultado);
            }
        }

        //devuelve los numeros de un arreglo
        public void Ejercicio11()
        {
            int[] numeros = { 20, 30, 12 };

            for (int contador = 0; contador < numeros.Length; contador++)
            {
                Console.WriteLine(numeros[contador]);
            }
        }

        //devuelve la multiplicacion de un arreglo
        public void Ejercicio12()

        {

            int[] numero1 = new int[2];
            int[] numero2 = new int[2];
            int[] multiplicacion = new int[2];
            int resultado = 1;
            int resultado2 = 1;

            for (int contador = 0; contador < 2; contador++)
            {
                Console.WriteLine("Ingrese el número entero en la posición " + (contador + 1));
                numero1[contador] = int.Parse(Console.ReadLine());
            }

            for (int contador = 0; contador < 2; contador++)
            {
                Console.WriteLine("Ingrese el número entero en la posición " + (contador + 1));
                numero2[contador] = int.Parse(Console.ReadLine());
            }

            for (int contador = 0; contador < 2; contador++)
            {
                multiplicacion[contador] = numero1[contador] * numero2[contador];
                Console.WriteLine("Los numeros " + numero1[contador] + " * " + numero2[contador] + " es igual a: " + multiplicacion[contador]);
            }

            for (int contador = 0; contador < 2; contador++)
            {
                resultado = resultado * numero1[contador];
                resultado2 = resultado2 * numero2[contador];
            }

            Console.WriteLine("Los números " + numero1[0] + " * " + numero1[1] + " es igual a: " + resultado);
            Console.WriteLine("Los números " + numero2[0] + " * " + numero2[1] + " es igual a: " + resultado2);

        }

        //devuelve si un numero es primo
        public void Ejercicio13()
        {
            Console.WriteLine("Ingrese por favor un número para determinar si es primo");
            int numero = int.Parse(Console.ReadLine());
            bool bandera = false;
            int residuo = 2;
            if (numero == 1)
            {
                Console.WriteLine("El número ingresado debe ser mayor a uno.");

            }

            if (numero == 2)
            {
                bandera = true;
            }

            for (int contador = 0; contador < residuo; contador++)
            {
                if (numero % residuo == 0 && numero > 2)
                {
                    bandera = false;

                }
                else
                {
                    bandera = true;
                }
            }
            if (bandera == true)
            {
                Console.WriteLine("El número ingresado es primo");
            }
            if (bandera == false)
            {
                Console.WriteLine("El número ingresado es compuesto");
            }

        }

        //Devuelve la cantidad de vocales
        public void Ejercicio14()
        {
            Console.WriteLine("Ingrese por favor una cadena de texto");
            string cadena = Console.ReadLine();
            int cantidad = 0;

            for (int contador = 0; contador < cadena.Length; contador++)
            {
                char letra = cadena[contador];
                if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u' ||
                    letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
                {
                    cantidad++;
                }
            }
            Console.WriteLine(cantidad);
        }

        //devuelve una cadena invertida
        public void Ejercicio15()
        {
            Console.WriteLine("Ingrese por favor una cadena");
            string cadena= Console.ReadLine();
            char[] caracteres = cadena.ToCharArray();
            int UltLetra = cadena.Length - 1;

            for (int contador = 0; contador < UltLetra; contador++)
            {
                char temp = caracteres[contador];
                caracteres[contador] = caracteres[UltLetra - contador];
                caracteres[UltLetra - contador] = temp;
            }

            string cadenaInvertida = new string(caracteres);

            Console.WriteLine(cadenaInvertida);
        }


    }
}
