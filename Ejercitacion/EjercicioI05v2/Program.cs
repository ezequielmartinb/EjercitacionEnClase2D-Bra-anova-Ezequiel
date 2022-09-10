using System;

namespace EjercicioI05v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tabla;
            int numeroEntero;
            Console.Write("Ingrese un numero entero: ");

            if (int.TryParse(Console.ReadLine(), out numeroEntero))
            {
                tabla = Tabla.PedirTablaMultiplicacion(numeroEntero);
                Console.WriteLine("{0}", tabla);
            }
            else
            {
                Console.WriteLine("NO SE INGRESO UN NUMERO VALIDO");
            }
        }
    }
}
