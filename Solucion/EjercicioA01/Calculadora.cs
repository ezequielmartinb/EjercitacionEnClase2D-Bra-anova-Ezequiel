using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioA01
{
    public class Calculadora
    {
        public static double CalcularFactorial(int numeroIngresado)
        {
            double resultadoFactorial = 1;

            if (numeroIngresado >= 0)
            {
                for (int i = 1; i <= numeroIngresado; i++)
                {
                    resultadoFactorial *= i;
                }
            }
            else
            {
                resultadoFactorial = -1;
            }
            
            return resultadoFactorial;
        }
    }
}
