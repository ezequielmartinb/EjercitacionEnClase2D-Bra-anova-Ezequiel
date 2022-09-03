using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI07
{
    internal class Empleado
    {
        public string nombre;
        public int antiguedad;
        public int valorHoras;
        public int horasTrabajadas;
        public float sueldoTotalNeto;
        public float sueldoTotalBruto;

        public Empleado(string nombre, int antiguedad, int valorHoras, int horasTrabajadas, float sueldoTotalNeto, float sueldoTotalBruto)
        {
            this.nombre = nombre;
            this.antiguedad = antiguedad;
            this.valorHoras = valorHoras;
            this.horasTrabajadas = horasTrabajadas;
            this.sueldoTotalNeto = sueldoTotalNeto;
            this.sueldoTotalBruto = sueldoTotalBruto;
        }

        public static string pedirString(string nombre, string mensaje, string mensajeError)
        {
            int esNumero;
            string nombreIngresadoValidado = null;

            Console.WriteLine(mensaje);
            nombre = Console.ReadLine();
            if (int.TryParse(nombre, out esNumero) == false)
            {
                nombreIngresadoValidado = nombre;
            }
            else
            {
                Console.WriteLine(mensajeError);
            }

            return nombreIngresadoValidado;
        }
        public static int pedirNumeroEntero(int minimo, int maximo, string mensaje, string mensajeError)
        {
            bool resultadoNumeroEnteroIngresado;
            int numeroEnteroIngresado;

            Console.WriteLine(mensaje);
            resultadoNumeroEnteroIngresado = int.TryParse(Console.ReadLine(), out numeroEnteroIngresado);

            if (resultadoNumeroEnteroIngresado == false || numeroEnteroIngresado < minimo || numeroEnteroIngresado > maximo)
            {
                Console.WriteLine(mensajeError);
            }

            return numeroEnteroIngresado;
        }
        public static float calcularSueldo(int valorHoras, int horasTrabajadas, int antiguedad)
        {
            float totalNetoEmpleado;

            totalNetoEmpleado = (valorHoras * horasTrabajadas) + (antiguedad * 150);

            return totalNetoEmpleado;
        }
        public static float calcularSueldo(float totalNetoEmpleado)
        {
            float totalBrutoEmpleado;

            totalBrutoEmpleado = totalNetoEmpleado - ((totalNetoEmpleado * 13) / 100);

            return totalBrutoEmpleado;
        }
    }
}
