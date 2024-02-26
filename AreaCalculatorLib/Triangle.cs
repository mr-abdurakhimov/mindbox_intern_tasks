
namespace AreaCalculator
{
    public class Triangle : Shape
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("Incorrect input. Side of a triangle must be more than 0");
            }

            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override double CalculateArea()
        {
            double sp = (side1 + side2 + side3) / 2;
            return Math.Sqrt(sp * (sp - side1) * (sp - side2) * (sp - side3));
        }

        public bool IsRight()
        {
            double[] sides = { side1, side2, side3 };
            Array.Sort(sides);
            return (sides[0] * sides[0] + sides[1] * sides[1]) == sides[2] * sides[2];
        }

    }
}
