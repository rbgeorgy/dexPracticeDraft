using System;

namespace OOPClassLibrary
{
    class Mammal : Animal
    {
        private const String _baseInfo = "This animal is mammal. ";
        public override String GetInfo()
        {
            return _baseInfo;
        }
    }
}