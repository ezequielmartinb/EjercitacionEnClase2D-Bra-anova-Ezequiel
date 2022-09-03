using System;

namespace EjercicioI02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar un número y mostrar el cuadrado y el cubo del mismo.
            //Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".

            int numeroIngresado;
            double numeroIngresadoAlCuadrado;
            double numeroIngresadoAlCubo;
            bool resultadoParseNumeroIngresado;

            Console.WriteLine("Ingrese un numero entero: ");
            resultadoParseNumeroIngresado = int.TryParse(Console.ReadLine(), out numeroIngresado);

            if (resultadoParseNumeroIngresado && numeroIngresado > 0)
            {
                numeroIngresadoAlCuadrado = Math.Pow(numeroIngresado, 2);
                numeroIngresadoAlCubo = Math.Pow(numeroIngresado, 3);
                Console.WriteLine($"El numero {numeroIngresado} al cuadrado es: {numeroIngresadoAlCuadrado}{Environment.NewLine}" +
                                  $"El numero {numeroIngresado} al cubo es: {numeroIngresadoAlCubo}");
            }
            else
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }
        }
    }
}
