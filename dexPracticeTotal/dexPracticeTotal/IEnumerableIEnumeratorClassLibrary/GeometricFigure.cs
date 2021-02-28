using System;

namespace IEnumerableIEnumeratorClassLibrary
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
}