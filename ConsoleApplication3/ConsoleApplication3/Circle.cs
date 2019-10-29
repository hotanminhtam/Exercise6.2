using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Circle
    {
        private double radius;
        //private String color;

        public Circle()
        {
            radius = 1.0;
            //color = "red";
        }

        //public Circle(double r)
        //{
        //    radius = r;
        //    color = "red";
        //}

        public double getRadius()
        {
            return radius;
        }

        public double getArea()
        {
            return radius * radius * Math.PI;
        }

        //public string getColor()
        //{
        //    return color;
        //}

        public void SetRadius(double newRadius)
        {
            radius = newRadius;
        }

        //public void SetColor(string newColor)
        //{
        //    color = newColor;
        //}

        public override string ToString()
        {
            return String.Format("Circle[radius = {0}] ", radius);
            //return String.Format("Circle[radius = {0}, color = {1}]", radius, color);
            //return base.ToString();
        }

        public double getCircumference()
        {
            return 2 * Math.PI * radius;
        }
    }
}
