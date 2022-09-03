using System;

namespace EjercicioI06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Escribir un programa que determine si un año es bisiesto.
            
            Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. 
            
            Por ejemplo: el año 2000 es bisiesto, pero 1900 no.

            Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.           
             
            */

            int anioInicio;
            int anioFin;
            bool resultadoAnioInicio;
            bool resultadoAnioFin;

            Console.WriteLine("Ingrese el año de comienzo: ");
            resultadoAnioInicio = int.TryParse(Console.ReadLine(), out anioInicio);
            Console.WriteLine("Ingrese el año de fin: ");
            resultadoAnioFin = int.TryParse(Console.ReadLine(), out anioFin);

            if (resultadoAnioInicio && resultadoAnioFin)
            {
                for (int i = anioInicio; i <= anioFin; i++)
                {
                    if (i % 4 == 0)
                    {
                        Console.WriteLine("El año {0} es un año bisiesto", i);
                    }
                    else if (i % 100 == 0 && i % 400 == 0)
                    {
                        Console.WriteLine("El año {0} es un año bisiesto", i);
                    }
                }
            }
            else
            {
                Console.WriteLine("ERROR. AÑO INGRESADO INVALIDO");
            }
        }
    }
}
