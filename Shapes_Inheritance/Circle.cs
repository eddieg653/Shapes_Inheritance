using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes_Inheritance
{
    class Circle : Shapes
    {
        //Field
        private double radius = 1;


        //Constructors
        public Circle(double radius, string color) : base(color)
        {
            SetRadius(radius);
        }


        //Methods
        public override double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public  double GetCircumference()
        {
            return 2 * (Math.PI * radius);
        }

        public override double GetPerimeter()
        {
            throw new NotImplementedException();
        }

        public double GetRadius()
        {
            return this.radius;
        }

        public void SetRadius(double radius)
        {
            if (radius < 0)
            {
                radius = -radius;
            }
            else if (radius == 0)
            {
                radius = 1;
            }
            this.radius = radius;
        }


    }
}
