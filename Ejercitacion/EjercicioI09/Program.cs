using System;

namespace EjercicioI09
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
