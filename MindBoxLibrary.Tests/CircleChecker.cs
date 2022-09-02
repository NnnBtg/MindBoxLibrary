using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MindBoxLibrary.Tests
{
    public class CircleChecker
    {
        [Theory]
        [InlineData(5, 78.539816339744831)]
        [InlineData(-5, 78.539816339744831)]
        [InlineData(1, Math.PI)]

        public void CheckSquare(int r, double result)
        {
            //Arrange
            var circle = new Circle(r);

            //Act
            var square = circle.GetSquare();

            //Assert
            Assert.Equal(square, result);
        }
    }
}
