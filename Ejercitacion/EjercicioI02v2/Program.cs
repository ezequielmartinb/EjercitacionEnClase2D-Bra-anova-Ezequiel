using System;
using System.ComponentModel.DataAnnotations;

namespace EjercicioI02v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".
           Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.
           El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
           */

            int numeroIngresado;
            int acumuladorNumerosIngresados = 0;
            bool resultadoParseNumeroIngresado;
            bool deseaContinuar = true;
            int i = 0;

            do
            {
                Console.WriteLine($"Ingrese un numero entero #{i + 1}");
                resultadoParseNumeroIngresado = int.TryParse(Console.ReadLine(), out numeroIngresado);

                if (resultadoParseNumeroIngresado)
                {
                    acumuladorNumerosIngresados += numeroIngresado;
                    deseaContinuar = Validadora.ValidarRespuesta();
                }
                else
                {
                    break;
                }
                i++;

            } while (deseaContinuar == true);

            if (resultadoParseNumeroIngresado)
            {
                Console.WriteLine($"La suma de los numeros ingresados es: {acumuladorNumerosIngresados}");
            }
            else
            {
                Console.WriteLine("NO SE INGRESO UN NUMERO ENTERO VALIDO");
            }
        }
    }
}
