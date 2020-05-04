using System;
using System.Collections.Generic;
using System.Text;

namespace CalculoImpostosXPTO
{
    class ImpostoStrategy
    {
        private Calculo calculo;

        public ImpostoStrategy(Calculo calculo)
        {
            this.calculo = calculo;
        }

        public double valorCalculo(double salario)
        {
            return this.calculo.calcular(salario);
        }
    }
}
