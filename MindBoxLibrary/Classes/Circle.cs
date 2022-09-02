using System;
using System.Collections.Generic;
using System.Text;

namespace MindBoxLibrary
{
    public class Circle : IFigure
    {
        readonly int Radius;

        public Circle(int _radius)
        {
            Radius = Math.Abs(_radius);
        }

        public double GetSquare() => Math.PI * Math.Pow(Radius, 2);
        
    }
}
