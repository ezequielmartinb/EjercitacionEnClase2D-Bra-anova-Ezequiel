using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI03v2
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string numeroBinario = "";

            while (numeroEntero > 0)
            {
                if (numeroEntero % 2 == 0)
                {
                    numeroBinario = "0" + numeroBinario;
                }
                else
                {
                    numeroBinario = "1" + numeroBinario;
                }
                numeroEntero = numeroEntero / 2;
            }

            return numeroBinario;
        }

        public static double ConvertirBinarioADecimal(int numeroEntero)
        {
            int potencia;
            double numeroEnDecimal = 0;
            string numeroIngresado = Convert.ToString(numeroEntero);
            char[] cadenaNumeros = numeroIngresado.ToCharArray();

            for (int i = 0; i < numeroIngresado.Length; i++)
            {
                if (cadenaNumeros[i] == '1')
                {
                    potencia = numeroIngresado.Length - (i + 1);
                    numeroEnDecimal = Math.Pow(2, potencia) + numeroEnDecimal;
                }
            }

            return numeroEnDecimal;
        }
    }
}
