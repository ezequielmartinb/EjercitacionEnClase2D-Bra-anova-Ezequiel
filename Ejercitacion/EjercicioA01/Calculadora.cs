using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioA01
{
    public class Calculadora
    {
        public static double CalcularFactorial(int numeroEntero)
        {
            double factorial = 1;

            for (int i = numeroEntero; i > 0; i--)
            {
                if (numeroEntero == 1)
                {
                    break;
                }
                if (i == numeroEntero)
                {
                    factorial *= numeroEntero;
                }
                else
                {
                    factorial *= i;
                }

            }

            return factorial;
        }
    }
}
