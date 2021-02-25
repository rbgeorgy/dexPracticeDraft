using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
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
