using System;

namespace Ejercitacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ingresar 5 números por consola, guardándolos en una variable escalar.
            // Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.

            int numeroIngresado;
            int acumuladorNumerosIngresados = 0;
            int flagMaximo = 0;
            int flagMinimo = 0;
            int flagError = 0;
            int maximoNumeroIngresado = 0;
            int minimoNumeroIngresado = 0;
            float promedioNumerosIngresados;
            bool resultadoParseNumeroIngresado;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese un numero entero #{i + 1}: ");

                resultadoParseNumeroIngresado = int.TryParse(Console.ReadLine(), out numeroIngresado);
                if (resultadoParseNumeroIngresado == true)
                {
                    acumuladorNumerosIngresados = numeroIngresado + acumuladorNumerosIngresados;
                    if (flagMaximo == 0 || maximoNumeroIngresado < numeroIngresado)
                    {
                        flagMaximo = 1;
                        maximoNumeroIngresado = numeroIngresado;
                    }
                    else
                    {
                        if (flagMinimo == 0 || minimoNumeroIngresado > numeroIngresado)
                        {
                            flagMinimo = 1;
                            minimoNumeroIngresado = numeroIngresado;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ERROR. NO INGRESO UN NUMERO ENTERO.");
                    flagError = 1;
                    break;
                }
            }

            if (flagError == 0)
            {
                promedioNumerosIngresados = (float)acumuladorNumerosIngresados / 5;

                Console.WriteLine($"El promedio es: {promedioNumerosIngresados}");
                Console.WriteLine($"El numero maximo es: {maximoNumeroIngresado}");
                Console.WriteLine($"El numero minimo es: {minimoNumeroIngresado}");
            }









        }
    }
}
