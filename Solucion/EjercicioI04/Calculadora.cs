using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI04
{
    public class Calculadora
    {
        /*
        Calcular(público) : Recibirá tres parámetros: 

        el primer operando, 
        el segundo operando y 
        la operación matemática.
        
        El método devolverá el resultado de la operación.

        Validar(privado): 
        
        Recibirá como parámetro el segundo operando.        
        Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN.         
        Este método devolverá true si el operando es distinto de cero.
        */

        public static double Calcular(double primerOperador, double segundoOperador, char operacionMatematica)
        {
            double resultado = 0;

            switch (operacionMatematica)
            {
                case '+':
                    resultado = primerOperador + segundoOperador;
                    break;
                case '-':
                    resultado = primerOperador - segundoOperador;
                    break;
                case '*':
                    resultado = primerOperador * segundoOperador;
                    break;
                case '/':
                    if (Validar(segundoOperador))
                    {
                        resultado = primerOperador / segundoOperador;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por 0");
                    }
                    break;
            }

            return resultado;
        }

        private static bool Validar(double segundoOperando)
        {
            bool resultado = false;

            if (segundoOperando != 0)
            {
                resultado = true;
            }

            return resultado;
        }
        public static bool Validar(char operacionMatematica)
        {
            bool retorno = true;

            if (operacionMatematica != '+' && operacionMatematica != '-' && operacionMatematica != '*' && operacionMatematica != '/')
            {
                retorno = false;
            }

            return retorno;
        }
        public static bool Validar()
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
