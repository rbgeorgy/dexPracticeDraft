using System;

namespace CastingAndTypeConversionClassLibrary
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
}