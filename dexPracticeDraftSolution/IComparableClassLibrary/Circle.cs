using System;

namespace IComparableClassLibrary
{
    public class Circle : Figure
    {
        private readonly double _radius;
        public Circle(double radius)
        {
            if (radius > 0)
            {
                _radius = radius;
            }
            else
            {
                throw new ArgumentException("Радиус не может быть отрицательным или нулевым.");
            }
        }

        public override double GetSquare()
        {
            return _radius * _radius * Math.PI;
        }
        
        public override string ToString()
        {
            return "Круг";
        }
    }
}