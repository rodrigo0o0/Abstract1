using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract1.Entities
{
    internal class Rectangle : Shape
    {
        public Rectangle()
        {
        }

        public Rectangle(Color color,double width,double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
