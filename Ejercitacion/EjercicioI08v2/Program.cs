using System;
using System.Data;

namespace EjercicioI08v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Crear un método estático que reciba una fecha y calcule el número de días que pasaron desde esa fecha hasta la fecha actual. 
            Tener en cuenta los años bisiestos.

            Pedir por consola la fecha de nacimiento de una persona (día, mes y año) y 
            calcule el número de días vividos por esa persona hasta la fecha actual utilizando el método desarrollado anteriormente.

            Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.    
             
            */
            DateTime fecha;
            int diasVividos;

            Console.WriteLine("Ingrese su fecha de nacimiento: ");

            if (DateTime.TryParse(Console.ReadLine(), out fecha))
            {
                diasVividos = Fecha.CalcularDias(fecha);
                Console.WriteLine("Su fecha de nacimiento es: {0} y los días que ha vivido son: {1}", fecha, diasVividos);
            }
            else
            {
                Console.WriteLine("ERROR. NO INGRESO UNA FECHA VALIDA");
            }



        }
    }
}
