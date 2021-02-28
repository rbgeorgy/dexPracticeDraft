using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerableIEnumeratorClassLibrary
{
    static class IEnumerableIEnumeratorProgram
    {
        public static void RunProgram()
        {
            GeometricFigure[] figures = { 
                new GeometricFigure("Треугольник", 3),  
                new GeometricFigure("Квадрат", 4), 
                new GeometricFigure("Круг", 0), 
                new GeometricFigure("Пятиугольник", 5)
            };
            Figures ornament = new Figures(figures);
            foreach (GeometricFigure figure in ornament)
            {
                Console.WriteLine(figure);
            }

            Console.WriteLine();

            var enumerator =  ornament.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
