using System;

namespace Ejercicio3
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
            int opcionIngresada;
            bool resultadoParseNumeroIngresado;

            while(opcionIngresada!=1)
            {
                Console.WriteLine("Ingrese un numero: ");
                resultadoParseNumeroIngresado = int.TryParse(Console.ReadLine(), out numeroIngresado);
                if(resultadoParseNumeroIngresado)
                {
                    Console.WriteLine("Desea seguir ingresado numero?" +
                                      "   ");
                }
                

            }


            Console.WriteLine("Hello World!");
        }
    }
}
