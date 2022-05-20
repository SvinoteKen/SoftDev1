using NUnit.Framework;
using RectangleApp;
using System;

namespace RectangleTest
{
    public class Tests
    {
        [Test]
        public void TestInvalidRectangle()
        {
            // Arrange
            Rectangle rectangle = new Rectangle();
            //Assert and act
            Assert.Throws<ArgumentException>(() => rectangle.SetVertices(new double[] { -4, -2, 3, 3 }, new double[] { 1, 3, 3, 1 }));
            Assert.Throws<ArgumentException>(() => rectangle = new Rectangle(new double[] { -2, -2, 3, 7 }, new double[] { 1, 3, 3, 1 }));
        }

        [TestCase(new double[] { 2, 2, 6, 6 }, new double[] { 1, 4, 4, 1 }, 5)]
        [TestCase(new double[] { -2, -2, 3, 3 }, new double[] { 1, 3, 3, 1 }, 5.38516481)]
        [TestCase(new double[] { 0, 4, 5, 1 }, new double[] { 1, 3, 1, -1 }, 5)]
        [TestCase(new double[] { 3, 3, 11, 11 }, new double[] { 1, 16, 16, 1 }, 17)]
        public void TestDiagonalCalculating(double[] x, double[] y, double expectedDiagonal)
        {
            // Arrange
            Rectangle rectangle = new Rectangle(x,y);
            // Act
            double diagonal = rectangle.Diagonal();
            // Assert
            Assert.AreEqual(diagonal, expectedDiagonal, 0.00001);
        }
    }
}