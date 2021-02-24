using System;

namespace OOP
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