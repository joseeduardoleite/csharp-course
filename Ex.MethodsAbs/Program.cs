using System;
using System.Collections.Generic;
using System.Globalization;
using Entities;
using Entities.Enums;

namespace Ex.MethodsAbs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.WriteLine("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                System.Console.WriteLine("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                System.Console.WriteLine("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r')
                {
                    System.Console.WriteLine("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    System.Console.WriteLine("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    System.Console.WriteLine("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine("SHAPE AREAS:");

            foreach (Shape shape in list)
            {
                System.Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
