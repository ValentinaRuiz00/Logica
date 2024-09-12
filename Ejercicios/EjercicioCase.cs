using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ejercicios
{
    internal class EjercicioCase
    {
        //Devuelve un dia de la semana
        public void Ejercicio1()
        {
            Console.WriteLine("Ingrese por favor un número del 1 al 7");
            int numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("El día es Lunes");
                    break;
                case 2:
                    Console.WriteLine("El día es Martes");
                    break;
                case 3:
                    Console.WriteLine("El día es miercoles");
                    break;
                case 4:
                    Console.WriteLine("El día es Jueves");
                    break;
                case 5:
                    Console.WriteLine("El día es Viernes");
                    break;
                case 6:
                    Console.WriteLine("El día es Sabado");
                    break;
                case 7:
                    Console.WriteLine("El día ingresado es Domingo");
                    break;
                default:
                    Console.WriteLine("El número ingresado es erroneo");
                    break;
            }
        }

        //Devuelve operaciones matematicas
        public void Ejercicio2()
        {
            Console.WriteLine("Menu de opciones\n" +
                "1.Sumar\n" +
                "2.Restar\n" +
                "3.Multiplicar\n" +
                "4.Dividir"
                );
            int menu = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa por favor el primer número para la operación");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa por favor el segundo número para la operación");
            int num2 = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    int suma;
                    suma = num1 + num2;
                    Console.WriteLine("La suma de los números es de: " + suma);
                    break;
                case 2:
                    int resta;
                    resta = num1 - num2;
                    Console.WriteLine("La resta de los números es de: " + resta);
                    break;
                case 3:
                    int mult;
                    mult = num1 * num2;
                    Console.WriteLine("La multiplicación de los números es de: " + mult);
                    break;
                case 4:
                    int divi;
                    divi = num1 / num2;
                    Console.WriteLine("La division de los números es de: " + divi);
                    break;
                default:
                    Console.WriteLine("La opción ingresada no existe");
                    break;
            }
        }

        //Devuelve una calificacion
        public void Ejercicio3()
        {
            Console.WriteLine("Ingrese por favor una letra de calificación de la A a la E");
            string calificacion = Console.ReadLine();



            switch (calificacion)
            {
                case "A":
                    Console.WriteLine("La calificación es Excelente");
                    break;
                case "B":
                    Console.WriteLine("La calificación es Buena");
                    break;
                case "C":
                    Console.WriteLine("La calificación es Regular");
                    break;
                case "D":
                    Console.WriteLine("La calificación es Mala");
                    break;
                case "E":
                    Console.WriteLine("La calificación es Insuficiente");
                    break;
                default:
                    Console.WriteLine("La calificación ingresada no existe");
                    break;

            }
        }

        //Devuelve los meses del año
        public void Ejercicio4()
        {
            Console.WriteLine("Ingrese por favor un número del 1 al 12 para determinar el mes");
            int mes = int.Parse(Console.ReadLine());
            int año = 2024;
            int dias = 0;
            string nombreMes = "";

            switch (mes)
            {
                case 1:
                    int enero = 1;
                    dias = DateTime.DaysInMonth(año, enero);
                    nombreMes = "Enero";
                    break;
                case 2:
                    int febrero = 2;
                    dias = DateTime.DaysInMonth(año, febrero);
                    nombreMes = "Febrero";
                    break;
                case 3:
                    int marzo = 3;
                    dias = DateTime.DaysInMonth(año, marzo);
                    nombreMes = "Marzo";
                    break;
                case 4:
                    int abril = 4;
                    dias = DateTime.DaysInMonth(año, abril);
                    nombreMes = "Abril";
                    break;
                case 5:
                    int mayo = 5;
                    dias = DateTime.DaysInMonth(año, mayo);
                    nombreMes = "Mayo";
                    break;
                case 6:
                    int junio = 6;
                    dias = DateTime.DaysInMonth(año, junio);
                    nombreMes = "Junio";
                    break;
                case 7:
                    int julio = 7;
                    dias = DateTime.DaysInMonth(año, julio);
                    nombreMes = "Julio";
                    break;
                case 8:
                    int agosto = 8;
                    dias = DateTime.DaysInMonth(año, agosto);
                    nombreMes = "Agosto";
                    break;
                case 9:
                    int septiembre = 9;
                    dias = DateTime.DaysInMonth(año, septiembre);
                    nombreMes = "Septiembre";
                    break;
                case 10:
                    int octubre = 10;
                    dias = DateTime.DaysInMonth(año, octubre);
                    nombreMes = "Octubre";
                    break;
                case 11:
                    int noviembre = 11;
                    dias = DateTime.DaysInMonth(año, noviembre);
                    nombreMes = "Noviembre";
                    break;
                case 12:
                    int diciembre = 12;
                    dias = DateTime.DaysInMonth(año, diciembre);
                    nombreMes = "Diciembre";
                    break;
                default:
                    Console.WriteLine("El mes ingresado no existe");
                    break;
            }

            if (nombreMes != "")
            {
                Console.WriteLine("El nombre del mes es " + nombreMes + " y tiene " + dias.ToString() + " dias");
            }
        }

        //Devuelve la conversion de una moneda
        public void Ejercicio5()
        {
            Console.WriteLine("Convertidor de monedas");
            Console.WriteLine("Escoja la moneda que desea convertir\n" +
                "1.USD a EUR\n" +
                "2.EUR a USD\n" +
                "3.USD a MXN");
            double menu = double.Parse(Console.ReadLine());

            Console.WriteLine("Por favor ingresa el valor de la moneda que desea convertir");
            double moneda = double.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    double eur;
                    eur = moneda * 0.9073;
                    Console.WriteLine("La moneda USD convertida a EUR da un total de: " + eur);
                    break;
                case 2:
                    double usd;
                    usd = moneda / 0.9073;
                    Console.WriteLine("La moneda EUR convertida a USD da un total de: " + usd);
                    break;
                case 3:
                    double mxn;
                    mxn = moneda * 20.10;
                    Console.WriteLine("La moneda USD convertida a MXN da un total de: " + mxn);
                    break;
                default:
                    Console.WriteLine("Opción invalida");
                    break;
            }
        }

        //Devuelve la seleccion de frutas
        public void Ejercicio6()
        {
            Console.WriteLine("Beneficio de las frutas");
            Console.WriteLine("Escoja una de las siguientes frutas para saber su beneficio\n" +
                "1.Manzana\n" +
                "2.Banano\n" +
                "3.Uva\n" +
                "4.Naranja");
            int menu = int.Parse(Console.ReadLine());

            string mensaje = string.Empty;

            switch (menu)
            {
                case 1:
                    mensaje = "La Manzana fortalece el sistema inmune";
                    break;
                case 2:
                    mensaje = "El Banano es una buena fuente de carbohidratos";
                    break;
                case 3:
                    mensaje = "La Uva es beneficiosas para la vista y el funcionamiento del hígado";
                    break;
                case 4:
                    mensaje = "La Naranja es un potente antioxidante.";
                    break;
                default:
                    Console.WriteLine("La opción ingresada es incorrecta");
                    break;
            }

            Console.WriteLine(mensaje);
        }

        //Devuelve la clasificacion de vehiculos
        public void Ejercicio7()
        {
            Console.WriteLine("Escoja uno de los siguientes vehiculos para saber su tipo de combustible\n" +
                "1.Automóvil\n" +
                "2.Motocicleta\n" +
                "3.Bicicleta\n" +
                "4.Camión\n" +
                "5.Autobús");
            int menu = int.Parse(Console.ReadLine());

            string vehiculo = string.Empty;

            switch (menu)
            {
                case 1:
                    vehiculo = "Gasolina";
                    break;
                case 2:
                    vehiculo = "Gasolina";
                    break;
                case 3:
                    vehiculo = "Energía cinetica";
                    break;
                case 4:
                    vehiculo = "Diesel";
                    break;
                case 5:
                    vehiculo = "Diesel";
                    break;
                default:
                    Console.WriteLine("Opción ingresada es incorrecta");
                    break;
            }

            if (vehiculo != "")
            {
                Console.WriteLine("El tipo de combustible que usa el vehiculo es: " + vehiculo);
            }

        }

        //Devuelve descripcion del sigo zodiacal
        public void Ejercicio8()
        {
            Console.WriteLine("Introduca por favor su signo zodiacal, solo la inicial debe ser en mayuscula y no debe contener tildes\n" +
                "Ejemplo: 'Aries'");
            string signo = Console.ReadLine();
            string mensaje = string.Empty;

            switch (signo)
            {
                case "Aries":
                    mensaje = "Eres enérgico, voluntarioso, confiado, impulsivo, ingenioso y testarudo. No has venido aquí para llevar una vida aburrida.";
                    break;
                case "Tauro":
                    mensaje = "Te gustan las cosas bellas, la comodidad y la buena vida. Puedes ser un poco posesivo, pero también fiable, sensual, práctico, artístico y generoso.";
                    break;
                case "Geminis":
                    mensaje = "La información te apasiona. Nunca te cansas de aprender algo nuevo y se puede contar contigo para saber al menos un poco de todo.";
                    break;
                case "Cancer":
                    mensaje = "Eres sensible, romántico, maternal, abnegado, tenaz, precavido, creativo y paciente.";
                    break;
                case "Virgo":
                    mensaje = "Bailas en el continuo entre la soledad y la necesidad de servir a los demás con humildad. Eres una combinación paradójica de sexualidad, fertilidad y pureza.";
                    break;
                case "Leo":
                    mensaje = " Leo es el niño interior y el desarrollo de un fuerte sentido del yo. Creativo y autoexpresivo, Leo entretiene, dirige y enseña.";
                    break;
                case "Libra":
                    mensaje = "A veces complace a la gente, pero también es elegante, justo, cariñoso, creativo, considerado, cooperativo y tiene tacto.";
                    break;
                case "Escorpio":
                    mensaje = "Tu objetivo es nada menos que la transformación y la evolución. La gente suele describirte como intenso, apasionado, perceptivo, creativo, magnético, heroico e incluso competitivo.";
                    break;
                case "Sagitario":
                    mensaje = " Se le conoce como optimista, filosófico, independiente, de mente abierta, atlético y algo arriesgado. Le motiva la necesidad de encontrar la verdad, la sabiduría y el sentido de la vida.";
                    break;
                case "Capricornio":
                    mensaje = "No rehúyes los retos ni el trabajo duro y brillas cuando tienes un objetivo a la vista. Eres ambicioso, dedicado, motivado, decidido, fiable, eficiente y sistemático.";
                    break;
                case "Acuario":
                    mensaje = "Interesado en la reforma social y en hacer del mundo un lugar mejor, no temes que te consideren independiente, excéntrico, previsor, poco convencional o progresista.";
                    break;
                case "Piscis":
                    mensaje = "Debido a tu extrema sensibilidad, puedes perderte consciente o inconscientemente en una idea, causa o persona. Eres adaptable, romántico, devoto, idealista, imaginativo y ¿he dicho psíquico?";
                    break;
                default:
                    Console.WriteLine("Error,solo la inicial debe ser en mayuscula y no debe contener tildes");
                    break;
            }

            Console.WriteLine(signo + " " + mensaje);
        }

        //Devuelve tablas de multiplicar
        public void Ejercicio9()
        {
            Console.WriteLine("Ingrese por favor un número del 1 al 10");
            int num = int.Parse(Console.ReadLine());

            int tabla = 0;


        }
    }
}
