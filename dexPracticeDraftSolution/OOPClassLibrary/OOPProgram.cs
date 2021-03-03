using System;

namespace OOPClassLibrary
{
    static class OOPProgram
    {
        public static void RunProgram()
        {
            Dragon dragon = new Dragon();
            Cow cow = new Cow();
            Console.WriteLine(cow.GetInfo());
            Console.WriteLine(dragon.GetInfo());
            Console.WriteLine();
            var zoo = new Animal[] { new Cow(), new Dragon()};////&&&

            foreach (var animal in zoo)
            {
                Console.WriteLine(animal.GetInfo());
            }
        }
    }
}
