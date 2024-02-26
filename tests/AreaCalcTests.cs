using AreaCalculator;

namespace AreaCalculatorTests
{
    public class Tests
    {
        [TestFixture]
        public class AreaCalculatorTests
        {
            [Test]
            public void CalculateCircleArea_ValidRadius_ReturnsCorrectArea()
            {
                // Arrange
                var circle = new Circle(5);

                //Act
                double result = circle.CalculateArea();

                //Assert
                Assert.AreEqual(78.54, result,0.1);
            }

            [Test]
            public void CalculateTriangleArea_ValidSides_ReturnsCorrectArea()
            {
                // Arrange
                var triangle = new Triangle(3, 4, 5);

                //Act
                double result = triangle.CalculateArea();

                //Assert
                Assert.AreEqual(6, result);
            }

            [Test]
            public void IsRightTriangle_RightTriangle_ReturnsTrue()
            {
                // Arrange
                var triangle = new Triangle(3, 4, 5);

                //Act
                bool result = triangle.IsRight();

                //Assert
                Assert.IsTrue(result);
            }

            [Test]
            public void IsRightTriangle_NotRightTriangle_ReturnsFalse()
            {
                // Arrange
                var triangle = new Triangle(3, 4, 6);

                //Act
                bool result = triangle.IsRight();

                //Assert
                Assert.IsFalse(result);
            }

        }


    }
}
