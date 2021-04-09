using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes_Inheritance
{
    class Square : Shapes
    {
        //Fields
        private double Side = 1;


        //Constructor
        public Square()
        {
        }

        public Square(int side)
        {
            this.Side = side;
        }

        public Square(double Side, string color) : base(color)
        {
            SetSide(Side);
            SetColor("red");
        }


        //Methods
        public override double GetArea()
        {
            return Side * Side;
        }

        public override double GetPerimeter()
        {
            return 4 * Side;
        }

        public double GetSide()
        {
            return this.Side;
        }

        public void SetSide(double Side)
        {
            if (Side < 0)
            {
                Side = -Side;
            }
            else if (Side == 0)
            {
                Side = 1;
            }
            this.Side = Side;
        }
    }
}
