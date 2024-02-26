using System;

namespace AreaCalculator
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Incorrect input. Radius of a circle must be more than 0");
            }
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
