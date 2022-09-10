using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI07v2
{
    public class PedirDatos
    {
        public static double PedirNumerosEnteros(string mensaje)
        {
            double entero;

            Console.WriteLine(mensaje);

            if (double.TryParse(Console.ReadLine(), out entero) == false)
            {
                entero = -1;
            }
            return entero;
        }
    }
}
