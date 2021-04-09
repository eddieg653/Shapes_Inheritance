using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes_Inheritance
{
    public abstract class Shapes
    {
        //Field
        private string Color;

        protected Shapes()
        {

        }

        protected Shapes(string color)
        {
            SetColor(color);
        }
        //Method
        public string GetColor()
        {
            return Color;
        }

        public bool SetColor(string Color)
        {
            if (Color != null)
            {
                this.Color = Color;
                return true;
            }
            else
            {
                return false;
            }
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();



    }
}
