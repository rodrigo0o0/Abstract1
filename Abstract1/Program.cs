using Abstract1.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Abstract1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes : ");
            int n = int.Parse(Console.ReadLine());
            List<Shape> shapes = new List<Shape>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{i+1} data:");
                Console.Write("Rectangle or Circle (r/c) : ");
                char type = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Color (Black/Blue/Red)");
                string sColor;
                Enum.TryParse<Color>(sColor = Console.ReadLine(), out var color);
                if(type == 'r')
                {
                    Console.Write("Width : ");
                    double width = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Height : ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Rectangle(color,width,height));
                }
                else if(type == 'c')
                {
                    Console.Write("Radius : ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(color,radius));
                }


            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS : ");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2",CultureInfo.InvariantCulture));
            }
            Console.ReadKey();
        }
    }
}
