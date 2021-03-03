using System;
using System.Collections;

namespace IEnumerableIEnumeratorClassLibrary
{
    public class GeometricFigureEnumerator : IEnumerator
    {
        public GeometricFigure[] Figures;
        private int _position = -1;

        public GeometricFigureEnumerator(GeometricFigure[] items)
        {
            Figures = items ?? throw new ArgumentNullException(nameof(items));
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
}
