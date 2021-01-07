using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Rectangle(){ Height = 100, Width = 200 };
            Console.WriteLine("Area of a Rectangle is: " + shape.Area());

            shape = new Square() { Sides = 100 };
            Console.WriteLine("Area of a Square is: " + shape.Area());

            Console.ReadLine();
        }
    }
}
