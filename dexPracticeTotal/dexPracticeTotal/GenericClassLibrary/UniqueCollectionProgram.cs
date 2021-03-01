using System;
using System.Collections.ObjectModel;
using dexPracticeTotal.EqualityClassLibrary;

namespace dexPracticeTotal.GenericClassLibrary
{
    public static class UniqueCollectionProgram
    {
        private delegate void AddFunction<T>(UniqueCollection<T> uniqueCollection, Collection<T> toAdd);

        private static void _test<T>(AddFunction<T> addFunction, Collection<T> toAdd)
        {
            UniqueCollection<T> uniqueCollection = new UniqueCollection<T>();
            try
            {
                addFunction(uniqueCollection, toAdd);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                uniqueCollection.Print();
            }
        }

        private static void _addFunctionMethod<T>(UniqueCollection<T> uniqueCollection, Collection<T> toAdd)
        {
            foreach (T item in toAdd)
            {
                uniqueCollection.Add(item);
            }
        }

        public static void RunProgram()
        {
            _test(_addFunctionMethod<int>, new Collection<int>{1, 2, 3, 1});
            _test(_addFunctionMethod<double>, new Collection<double>{2.1545, 4312, Math.PI, 1});
            
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

            Person personThree = new Person(
                "Ivanov Ivan Ivanovich",
                "01.01.1990",
                "Nezavertailovka",
                "AA2281337"
            );
            _test(_addFunctionMethod<Person>, new Collection<Person> {personOne, personTwo, personThree});
        }
    }
}