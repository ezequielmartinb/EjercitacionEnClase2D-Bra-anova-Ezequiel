using System;

namespace EjercicioI07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) y 
            la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.

            Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas)
            hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos.

            Mostrar el recibo correspondiente 
            con el nombre, 
            la antigüedad, 
            el valor hora, 
            el total a cobrar en bruto y 
            el total a cobrar neto de todos los empleados ingresados.

            */

            Empleado unEmpleado;

            string nombreIngresado = " ";
            int antiguedadIngresada;
            int valorHoraIngresado;
            int horasTrabajadasIngresadas;
            float totalNetoEmpleado;
            float totalBrutoEmpleado;

            nombreIngresado = Empleado.pedirString(nombreIngresado, "Ingrese un nombre: ", "ERROR. NOMBRE INVALIDO");
            antiguedadIngresada = Empleado.pedirNumeroEntero(1, 20, "Ingrese la antiguedad del empleado: ", "ERROR. ANTIGUEDAD INVALIDA");
            valorHoraIngresado = Empleado.pedirNumeroEntero(1, 360, "Ingrese el valor de las horas: ", "ERROR. VALOR HORAS INVALIDA");
            horasTrabajadasIngresadas = Empleado.pedirNumeroEntero(1, 30000, "Ingrese las horas trabajadas: ", "ERROR. HORAS TRABAJADAS INVALIDA");

            if ((nombreIngresado != null && nombreIngresado != " ") && antiguedadIngresada != 0 && valorHoraIngresado != 0 && horasTrabajadasIngresadas != 0)
            {
                totalNetoEmpleado = Empleado.calcularSueldo(valorHoraIngresado, horasTrabajadasIngresadas, antiguedadIngresada);
                totalBrutoEmpleado = Empleado.calcularSueldo(totalNetoEmpleado);
                unEmpleado = new Empleado(nombreIngresado, antiguedadIngresada, valorHoraIngresado, horasTrabajadasIngresadas, totalNetoEmpleado, totalBrutoEmpleado);

                Console.WriteLine("{0} - {1} - {2} - {3} - {4}", unEmpleado.nombre, unEmpleado.antiguedad, unEmpleado.valorHoras, unEmpleado.sueldoTotalBruto, unEmpleado.sueldoTotalNeto);
            }
            else
            {
                Console.WriteLine("LOS DATOS NO FUERON INGRESADOS CORRECTAMENTE");
            }
        }
    }
}
