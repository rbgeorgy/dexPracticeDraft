using System;
using OOPClassLibrary;
using ValueTypeAndReferenceTypeClassLibrary;
using CastingAndTypeConversionClassLibrary;
using BoxingUnboxingClassLibrary;
using dexPracticeTotal.EqualityClassLibrary;
using dexPracticeTotal.GenericClassLibrary;
using dexPracticeTotal.ListAndDictionary;
using IEnumerableIEnumeratorClassLibrary;
using IQueryableClassLibrary;
using IComparableClassLibrary;

namespace dexPracticeTotal
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nДля выхода нажмите q. \nЧтобы запустить демо введите, число от 3 до 21(номер темы):");
                String choise = Console.ReadLine();
            
                switch (choise)
                {
                    case "3":
                        OOPProgram.RunProgram();
                        break;
                    case "4":
                        ValueTypeAndReferenceTypeProgram.RunProgram();
                        break;
                    case "5":
                        CastingAndTypeConversionProgram.RunProgram();
                        break;
                    case "6":
                        BoxingUnboxingProgram.RunProgram();
                        break;
                    case "7":
                        IEnumerableIEnumeratorProgram.RunProgram();
                        break;
                    case "8":
                        IQueryableProgram.RunProgram();
                        break;
                    case "9":
                        IComparableProgram.RunProgram();
                        break;
                    case "10":
                        EqualityProgram.RunProgram();
                        break;
                    case "11":
                        ListAndDictionaryProgram.RunProgram();
                        break;
                    case "12":
                        UniqueCollectionProgram.RunProgram();
                        break;
                    case "q":
                        return;
                    default:
                        Console.WriteLine("Запустите программу с существующим номером темы в качестве аргумента");
                        break;
                
                }   
            }
        }
    }
}