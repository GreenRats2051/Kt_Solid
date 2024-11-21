using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Triangle : IFigure
    {
        public double Base { get; }
        public double Height { get; }

        public Triangle(double baseLength, double height)
        {
            Base = baseLength;
            Height = height;
        }

        public double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }
}
