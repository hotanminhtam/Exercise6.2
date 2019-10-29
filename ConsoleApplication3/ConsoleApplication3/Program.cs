using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Circle c1 = new Circle();
            //Console.WriteLine("The circle has radius of " + c1.getRadius() + " and area of " + c1.getArea());

            //Circle c2 = new Circle(2.0);
            //Console.WriteLine("The circle has radius of " + c2.getRadius() + " and area of " + c2.getArea());

            //Circle c3 = new Circle(3, "Orange");
            //Console.WriteLine("The circle has radius of " + c3.getRadius() + " and area of " + c3.getColor());

            Circle c4 = new Circle();
            Console.WriteLine(c4.ToString());

            Circle c5 = new Circle();
            Console.WriteLine("The circle has radius of " + c5.getRadius());
            Console.WriteLine("The circle has radius of " + c5.getCircumference());
        }
    }
}
