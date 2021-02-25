using System;

namespace IComparable
{
    public class Figure : System.IComparable // передеать -- унаследовать и определить сравнение через GetSquare() предка
    {
        private double _radius;
        private double a;
        private double b;
        private double c;

        public readonly double Square;

        public Figure(double radius)
        {
            if (radius > 0)
            {
                _radius = radius;
                Square = GetSquare();
            }
            else
            {
                throw new ArgumentException("Радиус не может быть отрицательным или нулевым.");
            }
        }
        
        public  Figure(double a, double b, double c)
        {
            double halfPerimeter = (a + b + c) / 2.0;
            
            
        }

        public double GetSquare()
        {
            return _radius*_radius*Math.PI;
        }

        public int CompareTo(object other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("Данного круга не существует");
            }
            else
            {
                if (other is Figure)
                {
                    
                }
            }
        }
    }
}