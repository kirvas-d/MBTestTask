using MindBoxTestTask.Interfaces;
using System;

namespace MindBoxTestTask.Figures
{
    public class Circle: ICalculateFigureArea
    {
        public float Radius { get; init; }

        public Circle(float radius) 
        {
            if (radius <= 0) throw new ArgumentException("Радиус не может быть меньше или равен нулю нуля");

            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
