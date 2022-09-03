using System;

namespace EjercicioI04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.
            El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
            Escribir una aplicación que encuentre los 4 primeros números perfectos.
            */
            double resultadoPrimeraPotencia;
            double resultadoSegundaPotencia;
            double esNumeroPerfecto;
            int contador = 0;
            int i = 0;

            do
            {
                resultadoPrimeraPotencia = Math.Pow(2, (i - 1));
                resultadoSegundaPotencia = Math.Pow(2, i);
                resultadoSegundaPotencia--;
                esNumeroPerfecto = resultadoPrimeraPotencia * resultadoSegundaPotencia;

                if (resultadoSegundaPotencia % 2 != 0 && i % 2 != 0)
                {
                    Console.WriteLine($"EL NUMERO {i} ES UN NUMERO PERFECTO Y EL RESULTADO ES {esNumeroPerfecto}");
                    contador++;
                }
                i++;
            } while (contador != 4);
        }
    }
}
