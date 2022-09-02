using System;
using System.Collections.Generic;
using System.Text;

namespace MindBoxLibrary
{
    public class Triangle : IFigure
    {
        readonly int A;
        readonly int B;
        readonly int C;

        public Triangle(int _a, int _b, int _c)
        {
            A = Math.Abs(_a);
            B = Math.Abs(_b);
            C = Math.Abs(_c);
        }


        public double GetSquare()
        {
            double halfPer = (A + B + C) / 2;
            double square = Math.Sqrt(halfPer * (halfPer - A) * (halfPer - B) * (halfPer - C));

            return square;
        }

        public bool IsRectangular()
        {
            if (A > B && A > C)
                return Math.Pow(C, 2) + Math.Pow(B, 2) == Math.Pow(A, 2);
            else if (B > A && B > C)
                return Math.Pow(C, 2) + Math.Pow(A, 2) == Math.Pow(B, 2);
            else return Math.Pow(A, 2) + Math.Pow(B, 2) == Math.Pow(C, 2);

        }
    }
}
