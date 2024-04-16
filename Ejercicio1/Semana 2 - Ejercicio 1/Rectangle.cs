using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_2___Ejercicio_1
{
    class Rectangle: Figure
    {
        private double baseRectangle;
        private double heightRectangle;
                
        public Rectangle(double baseRectangle, double heightRectangle)
        {
            this.baseRectangle = baseRectangle;
            this.heightRectangle = heightRectangle;
        }
                
        public override double CalculateArea()
        {
            return baseRectangle * heightRectangle;
        }
    }
}
