
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

            for (int contador = 0; contador < 2; contador++)
            {
                Console.WriteLine("Ingrese el número entero");
                numero1[contador] = int.Parse(Console.ReadLine());


            }
            for (int contador = 0; contador < numero1.Length; contador++)
            {
                Console.WriteLine(numero1[contador]);
            }


        }


    }
}
