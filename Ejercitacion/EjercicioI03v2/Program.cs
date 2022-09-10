using System;

namespace EjercicioI03v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroEntero = 85;
            string numeroEnBinario;
            double numeroEnDecimal;
            int numeroBinario = 10010101;

            numeroEnBinario = Conversor.ConvertirDecimalABinario(numeroEntero);
            numeroEnDecimal = Conversor.ConvertirBinarioADecimal(numeroBinario);

            if (numeroEnBinario == "")
            {
                Console.WriteLine("No se puede convertir en binario un numero negativo");
            }
            else
            {
                Console.WriteLine("El numero {0} en binario es: {1}", numeroEntero, numeroBinario);
            }
            if (numeroEnDecimal != 0)
            {
                Console.WriteLine("El numero {0} en decimal es: {1}", numeroBinario, numeroEnDecimal);
            }
            else
            {
                Console.WriteLine("No se puede convertir en binario un numero negativo");
            }
        }
    }
}
