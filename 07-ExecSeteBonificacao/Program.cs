using System;
using System.Globalization;

namespace ExecSeteBonificacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerente = new Gerente();
            Supervisor supervisor = new Supervisor();
            Vendedor vendedor = new Vendedor();

            gerente.Nome = "João";
            gerente.Salario = 50000;

            Console.WriteLine("\nSalário do Gerente " + gerente.Nome + " é R$ " + gerente.Salario.ToString("F2", CultureInfo.InvariantCulture));

            gerente.Bonificacao();

            Console.WriteLine("Salario do Gerente " + gerente.Nome + " é R$ " + gerente.Salario.ToString("F2", CultureInfo.InvariantCulture)+ " com bonificação!\n");

            supervisor.Nome = "Matheus";
            supervisor.Salario = 15000;

            Console.WriteLine("\nSalário do Supervisor " + supervisor.Nome + " é R$ " + supervisor.Salario.ToString("F2", CultureInfo.InvariantCulture));

            supervisor.Bonificacao();

            Console.WriteLine("Salario do Supervisor " + supervisor.Nome + " é R$ " + supervisor.Salario.ToString("F2", CultureInfo.InvariantCulture)+ " com bonificação!\n");

            vendedor.Nome = "Lucas";
            vendedor.Salario = 10000;

            Console.WriteLine("\nSalário do Supervisor " + vendedor.Nome + " é R$ " + vendedor.Salario.ToString("F2", CultureInfo.InvariantCulture));

            vendedor.Bonificacao();

            Console.WriteLine("Salario do Supervisor " + vendedor.Nome + " é R$ " + vendedor.Salario.ToString("F2", CultureInfo.InvariantCulture)+ " com bonificação!\n");
        }
    }
}
