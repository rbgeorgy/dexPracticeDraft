using System;

namespace OOPClassLibrary
{
    class Reptile : Animal
    {
        private const String _baseInfo = "This animal is reptile. ";
        public override string GetInfo()
        {
            return _baseInfo;
        }
    }
}