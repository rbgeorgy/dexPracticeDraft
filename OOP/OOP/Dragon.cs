using System;

namespace OOP
{
    class Dragon : Reptile
    {
        private const String _baseInfo = "This animal is Dragon. ";
        public override string GetInfo()
        {
            return base.GetInfo() + _baseInfo;
        }
    }
}