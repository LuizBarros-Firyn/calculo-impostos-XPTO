using System;

namespace CalculoImpostosXPTO
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioBase;
            double salarioFinal;
            ImpostoStrategy imposto;

            Console.Write("Digite o salário base do funcionário desenvolvedor: ");

            salarioBase = Convert.ToDouble(Console.ReadLine());

            imposto = new ImpostoStrategy(new CalculoDesenvolvedor());

            salarioFinal = imposto.valorCalculo(salarioBase);

            Console.WriteLine("\nSalario final do desenvolvedor: " + salarioFinal);

            Console.Write("\nDigite o salário base do funcionário Gerente: ");

            salarioBase = Convert.ToDouble(Console.ReadLine());

            imposto = new ImpostoStrategy(new CalculoGerente());

            salarioFinal = imposto.valorCalculo(salarioBase);

            Console.WriteLine("\nSalario final do Gerente: " + salarioFinal);

            Console.Write("\nDigite o salário base do funcionário DBA: ");

            salarioBase = Convert.ToDouble(Console.ReadLine());

            imposto = new ImpostoStrategy(new CalculoDba());

            salarioFinal = imposto.valorCalculo(salarioBase);

            Console.WriteLine("\nSalario final do DBA: " + salarioFinal);
        }
    }
}
