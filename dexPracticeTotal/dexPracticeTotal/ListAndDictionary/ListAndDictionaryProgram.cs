using System;
using System.Collections.Generic;
using dexPracticeTotal.EqualityClassLibrary;

namespace dexPracticeTotal.ListAndDictionary
{
    public static class ListAndDictionaryProgram
    {
        private static Dictionary<Person, string> _placeOfWorkDirectory;
        
        public static void ReadInfo()
        {
            Console.WriteLine("Введите ФИО искомого работника: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите дату рождения искомого работника: ");
            string date = Console.ReadLine();
            Console.WriteLine("Введите место рождения искомого работника: ");
            string place = Console.ReadLine();
            Console.WriteLine("Введите номер паспорта искомого работника: ");
            string number = Console.ReadLine();

            Person query = new Person(name, date, place, number);
            if (_placeOfWorkDirectory.ContainsKey(query))
            {
                Console.WriteLine("Работник найден! Место работы: " + _placeOfWorkDirectory[query]);
            }
            else
            {
                Console.WriteLine("Такого работника нет в базе, хотите добавить? Y/N");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "Y":
                        Console.WriteLine("Введите место работы:");
                        string workPlace = Console.ReadLine();
                        if (workPlace == "") break;
                        _placeOfWorkDirectory.Add(query, workPlace);
                        Console.WriteLine("Работник " + query.NameSurname + " успешно добавлен.");
                        break;
                }
            }

        }

        public static void RunProgram()
        {
            
            Person personOne = new Person(
                "Ivanov Ivan Ivanovich",
                "01.01.1990",
                "Tiraspol",
                "AA2281337"
            );
            
            Person personTwo = new Person(
                "Alekseyev Artyom Ivanovich",
                "21.01.1991",
                "Moscow",
                "AA1488146"
            );
            
            Person personThree = new Person(
                "Nesterov Dmitry Sergeevich",
                "12.01.1990",
                "Sankt-Petersburg",
                "AA4515515"
            );

            _placeOfWorkDirectory =
                new Dictionary<Person, string>
                {
                    {personOne, "Tiraet"},
                    {personTwo, "JetBrains"},
                    {personThree, "SPBSU"}
                };
            
            ReadInfo();
        }
    }
}