using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CircleCalculator
    {
        public double CalculateArea(Circle circle)
        {
            return Math.PI * Math.Pow(circle.Radius, 2);
        }

        public double CalculateCircumference(Circle circle)
        {
            return 2 * Math.PI * circle.Radius;
        }
    }
}
