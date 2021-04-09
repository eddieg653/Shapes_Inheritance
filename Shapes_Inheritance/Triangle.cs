using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes_Inheritance
{
    class Triangle : Shapes
    {
        //Fields
        private double SideA = 1;
        private double SideB = 2;
        private double SideC = 3;


        //Constructors
        public Triangle()
        {
        }

        public Triangle(double SideA, double SideB, double SideC, string color) : base(color)
        {
            
            SetSideA(SideA);
            SetSideB(SideB);
            SetSideC(SideC);
        }


        //Methods
        public override double GetArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public override double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }

        public double GetSideA()
        {
            return this.SideA;
        }

        public double GetSideB()
        {
            return this.SideB;
        }

        public double GetSideC()
        {
            return this.SideC;
        }

        public void SetSideA(double SideA)
        {
            if (SideA < 0)
            {
                SideA = -SideA;
            }
            else if (SideA == 0)
            {
                SideA = 1;
            }
            this.SideA = SideA;
        }

        public void SetSideB(double SideB)
        {
            if (SideB < 0)
            {
                SideB = -SideB;
            }
            else if (SideB == 0)
            {
                SideB = 1;
            }
            this.SideB = SideB;
        }
        public void SetSideC(double SideC)
        {
            if (SideC < 0)
            {
                SideC = -SideC;
            }
            else if (SideC == 0)
            {
                SideC = 1;
            }
            this.SideC = SideC;
        }


    }
}
