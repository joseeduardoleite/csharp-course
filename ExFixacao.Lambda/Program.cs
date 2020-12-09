using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using ExFixacao.Lambda.Entities;

namespace ExFixacao.Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler os dados (nome, email e salário) de funcionarios a partir de um arquivo em formato .csv.
            // Em seguida mostrar, em ordem alfabética, o email dos funcionários cujo salário seja superior a um dado valor fornecido pelo usuário.
            // Mostrar também a soma dos salários dos funcionários cujo nome começa com a letra 'M'.
            //C:\Users\jocm\on.txt

            try {
                Console.Write("Enter full file path: ");
                string path = Console.ReadLine();
                Console.WriteLine("Enter salary");
                double salaryT = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                List<Employee> listEmployee = new List<Employee>();

                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] fields = sr.ReadLine().Split(", ");
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                        listEmployee.Add(new Employee(name, email, salary));
                    }
                }

                var avr = listEmployee.Where(x => x.Salary > salaryT).OrderBy(x => x.Email).Select(x => x.Email);
                Console.WriteLine("Email of people whose salary is more than " + salaryT.ToString("F2", CultureInfo.InvariantCulture));
                foreach (var item in avr){
                    Console.WriteLine(item);                
                }

                var avrs = listEmployee.Where(x => x.Name[0] == 'M').Sum(x => x.Salary);
                Console.WriteLine("Sum of salary of people whose name starts with 'M': " + avrs.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (IOException e) {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
