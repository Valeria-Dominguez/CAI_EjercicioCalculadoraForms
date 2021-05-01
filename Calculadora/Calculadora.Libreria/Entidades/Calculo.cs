using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Libreria.Entidades
{
    public class Calculo
    {
        double _numA;
        double _numB;
        string _operador;
        double _resultado;
        
        public Calculo(double numA, double numB, string operador)
        {
            this._numA = numA;
            this._numB = numB;
            this._operador = operador;
            this._resultado = GetResultado(numA, numB, operador);
        }

        public double Resultado { get => _resultado; }

        double GetResultado (double numA, double numB, string operador)
        {
            if (operador == "+")
            {
                return numA + numB;
            }
            else if (operador == "-")
            {
                return numA - numB;
            }
            else if (operador == "*")
            {
                return numA * numB;
            }
            else if (operador == "/")
            {
                if (numB == 0)
                {
                    throw new DivideByZeroException("No se puede dividir por cero");
                }
                return numA / numB;
            }
            else
            {
                throw new Exception("Operador inválido");
            }
        }
    }
}
