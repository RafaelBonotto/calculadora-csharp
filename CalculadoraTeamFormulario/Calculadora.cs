using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTeamFormulario
{
    class Calculadora
    {
        public double resultado;
        public Calculadora()
        {
            resultado = 0;
        }//fim do construtor

        //Consultar Resultado
        public double ConsultarResultado
        {
            get
            {
                return resultado;
            }
            set
            {
                this.resultado = value;
            }
        }//fim do resultado

        //Soma
        public double Soma(double num1, double num2)
        {
            return num1 + num2;//Soma
        }//fim do método 
        public double Subtracao(double num1, double num2)
        {
            return num1 - num2;//Subtração
        }//fim do método
        public double Divisao(double num1, double num2)
        {
            if(num1 > 0 && num2 > 0)
            {
                return num1 / num2;
            }
            return -1;//retorno do método
        }//fim do método
        public double Multiplicacao(double num1, double num2)
        {
            return num1 * num2;
        }//fim do método
        public double Resto(double num1, double num2)
        {
            if (num1 > 0 && num2 > 0)
            {
                return num1 % num2;
            }
            return -1;
        }//fim do método
        public double Potencia(double num1, double num2)
        {
            return Math.Pow(num1, num2);//Método POW = Representa um potência na classe matemática
        }//fim do método
    }//fim da classe
}//fim do projeto
