using MindBoxTestTask.Figures;
using System;
using Xunit;

namespace MindBoxTestTask.Tests
{
    public class CircleTests
    {
        [Fact]
        public void NegativeRadiusCircle()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Circle circle = new Circle(-13.5f);
            });
        }

        [Fact]
        public void ZeroRadiusCircle() 
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Circle circle = new Circle(0);
            });
        }

        [Fact]
        public void CalculateArea() 
        {
            Circle circle = new Circle(10);
            
            double excepted = 314.15926535897933;

            Assert.Equal(excepted, circle.GetArea());
        }
    }
}
