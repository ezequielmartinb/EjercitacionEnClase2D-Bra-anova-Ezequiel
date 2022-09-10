using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI05v2
{
    public class Tabla
    {
        public static string PedirTablaMultiplicacion(int numeroEntero)
        {
            StringBuilder sb = new StringBuilder();
            string tablaGenerada;
            int resultadoMultiplicacion;
            sb.AppendLine($"Tabla de multiplicar del numero {numeroEntero}");

            for (int i = 0; i < 9; i++)
            {
                resultadoMultiplicacion = numeroEntero * (i + 1);
                sb.AppendLine($"{numeroEntero} x {i + 1} = {resultadoMultiplicacion}");
            }
            tablaGenerada = sb.ToString();

            return tablaGenerada;
        }
    }
}
