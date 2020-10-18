using System;
using System.Collections.Generic;
using System.Globalization;
using Entities;

namespace Ex.Abs2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> list = new List<Pessoa>();

            System.Console.Write("Enter the number of tax payers: ");
            int contribuintes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= contribuintes; i++)
            {
                System.Console.WriteLine($"Tax payer #{i} data:");
                System.Console.Write("Individual or company (i/c)? ");
                string resposta = Console.ReadLine();
                System.Console.Write("Name: ");
                string nome = Console.ReadLine();
                System.Console.Write("Anual income: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (resposta == "i")
                {
                    System.Console.Write("Health expenditures: ");
                    double gastoSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(nome, rendaAnual, gastoSaude));
                }
                else
                {
                    System.Console.Write("Number of employees: ");
                    int funcionarios = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(nome, rendaAnual, funcionarios));
                }
            }

            double soma = 0.0;
            System.Console.WriteLine();
            System.Console.WriteLine("TAXES PAID:");
            foreach (Pessoa pessoa in list)
            {
                double imposto = pessoa.Imposto();
                System.Console.WriteLine(pessoa.Nome + ": $ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
                soma += imposto;
            }

            System.Console.WriteLine();
            System.Console.WriteLine("TOTAL TAXES: $ " + soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
