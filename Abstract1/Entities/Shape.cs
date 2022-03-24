using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract1.Entities
{
    internal abstract class Shape
    {
        public Color color { get; set; }
        protected Shape()
        {
        }

        protected Shape(Color color)
        {
            this.color = color;
        }

        public abstract double Area();


    }
}
