using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes_Inheritance
{
    class Rectangle : Shapes
    {
        // Fields
        private double length = 1;
        private double width = 2;


        // constructors
        public Rectangle(double length, double width, string color) : base(color)
        {
            SetWidth(length);
            SetLength(width);
        }


        // Methods
        public override double GetArea()
        {
            return length * width;
        }

        public override double GetPerimeter()
        {
            return 2 * (length + width);
        }
        public double GetLength()
        {
            return this.length;
        }
        public double GetWidth()
        {
            return this.width;
        }
        public void SetLength(double length)
        {
            if (length < 0)
            {
                length = -length;
            }
            else if (length == 0)
            {
                length = 1;
            }
            this.length = length;
        }

        public void SetWidth(double width)
        {
            if (width < 0)
            {
                width = -width;
            }
            else if (width == 0)
            {
                width = 1;
            }
            this.width = width;
        }

    }
}
