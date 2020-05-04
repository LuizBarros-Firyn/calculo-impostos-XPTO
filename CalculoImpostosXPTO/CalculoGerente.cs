using System;
using System.Collections.Generic;
using System.Text;

namespace CalculoImpostosXPTO
{
    class CalculoGerente : Calculo
    {
        public double calcular(double salarioBase)
        {
            double salarioFinal;

            if (salarioBase > 2000)
            {
                salarioFinal = salarioBase * 0.80;
            }
            else
            {
                salarioFinal = salarioBase * 0.85;
            }

            return salarioFinal;
        }
    }
}
