using System;

namespace EjercicioA01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * El factorial de un número es una operación que consiste en multiplicar un numero “n” por todos 
             * los números enteros positivos que estén debajo de él, 
             * 
             * por ejemplo el factorial de 3 es el resultado de multiplicar 3 por 2 por 1.

               En una aplicación de consola, desarrollar un método estático que calcule el factorial de un número dado.
             */

            int numeroIngresado;
            double resultadoFactorial;
            bool resultadoNumeroEnteroParseado;

            Console.WriteLine("Ingrese un numero entero: ");
            resultadoNumeroEnteroParseado = int.TryParse(Console.ReadLine(), out numeroIngresado);

            if(resultadoNumeroEnteroParseado)
            {
                resultadoFactorial=Calculadora.CalcularFactorial(numeroIngresado);
                if(resultadoFactorial!=-1)
                {
                    Console.WriteLine($"El resultado del factorial de {numeroIngresado} es: {resultadoFactorial}");
                }
                else
                {
                    Console.WriteLine("No se puede calcular el factorial de un numero negativo");
                }
                
            }
            else
            {
                Console.WriteLine("No se ingreso un numero valido");
            }

        }
    }
}
