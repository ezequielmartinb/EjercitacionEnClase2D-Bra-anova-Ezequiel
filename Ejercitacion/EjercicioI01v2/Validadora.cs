using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI01v2
{
    internal class Validadora
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool validado = false;

            if (valor >= min && valor <= max)
            {
                validado = true;
            }

            return validado;
        }
    }
}
