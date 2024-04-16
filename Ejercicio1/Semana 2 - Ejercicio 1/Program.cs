using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_2___Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Choose a shape to calculate its area:");
                Console.WriteLine("1. Rectangle");
                Console.WriteLine("2. Circle");
                Console.WriteLine("3. Triangle");
                Console.WriteLine("4. Exit");
                                
                Console.Write("Select an option: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Enter the base of the rectangle: ");
                        double baseRectangle = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the height of the rectangle: ");
                        double heightRectangle = Convert.ToDouble(Console.ReadLine());
                        Rectangle rectangle = new Rectangle(baseRectangle, heightRectangle);
                        Console.WriteLine("The area of the rectangle is: " + rectangle.CalculateArea());
                        break;
                    case 2:
                        Console.Write("Enter the radius of the circle: ");
                        double radioCircle = Convert.ToDouble(Console.ReadLine());
                        Circle circle = new Circle(radioCircle);
                        Console.WriteLine("The area of the circle is: " + circle.CalculateArea());
                        break;
                    case 3:
                        Console.Write("Enter the base of the triangle: ");
                        double baseTriangle = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the height of the triangle: ");
                        double heightTriangle = Convert.ToDouble(Console.ReadLine());
                        Triangle triangle = new Triangle(baseTriangle, heightTriangle);
                        Console.WriteLine("The area of the triangle is: " + triangle.CalculateArea());
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid option.");
                        break;
                }
            }
        }
    }
}
