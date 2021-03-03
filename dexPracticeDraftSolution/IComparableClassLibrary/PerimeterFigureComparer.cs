using System;
using System.Collections.Generic;

namespace IComparableClassLibrary
{
    public class PerimeterFigureComparer : IComparer<Figure>
    {
        private const double Precision = 0.00001;
        public int Compare(Figure x, Figure y)
        {
            if (x != null && y != null)
            {
                double xPerimeter = x.GetPerimeter();
                double yPerimeter = y.GetPerimeter();
                if (xPerimeter < yPerimeter) return -1;
                else if (Math.Abs(xPerimeter - yPerimeter) < Precision) return 0;
                else return 1;
            }
            else
            {
                throw new ArgumentNullException("При сравнении фигур возникла ошибка: аргумент не может быть null.");
            }
        }
    }
}