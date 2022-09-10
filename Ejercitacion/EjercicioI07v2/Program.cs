using System;

namespace EjercicioI07v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.
            El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y 
            usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.
            Mostrar el resultado en la consola.


            */
            double baseTriangulo = PedirDatos.PedirNumerosEnteros("Ingrese la base en cm: ");
            double alturaTriangulo = PedirDatos.PedirNumerosEnteros("Ingrese la altura en cm: ");
            double hipotenusa;

            if (baseTriangulo != -1 && alturaTriangulo != -1)
            {
                Console.WriteLine("{0} - {1}", baseTriangulo, alturaTriangulo);
                hipotenusa = TeoremaDePitagoras.FormulaMatematica(baseTriangulo, alturaTriangulo);
                Console.WriteLine("La hipotenusa de {0} cm de Base y {1} cm de Altura es: {2} cm", baseTriangulo, alturaTriangulo, hipotenusa);
            }
            else
            {
                Console.WriteLine("LA ALTURA O BASE INGRESADA ES ERRONEA");
            }


        }
    }
}
