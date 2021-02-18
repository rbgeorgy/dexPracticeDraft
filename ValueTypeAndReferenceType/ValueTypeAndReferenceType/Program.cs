using System;

namespace ValueTypeAndReferenceType
{
    enum EnumForOurClass
    {
        FirstValue, SecondValue
    }

    struct Pair<T>
    {
        public T first, second;

        public Pair(T first, T second)
        {
            this.first = first;
            this.second = second;
        }
    }

    interface IMyClonable
    {
        public object Clone();
    }

    class SomethingNeedToBeCloned : IMyClonable
    {
        public bool propBool { get; set; }
        public short propShort { get; set; }
        public int propInt { get; set; }
        public double propDouble { get; set; }
        public EnumForOurClass propEnum { get; set; }
        public Pair<char> propStruct { get; set; }


        public object Clone()
        {
            return new SomethingNeedToBeCloned {
                propBool = this.propBool, 
                propShort = this.propShort, 
                propInt = this.propInt, 
                propDouble = this.propDouble, 
                propEnum = this.propEnum, 
                propStruct =this.propStruct
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SomethingNeedToBeCloned original = new SomethingNeedToBeCloned
            {
                propBool = true, 
                propShort = 1, 
                propInt = 2, 
                propDouble = 3.0, 
                propEnum = EnumForOurClass.FirstValue, 
                propStruct = new Pair<char>('a','b')
            };
            
            SomethingNeedToBeCloned clone = (SomethingNeedToBeCloned) original.Clone();
            Console.WriteLine(clone.propStruct.first);
        }
    }
}