using System;

namespace OOPClassLibrary
{
    class Cow : Mammal
    {
        private const String _baseInfo = "This animal is Cow. ";
        public override string GetInfo()
        {
            return base.GetInfo() + _baseInfo;
        }
    }
}