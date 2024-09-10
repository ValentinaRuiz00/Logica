using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class EjercicioParametro
    {
        //Devuelve si un número es par o impar
        public void Ejercicio1()
        {
            Console.WriteLine("Ingrese un numero por favor");
            int Numero = int.Parse(Console.ReadLine());

            if (Numero % 2 == 0)
            {
                Console.WriteLine("El número ingresado es par");
            }
            else
            {
                Console.WriteLine("El número ingresado es impar");
            }

        }

        //Devuelve si un año es bisiesto 
        public void Ejercicio2()
        {
            Console.WriteLine("Ingrese por favor un año");
            int año = int.Parse(Console.ReadLine());

            if (año % 4 == 0)
            {
                Console.WriteLine("El año " + año + " es bisiesto");
            }
            else
            {
                Console.WriteLine("El año " + año + " no es bisiesto");
            }
        }

        //Devuelve grados celsius a fahrenheit
        public void Ejercicio3()
        {
            Console.WriteLine("Ingrese por favor una temperatura en grados celsius");
            double temperatura = double.Parse(Console.ReadLine());

            double fahrenheit;

            fahrenheit = (temperatura * 9 / 5) + 32;

            Console.WriteLine("La temperatura en celsius " + temperatura + " convertida a fahrenheit es: " + fahrenheit);
        }

        //Devuelve si el numero ingresado es primo o compuesto
        public void Ejercicio4()
        {
            Console.WriteLine("Ingrese por favor un número.");
            int numero = int.Parse(Console.ReadLine());

            bool Bandera = false;

            if (numero == 2 || numero == 3 || numero == 5)
            {
                Bandera = true;

            }
            else if (numero % 2 != 0 && numero % 3 != 0 && numero % 5 != 0)
            {
                Bandera = true;
            }
            if (Bandera == true)
            {
                Console.WriteLine("El número " + numero + " es primo.");
            }
            else
            {
                Console.WriteLine("El número " + numero + " es compuesto.");
            }
        }

        //Devuelve la potencia de un numero
        public void Ejercicio5()
        {
            Console.WriteLine("Ingrese por favor un número");
            int numero = int.Parse(Console.ReadLine());

            int resultado;

            resultado = numero * numero;

            Console.WriteLine("La potencia de " + numero + " es: " + resultado);
        }

        //Devuelve la longitud de una cadena
        public void Ejercicio6()
        {
            Console.WriteLine("Ingresa por favor una cadena de texto");
            string cadena = Console.ReadLine();

            int longitud;

            longitud = cadena.Length;

            Console.WriteLine("La longitud de la cadena " + cadena + " es de: " + longitud);
        }

        //Devuelve la raiz de un número
        public void Ejercicio7()
        {
            Console.WriteLine("Ingrese por favor un número");
            double numero = double.Parse(Console.ReadLine());

            double raiz;

            raiz = Math.Sqrt(numero);

            Console.WriteLine("La raiz cuadrada de " + numero + " es: " + raiz);
        }

        //Devuelve si el caracter es una vocal o consonante
        public void Ejercicio8()
        {
            Console.WriteLine("Ingrese por favor una letra");
            string letra = Console.ReadLine();

            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
            {
                Console.WriteLine("La letra " + letra + " es una vocal.")
;
            }
            else
            {
                Console.WriteLine("La letra " + letra + " es una consonante");
            }
        }

        // Devuelve el numero de digitos de un entero
        public void Ejercicio9()
        {

            Console.WriteLine("Ingrese por favor un número entero");
            int numero = int.Parse(Console.ReadLine());

            int resultado;
            string auxiliar;

            resultado = Math.Abs(numero);
            auxiliar = resultado.ToString();
            resultado = auxiliar.Length;

            Console.WriteLine("El número de digitos del entero " + numero + " es: " + resultado);

        }

        //Devuelve la suma de dos numeros
        public void Ejercicio10()
        {
            Console.WriteLine("Ingrese por favor el primer número");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese por favor el segundo número");
            int num2 = int.Parse(Console.ReadLine());

            int suma;

            suma = num1 + num2;

            Console.WriteLine("La suma de los números es: " + suma);
        }

        // devuelve el mayor de los 3 numeros
        public void Ejercicio11()
        {
            Console.WriteLine("Ingrese por favor el primer número");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese por favor el segundo número");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrse por favor el tercer número");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("El número " + num1 + " es el mayor");
            }
            else if (num2 > num3)
            {
                Console.WriteLine("El número " + num2 + " es el mayor");
            }
            else
            {
                Console.WriteLine("El número " + num3 + " es el mayor");
            }


        }

        //Devuelve el area de un triangulo
        public void Ejercicio12()
        {
            Console.WriteLine("Ingrese por favor la base de un triangulo");
            decimal baseT = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese por favor la altura de un triangulo");
            decimal altura = decimal.Parse(Console.ReadLine());

            decimal area;
            area = (baseT * altura) / 2;

            Console.WriteLine("El area del triangulo es: " + area);

        }

        //Devuelve el perimetro de un rectangulo
        public void Ejercicio13()
        {
            Console.WriteLine("Ingrese por favor el largo de un rectangulo");
            decimal largo = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese por favor la altura del rectanguo");
            decimal altura = decimal.Parse(Console.ReadLine());

            decimal perimetro;

            perimetro = 2 * (altura + largo);

            Console.WriteLine("El perimetro del rectangulo es: " + perimetro);
        }

        //Devuelve el promedio de cuatro numeros
        public void Ejercicio14()
        {
            Console.WriteLine("Ingrese por favor el primer número");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese por favor el segundo número");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese por favor el tercer número");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese por favor el cuarto número");
            int num4 = int.Parse(Console.ReadLine());

            decimal promedio;

            promedio = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine("El promedio de los números es de: " + promedio);
        }

        //Devuelve horas a minutos
        public void Ejercicio15()
        {
            Console.WriteLine("Ingrese por favor una hora");
            decimal hora = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese por favor los minutos");
            decimal minuto = decimal.Parse(Console.ReadLine());

            decimal solucion;

            solucion = hora * 60;
            solucion = solucion + minuto;

            Console.WriteLine("La hora ingresada convertida a minutos es: " + solucion);
        }

        //Devuelve el cuadrante de un punto
        public void Ejercicio16()
        {
            Console.WriteLine("Ingresa por favor la coordenada X");
            int X = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa por favor la coordenada Y");
            int Y = int.Parse(Console.ReadLine());

            if (X > 0 && Y > 0)
            {
                Console.WriteLine("El cuadrante del punto esta entre el angulo 0 a 90");
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine("El cuadrante del punto esta entre el angulo 90 a 180");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("El cuadrante del punto esta entre el angulo 180 a 270");
            }
            else
            {
                Console.WriteLine("El cuadrante del punto esta entre el angulo 270 a 360");
            }
        }

        //Devuelve la comparacion de dos cadenas de texto
        public void Ejercicio17()
        {
            Console.WriteLine("Ingrese la primera cadena de texto");
            string cadena1 = Console.ReadLine();

            Console.WriteLine("Ingrese la segunda cadena de texto");
            string cadena2 = Console.ReadLine();

            if (cadena1 == cadena2)
            {
                Console.WriteLine("Las cadenas de texto son iguales");
            }
            else
            {
                Console.WriteLine("Las cadenas de texto son diferentes");
            }
        }

        //Devuelve el tipo de triangulo
        public void Ejercicio18()
        {
            Console.WriteLine("Ingrese por favor el primer lado del triangulo");
            decimal num1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese por favor el segundo lado del triangulo");
            decimal num2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese por favor el tercer lado del triangulo");
            decimal num3 = decimal.Parse(Console.ReadLine());

            if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine("El triangulo es un equilatero");
            }
            else if (num1 != num2 && num2 != num3 && num3 != num1)
            {
                Console.WriteLine("El triangulo es un escaleno");
            }
            else
            {
                Console.WriteLine("El triangulo es un isosceles");
            }
        }

        //Devuelve un intercambio de valores 
        public void Ejercicio19()
        {
            Console.WriteLine("Ingrese por favor el primer valor");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese por favor el segundo valor");
            int valor2 = int.Parse(Console.ReadLine());

            int intercambio = valor1;

            valor1 = valor2;
            valor2 = intercambio;

            Console.WriteLine("El primer valor es: " + valor1 + " y el segundo valor es: " + valor2);


        }

        //Devuelve el area de un circulo
        public void Ejercicio20()
        {
            Console.WriteLine("Ingrese el radio de un circulo");
            double radio = double.Parse(Console.ReadLine());

            double area;

            area = Math.PI * (radio * radio);

            Console.WriteLine("El area del circulo es: " + area);
        }

        //Devuelve conversion de temperaturas
        public void Ejercicio21()
        {
            Console.WriteLine("Ingrese una temperatura en grados celsius");
            double temperatura_cels = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese una temperatura en grados fahrenheit");
            double temperatura_fah = int.Parse(Console.ReadLine());

            double conversion_cels;
            double conversion_fah;

            conversion_cels = (temperatura_fah - 32) / 1.8;
            conversion_fah = (temperatura_cels * 9 / 5) + 32;

            Console.WriteLine("La temperatura Celsius a fahrenheit es de: " + conversion_fah + " y la temperatura fahrenheit a Celsius es de: " + conversion_cels);


        }

        //Devuelve la validacion de una fecha
        public void Ejercicio22()
        {
            Console.WriteLine("Validación de una fecha");

            Console.WriteLine("Ingrese un día");
            int dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un mes");
            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un año");
            int año = int.Parse(Console.ReadLine());

            if (dia > 0 && dia <= 31)
            {
                if (mes > 0 && mes <= 12)
                {
                    if (año > 100 && año < 10000)
                    {
                        try
                        {
                            // Intenta construir la fecha con los valores ingresados
                            DateTime fecha = new DateTime(año, mes, dia);
                            Console.WriteLine("La fecha es válida: " + fecha.ToShortDateString());
                        }
                        catch (Exception)
                        {
                            // Captura cualquier excepción si la fecha no es válida, como un 30 de febrero
                            Console.WriteLine("Fecha inválida.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Año no valido");
                    }
                }
                else
                {
                    Console.WriteLine("Mes no valido");
                }
            }
            else
            {
                Console.WriteLine("Día no valido");
            }

        }

        //Devuelve el valor de la diferencia
        public void Ejercicio23()
        {
            Console.WriteLine("Ingrese por favor el primer número de la diferencia");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese por favor el segundo número de la diferencia");
            int num2 = int.Parse(Console.ReadLine());

            int diferencia;

            diferencia = Math.Abs(num1 - num2);

            Console.WriteLine("La diferencia de los números es de: " + diferencia);
        }

        //Devuelve la suma y producto de dos numeros
        public void Ejercicio24()
        {
            Console.WriteLine("Ingrese el primer numero");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            int suma;
            int multip;

            suma = num1 + num2;
            multip = num1 * num2;

            Console.WriteLine("La suma de los números es de: " + suma + ", el producto de los números es de: " + multip);


        }


    }

}
