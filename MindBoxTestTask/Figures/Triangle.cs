using MindBoxTestTask.Interfaces;
using System;

namespace MindBoxTestTask.Figures
{
    public class Triangle : ICalculateFigureArea
    {       

        public double SideA { get; init; }
        public double SideB { get; init; }
        public double SideC { get; init; }

        public bool IsRightTriangle 
        {
            get 
            {               
                double[] sides = new double[] { SideA, SideB, SideC };
                Array.Sort(sides);
               
                return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);            
            }
        }
        
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0) throw new ArgumentException("SideA не может быть меньше или равен нулю");
            if (sideB <= 0) throw new ArgumentException("SideB не может быть меньше или равен нулю");
            if (sideC <= 0) throw new ArgumentException("SideC не может быть меньше или равен нулю");
            if (sideA > sideB + sideC) throw new ArgumentException("SideA не может быть больше суммы двух других сторон");
            if (sideB > sideA + sideC) throw new ArgumentException("SideB не может быть больше суммы двух других сторон");
            if (sideC > sideA + sideB) throw new ArgumentException("SideC не может быть больше суммы двух других сторон");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double GetArea()
        {
            double SemiPerimeter = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(SemiPerimeter * (SemiPerimeter - SideA) * (SemiPerimeter - SideB) * (SemiPerimeter - SideC));
        }
    }
}
