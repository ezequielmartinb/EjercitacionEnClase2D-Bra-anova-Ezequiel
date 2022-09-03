using System;

namespace EjercicioI03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

         Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

         Validar que el dato ingresado por el usuario sea un número.

         Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

         Si ingresa "salir", cerrar la consola.

         Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.              

          */

            int numeroIngresado;
            string numeroPrimoIngresado = "";
            string totalNumerosPrimosIngresados = "";
            int opcionIngresada = 0;
            bool resultadoParseNumeroIngresado;
            bool resultadoParseOpcionIngresada;

            while (opcionIngresada != 2)
            {
                Console.WriteLine("Ingrese un numero: ");
                resultadoParseNumeroIngresado = int.TryParse(Console.ReadLine(), out numeroIngresado);

                if (resultadoParseNumeroIngresado)
                {
                    if (numeroIngresado % 2 != 0)
                    {

                        numeroPrimoIngresado = numeroIngresado.ToString();

                        if (opcionIngresada == 0)
                        {
                            totalNumerosPrimosIngresados = string.Copy(totalNumerosPrimosIngresados);
                        }
                        totalNumerosPrimosIngresados = String.Concat(totalNumerosPrimosIngresados, " ", numeroPrimoIngresado);

                        Console.WriteLine($"El numero {numeroIngresado} es primo{Environment.NewLine}");
                    }
                    Console.WriteLine($"Desea seguir ingresado numero? {Environment.NewLine}" +
                                     $"1) SEGUIR INGRESAR NUMERO{Environment.NewLine}" +
                                     $"2) SALIR{Environment.NewLine}");
                    resultadoParseOpcionIngresada = int.TryParse(Console.ReadLine(), out opcionIngresada);

                    while (resultadoParseOpcionIngresada == false || opcionIngresada < 1 || opcionIngresada > 2)
                    {
                        Console.WriteLine("ERROR. OPCION INVALIDA");
                        Console.WriteLine($"Desea seguir ingresado numero? {Environment.NewLine}" +
                                     $"1) SEGUIR INGRESAR NUMERO{Environment.NewLine}" +
                                     $"2) SALIR{Environment.NewLine}");
                        resultadoParseOpcionIngresada = int.TryParse(Console.ReadLine(), out opcionIngresada);
                    }
                }
                else
                {
                    Console.WriteLine("ERROR. NO INGRESO UN NUMERO");
                }
            }
            Console.WriteLine("Los numeros primos ingresados son: {0}", totalNumerosPrimosIngresados);
        }
    }
}
