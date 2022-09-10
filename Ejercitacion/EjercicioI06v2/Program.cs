using System;

namespace EjercicioI06v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase (estáticos) que realicen el cálculo del área que corresponda:

            public double CalcularAreaCuadrado(double longitudLado) {}

            public double CalcularAreaTriangulo(double base, double altura) {}

            public double CalcularAreaCirculo(double radio) {}

            El ingreso de los datos como la visualización se deberán realizar desde el método Main().
            */

            double areaCirculo = CalculadoraDeArea.CalcularAreaCirculo(50);
            double areaCuadrado = CalculadoraDeArea.CalcularAreaCuadrado(72);
            double areaTriangulo = CalculadoraDeArea.CalcularAreaTriangulo(4, 2);

            Console.WriteLine($"El area del circulo es: {areaCirculo}{Environment.NewLine}" +
                              $"El area del cuadrado es: {areaCuadrado}{Environment.NewLine}" +
                              $"El area del cuadrado es: {areaTriangulo}");
        }
    }
}
