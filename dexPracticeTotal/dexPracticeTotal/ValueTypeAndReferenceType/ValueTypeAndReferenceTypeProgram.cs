using System;

namespace ValueTypeAndReferenceTypeClassLibrary
{
    static class ValueTypeAndReferenceTypeProgram
    {
        public static void RunProgram()
        {
            SomethingNeedToBeCloned original = new SomethingNeedToBeCloned
            {
                PropBool = true, 
                PropShort = 1, 
                PropInt = 2, 
                PropDouble = 3.0, 
                PropEnum = EnumForOurClass.FirstValue, 
                PropStruct = new Pair<char>('a','b')
            };
            
            SomethingNeedToBeCloned clone = (SomethingNeedToBeCloned) original.Clone();
            Console.WriteLine("Объект успешно склонирован");
        }
    }
}
