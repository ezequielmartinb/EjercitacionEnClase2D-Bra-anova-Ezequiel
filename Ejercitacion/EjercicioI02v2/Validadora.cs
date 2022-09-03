using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI02v2
{
    internal class Validadora
    {
        public static bool ValidarRespuesta()
        {
            bool validacion;
            char respuestaIngresada;

            Console.WriteLine("Desea continuar? S/N");
            validacion = char.TryParse(Console.ReadLine(), out respuestaIngresada);

            if (respuestaIngresada == 'S')
            {
                validacion = true;
            }
            else
            {
                validacion = false;
            }


            return validacion;

        }
    }
}
