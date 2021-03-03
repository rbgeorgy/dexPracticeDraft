using System;
namespace CastingAndTypeConversionClassLibrary
{
    static class CastingAndTypeConversionProgram
    {
        public static void RunProgram()
        {
            String name = "";
            Person person = new Person {FirstName = "Ivanov", LastName = "Ivan"};
            name = person;
            Console.WriteLine(name);
            name = "Some Name";
            person = (Person)name;
            Console.WriteLine(person);
            Console.WriteLine("Check == operator:");
            Console.WriteLine(name == person);//True, так как происходит неявное преобразование person в String
            Console.WriteLine("Check String.Equals(Person):");
            Console.WriteLine(name.Equals(person));//True так как, так как происходит неявное преобразование person в String
            Console.WriteLine("Check Person.Equals((Person)String):");
            Console.WriteLine(person.Equals((Person)name));//False, поскольку мы вернули НОВЫй объект, а метод Equals() для Person не переопределён

        }
    }
}
