using System;

namespace EjercicioI04
{
    internal class Program
    {
        /*
         * Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).

            Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

            Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. El método devolverá el resultado de la operación.

            Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true si el operando es distinto de cero.

            Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

            El usuario decidirá cuándo finalizar el programa. 
         */
        static void Main(string[] args)
        {
            double primerOperadorIngresado;
            double segundoOperadorIngresado;
            char operacionMatematica;
            bool resultadoPrimerOperandoDoubleParseado;
            bool resultadoSegundoOperandoDoubleParseado;
            bool resultadoOperacionMatematicaParseado;
            double resultadoOperacionMatematica;

            do
            {
                Console.WriteLine("Ingrese el primer operando: ");
                resultadoPrimerOperandoDoubleParseado = double.TryParse(Console.ReadLine(), out primerOperadorIngresado);
                Console.WriteLine("Ingrese el segundo operando: ");
                resultadoSegundoOperandoDoubleParseado = double.TryParse(Console.ReadLine(), out segundoOperadorIngresado);
                Console.WriteLine("Ingrese la operacion matematica: ");
                resultadoOperacionMatematicaParseado = char.TryParse(Console.ReadLine(), out operacionMatematica);

                if (resultadoPrimerOperandoDoubleParseado && resultadoSegundoOperandoDoubleParseado && resultadoOperacionMatematicaParseado && Calculadora.Validar(operacionMatematica))
                {
                    resultadoOperacionMatematica = Calculadora.Calcular(primerOperadorIngresado, segundoOperadorIngresado, operacionMatematica);
                    Console.WriteLine($"El resultado es: {resultadoOperacionMatematica}");
                }
                else
                {
                    Console.WriteLine("Los datos ingresados son invalidos. Por lo tanto, no se pudo calcular");
                }

            } while (Calculadora.Validar() == true);

            Console.WriteLine("GRACIAS POR USAR LA CALCULADORA UTN");
        }
    }
}
