using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MindBoxLibrary.Tests
{
    public class TriangleChecker
    {
        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(5, 8, 5, 12)]
        [InlineData(5, -8, -5, 12)]
        [InlineData(5, 2, 1, double.NaN)]
        public void CheckSquare(int a, int b, int c, double result)
        {
            //Arrange
            var triangle = new Triangle(a, b, c);

            //Act
            var square = triangle.GetSquare();

            //Assert
            Assert.Equal(square, result);
        }

        [Theory]
        [InlineData(13, 12, 5, true)]
        [InlineData(12, 13, 5, true)]
        [InlineData(5, 12, 13, true)]
        [InlineData(13, 12, 10, false)]
        public void CheckOnRectangular(int a, int b, int c, bool result)
        {
            //Arrange
            var triangle = new Triangle(a, b, c);

            //Act
            var square = triangle.IsRectangular();

            //Assert
            Assert.Equal(square, result);
        }
    }
}
