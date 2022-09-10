using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI07v2
{
    public class TeoremaDePitagoras
    {
        public static double FormulaMatematica(double baseTriangulo, double alturaTriangulo)
        {
            double resultadoCatetos;
            double alturaTrianguloAlCuadrado;
            double baseTrianguloAlCuadrado;
            double resultadoHipotenusa;

            alturaTrianguloAlCuadrado = Math.Pow(alturaTriangulo, 2);
            baseTrianguloAlCuadrado = Math.Pow(baseTriangulo, 2);

            resultadoCatetos = baseTrianguloAlCuadrado + alturaTrianguloAlCuadrado;
            resultadoHipotenusa = Math.Sqrt(resultadoCatetos);

            return resultadoHipotenusa;
        }
    }
}
