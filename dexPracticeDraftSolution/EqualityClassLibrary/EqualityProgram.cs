using System;

namespace dexPracticeTotal.EqualityClassLibrary
{
    public static class EqualityProgram
    {
        public static void RunProgram()
        {
            Person personOne = new Person(
            "Ivanov Ivan Ivanovich",
            "01.01.1990",
            "Nezavertailovka",
            "AA2281337"
            );
            
            Person personTwo = new Person(
                "Alekseyev Artyom Ivanovich",
                "21.01.1991",
                "Moscow",
                "AA1488146"
            );

            Console.WriteLine("personOne Equal to personTwo? " + personTwo.Equals(personOne));
            
            Person personThree = new Person(
                "Ivanov Ivan Ivanovich",
                "01.01.1990",
                "Nezavertailovka",
                "AA2281337"
            );
            Console.WriteLine("personOne Equal to personThree? " + personOne.Equals(personThree));
            Console.WriteLine();
            Console.WriteLine("GetHashCode personOne возвращает " + personOne.GetHashCode());
            Console.WriteLine("GetHashCode personTwo возвращает " + personTwo.GetHashCode());
            Console.WriteLine("GetHashCode personThree возвращает " + personThree.GetHashCode());
        }
    }
}