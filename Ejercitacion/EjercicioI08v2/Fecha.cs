using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI08v2
{
    public class Fecha
    {
        //Crear un método estático que reciba una fecha y calcule el número de días que pasaron desde esa fecha hasta la fecha actual.
        //Tener en cuenta los años bisiestos

        public static int CalcularDias(DateTime fecha)
        {
            int acumulador = 0;
            for (int i = fecha.Year; i <= DateTime.Now.Year; i++)
            {
                if (fecha.Year == DateTime.Now.Year && fecha.Day == DateTime.Now.Day && fecha.Month == DateTime.Now.Month)
                {
                    break;
                }
                if (i == DateTime.Now.Year)
                {
                    for (int j = 1; j <= DateTime.Now.Month; j++)
                    {
                        if (j == DateTime.Now.Month)
                        {
                            acumulador += DateTime.Now.Day - fecha.Day;
                        }
                        else
                        {
                            acumulador += DateTime.DaysInMonth(i, j);
                        }
                    }
                }
                else
                {
                    if (i == fecha.Year)
                    {
                        for (int j = fecha.Month; j <= 12; j++)
                        {
                            acumulador += DateTime.DaysInMonth(i, j);
                        }
                    }
                    else
                    {
                        for (int j = 1; j <= 12; j++)
                        {
                            acumulador += DateTime.DaysInMonth(i, j);
                        }
                    }
                }
            }
            return acumulador;
        }
    }
}
