using System;
using System.Collections.Generic;
using System.Globalization;

namespace List.ex
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Quantos funcionários serão cadastrados?");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine("Funcionário #" + i + ":");
                System.Console.WriteLine("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                System.Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista.Add(new Funcionario(id, nome, salario));
                System.Console.WriteLine();
            }

            System.Console.WriteLine("Digite o Id do funcionário que terá aumento de salário: ");
            int perquisaId = int.Parse(Console.ReadLine());

            Funcionario emp = lista.Find(x => x.Id == perquisaId);
            if (emp != null) {
                
                System.Console.WriteLine("Insira a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncrementarSalario(porcentagem);
            }
            else
            {
                System.Console.WriteLine("Este Id não existe!");
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Lista atualizada de funcionários: ");

            foreach (Funcionario obj in lista)
            {
                System.Console.WriteLine(obj);
            }
        }
    }
}