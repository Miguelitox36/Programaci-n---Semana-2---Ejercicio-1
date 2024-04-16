using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_2___Ejercicio_1
{
    class Triangle: Figure
    {
        private double baseTriangle;
        private double heightTriangle;

        // Constructor que recibe la base y la altura del triángulo
        public Triangle(double baseTriangulo, double alturaTriangulo)
        {
            this.baseTriangle = baseTriangulo;
            this.heightTriangle = alturaTriangulo;
        }

        // Método para calcular el área del triángulo
        public override double CalculateArea()
        {
            return (baseTriangle * heightTriangle) / 2;
        }
    }
}
