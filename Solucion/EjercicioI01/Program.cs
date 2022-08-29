using System;
using System.Runtime.Intrinsics.Arm;

namespace Clase2
{
    internal class Program
    {
        /*
        *   1) Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:
            bool Validar(int valor, int min, int max)

            •	valor: dato a validar.
            •	min: mínimo valor incluido.
            •	max: máximo valor incluido.

            Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.
            Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
        * 
        */
        public static void Main(string[] args)
        {

            int[] numeros = new int[10];
            bool resultadoParseNumeroIngresado = false;
            bool resultadoValidar;
            bool flagPrimero = true;
            int acumuladorNumeros = 0;
            int numeroMinimo = 0;
            int numeroMaximo = 0;
            float promedioNumerosIngresados;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Ingrese un numero entero #{i + 1}");
                resultadoParseNumeroIngresado = int.TryParse(Console.ReadLine(), out numeros[i]);
                acumuladorNumeros += numeros[i];

                if (resultadoParseNumeroIngresado == false)
                {
                    Console.WriteLine("Error. Numero ingresado invalido");
                    break;
                }
                else
                {
                    if (flagPrimero || numeros[i] < numeroMinimo)
                    {
                        numeroMinimo = numeros[i];
                    }
                    if (flagPrimero || numeros[i] > numeroMaximo)
                    {
                        numeroMaximo = numeros[i];
                    }
                    flagPrimero = false;
                }
            }
            if (resultadoParseNumeroIngresado)
            {
                for (int i = 0; i < numeros.Length; i++)
                {
                    resultadoValidar = Validador.Validar(numeros[i], -100, 100);
                    if (resultadoValidar)
                    {
                        Console.WriteLine($"El numero ingresado #{i + 1}: {numeros[i]} esta dentro del rango");
                    }
                    else
                    {
                        Console.WriteLine($"El numero ingresado #{i + 1}: {numeros[i]} no está dentro del rango");
                    }
                }
                promedioNumerosIngresados = (float)acumuladorNumeros / 10;

                Console.WriteLine($"{Environment.NewLine}El numero minimo ingresado es: {numeroMinimo}{Environment.NewLine}" +
                                  $"El numero maximo ingresado es: {numeroMaximo}{Environment.NewLine}" +
                                  $"El promedio de los numeros ingresados es: {promedioNumerosIngresados}");
            }



        }
    }
}