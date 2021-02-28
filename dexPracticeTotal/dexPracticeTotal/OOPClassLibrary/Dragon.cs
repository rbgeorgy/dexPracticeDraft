using System;

namespace OOPClassLibrary
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