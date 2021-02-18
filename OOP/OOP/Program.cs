using System;

namespace OOP
{

    abstract class Animal
    {
        public abstract String GetInfo();
    }

    class Mammal : Animal
    {
        private const String _baseInfo = "This animal is mammal. ";
        public override String GetInfo()
        {
            return _baseInfo;
        }
    }

    class Reptile : Animal
    {
        private const String _baseInfo = "This animal is reptile. ";
        public override string GetInfo()
        {
            return _baseInfo;
        }
    }

    class Cow : Mammal
    {
        private const String _baseInfo = "This animal is Cow. ";
        public override string GetInfo()
        {
            return base.GetInfo() + _baseInfo;
        }
    }

    class Dragon : Reptile
    {
        private const String _baseInfo = "This animal is Dragon. ";
        public override string GetInfo()
        {
            return base.GetInfo() + _baseInfo;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Dragon dragon = new Dragon();
            Cow cow = new Cow();
            Console.WriteLine(cow.GetInfo());
            Console.WriteLine(dragon.GetInfo());
            Console.WriteLine();
            var zoo = new Animal[] { new Cow(), new Dragon()};

            foreach (var animal in zoo)
            {
                Console.WriteLine(animal.GetInfo());
            }
        }
    }
}