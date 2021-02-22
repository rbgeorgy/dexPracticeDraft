using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerableIEnumerator
{
    public class GeometricFigure
    {
        public readonly String Name;
        public readonly int NumberOfAngles;

        public GeometricFigure(String name, int numberOfAngles)
        {
            this.Name = name;
            this.NumberOfAngles = numberOfAngles;
        }

        public override string ToString()
        {
            return Name + ". Число углов: " + NumberOfAngles + ".";
        }
    }

    public class Figures : IEnumerable
    {
        private GeometricFigure[] _figures;

        public Figures(GeometricFigure[] items)
        {
            _figures = new GeometricFigure[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                _figures[i] = items[i];
            }
        }
        
        //IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) GetEnumerator();
        
        public IEnumerator GetEnumerator() => new GeometricFigureEnumerator(_figures);
        
    }

    public class GeometricFigureEnumerator : IEnumerator
    {
        public GeometricFigure[] Figures;
        private int _position = -1;

        public GeometricFigureEnumerator(GeometricFigure[] items)
        {
            Figures = items;
        }

        public bool MoveNext()
        {
            _position++;
            return _position < Figures.Length;
        }

        public void Reset()
        {
            _position = -1;
        }

        public GeometricFigure Current
        {
            get
            {
                try
                {
                    return Figures[_position];
                }
                catch (Exception)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        object IEnumerator.Current => Current;

    }

    class Program
    {
        static void Main(string[] args)
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