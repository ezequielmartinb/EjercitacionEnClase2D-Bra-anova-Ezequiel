using System;

namespace EjercicioI08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
        
            Escribir un programa que imprima por consola un triángulo como el siguiente:

            *
            ***
            *****
            *******
            *********
        
            */
            int alturaIngresada;
            bool resultadoAlturaIngresada;

            Console.WriteLine("Ingrese la altura del triangulo rectangulo: ");
            resultadoAlturaIngresada = int.TryParse(Console.ReadLine(), out alturaIngresada);

            if (resultadoAlturaIngresada)
            {
                for (int i = 0; i < alturaIngresada; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                        if (j != 0)
                        {
                            Console.Write("*");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
