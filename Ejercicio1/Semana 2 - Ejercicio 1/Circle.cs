using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_2___Ejercicio_1
{
    class Circle : Figure
    {
        private double radio;
        
        public Circle(double radio)
        {
            this.radio = radio;
        }
        
        public override double CalculateArea()
        {
            return Math.PI * radio * radio;
        }
    }
}
