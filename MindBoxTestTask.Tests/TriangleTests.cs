using MindBoxTestTask.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MindBoxTestTask.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(0, 1, 1)]
        [InlineData(1, 0, 1)]
        [InlineData(1, 1, 0)]
        [InlineData(-1, 1, 1)]
        [InlineData(1, -1, 1)]
        [InlineData(1, 1, -1)]
        [InlineData(5, 1, 1)]
        [InlineData(1, 5, 1)]
        [InlineData(1, 1, 5)]
        void NegativeZeroAndWrongSidesTriangle(double sideA, double sideB, double sideC) 
        {
            Assert.Throws<ArgumentException>(() => 
            {
                Triangle triangle = new Triangle(sideA, sideB, sideC);
            });
        }

        [Fact]
        void RightTriangle() 
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightTriangle);
        }

        [Fact]
        void NotRightTriangle() 
        {
            Triangle triangle = new Triangle(3,3,3);
            Assert.False(triangle.IsRightTriangle);
        }

        [Fact]
        void CalculateArea() 
        {
            Triangle triangle = new Triangle(5, 8, 9);

            double excepted = 19.8997487421324;

            Assert.Equal(excepted, triangle.GetArea());
        }

    }
}
