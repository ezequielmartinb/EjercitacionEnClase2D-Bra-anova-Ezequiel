using System;

namespace EjercicioA01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            El factorial de un número es una operación que consiste en multiplicar un numero “n” por 
            todos los números enteros positivos que estén debajo de él, 
            por ejemplo el factorial de 3 es el resultado de multiplicar 3 por 2 por 1.

            En una aplicación de consola, desarrollar un método estático que calcule el factorial de un número dado.
            */
            int numeroEnteroIngresado;
            double factorial;

            Console.WriteLine("Ingrese un numero entero: ");

            if (int.TryParse(Console.ReadLine(), out numeroEnteroIngresado) && numeroEnteroIngresado > 0)
            {
                factorial = Calculadora.CalcularFactorial(numeroEnteroIngresado);
                Console.WriteLine("El factorial de {0} es: {1}", numeroEnteroIngresado, factorial);
            }
            else
            {
                if(numeroEnteroIngresado < 0)
                {
                    Console.WriteLine("ERROR. NO SE PUEDE CALCULAR EL FACTORIAL DE UN NUMERO NEGATIVO");
                }
                else
                {
                    Console.WriteLine("ERROR. NO SE INGRESO UN NUMERO ENTERO");
                }
            }
        }
    }
}
