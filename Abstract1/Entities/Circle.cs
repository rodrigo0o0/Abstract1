using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract1.Entities
{
    internal class Circle : Shape
    {
        public Circle()
        {
        }

        public Circle(Color color,double radius) : base(color)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public override double Area()
        {
            return Math.Pow(Radius,2) * Math.PI;
        }
    }
}
