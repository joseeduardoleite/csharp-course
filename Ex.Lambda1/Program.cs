using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Ex.Lambda1.Entities;

namespace Ex.Lambda1
{
    class Program
    {
        static void Main(string[] args)
        {
            // fazer um programa para ler um conjunto de produtos a partir de um arquivo em formato .csv (suponha que exista pelo menos um produto).
            // Em seguida mostrar o preço médio dos produtos. Depois, mostrar os nomes, em ordem decrescente, dos produtos que possuem preço inferior ao preço médio.
            

            Console.WriteLine("Enter full file path: ");
            string path = Console.ReadLine();
            //C:\Users\jocm\txt.in

            List<Product> listProduct = new List<Product>();

            using (StreamReader sr = File.OpenText(path)) {
                while (!sr.EndOfStream) {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);

                    listProduct.Add(new Product(name, price));
                }
            }

            var averrage = listProduct.Select(x => x.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price = " + averrage.ToString("F2", CultureInfo.InvariantCulture));

            var names = listProduct.Where(x => x.Price < averrage).OrderByDescending(x => x.Name).Select(x => x.Name);
            foreach (var item in names) {
                Console.WriteLine(item);
            }
        }
    }
}
