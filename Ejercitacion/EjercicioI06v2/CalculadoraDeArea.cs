using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjercicioI06v2
{
    public class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLadoCuadrado)
        {
            double areaCuadrado = longitudLadoCuadrado * 4;

            return areaCuadrado;
        }

        public static double CalcularAreaTriangulo(double baseTriangulo, double alturaTriangulo)
        {
            double areaTriangulo = baseTriangulo * alturaTriangulo;

            return areaTriangulo;
        }

        public static double CalcularAreaCirculo(double radioCirculo)
        {
            double areaCirculo = Math.PI * Math.Pow(radioCirculo, 2);

            return areaCirculo;
        }
    }
}
