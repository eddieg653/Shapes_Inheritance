using System;

namespace Shapes_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Shapes s = new Square(2);
            Console.WriteLine(s.GetArea());
            Console.WriteLine(s.GetPerimeter());



        }
    }
}
