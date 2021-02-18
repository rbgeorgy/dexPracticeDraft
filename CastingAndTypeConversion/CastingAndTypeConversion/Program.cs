using System;
//     • Реализовать класс Person (FirstName, LastName), определить операторы неявного/явного
// преобразования к строке, продемонстрировать работу. Пример: "Иванов Иван" должен
//     преобразовываться в Person.
//     • Попробуйте сравнить экземпляр Person и текст при помощи оператора ==, затем при
// помощи Equals(), объясните результат.
namespace CastingAndTypeConversion
{
    class Person
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public static implicit operator String(Person person) => person.FirstName + " " + person.LastName;
        public static explicit operator Person(String string_) => new Person
        {
            FirstName = string_.Split(" ")[0], 
            LastName = string_.Split(" ")[1]
        };
    }

    class Program
    {
        static void Main(string[] args)
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