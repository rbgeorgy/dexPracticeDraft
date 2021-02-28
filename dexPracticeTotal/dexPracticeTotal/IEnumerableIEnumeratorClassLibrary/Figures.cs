using System;
using System.Collections;

namespace IEnumerableIEnumeratorClassLibrary
{
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
}