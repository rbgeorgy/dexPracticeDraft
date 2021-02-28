using System;
namespace IComparableClassLibrary
{
    static class IComparableProgramClassLibrary
    {
        private static Figure[] _figureArray;
        public static void Generate()
        {
            var rand = new Random();
            _figureArray = new Figure[10];
            for (int i = 0; i < 10; i++)
            {
                switch (i % 3)
                {
                    case 0:
                        _figureArray[i] = new Circle(rand.Next(1, 10));
                        break;
                    case 1:
                        _figureArray[i] = new Rectangle(rand.Next(1, 5), rand.Next(1, 5));
                        break;
                    case 2:
                        _figureArray[i] = new Triangle((10 - i), (10 - i), (10 - i));
                        break;
                }
            }
        }

        public static void RunDemo()
        {
            Generate();
            Console.WriteLine("Сгенерированный массив: ");
            foreach (var item in _figureArray)
            {
                Console.WriteLine(item + " с площадью: " + item.GetSquare());
            }

            Console.WriteLine();
            Array.Sort(_figureArray);
            Console.WriteLine("Отсортированный с помощью наследования от IComparable массив: ");
            foreach (var item in _figureArray)
            {
                Console.WriteLine(item + " с площадью: " + item.GetSquare());
            }
            Console.WriteLine();
            Console.WriteLine("Сгенерированный массив : ");
            Generate();
            foreach (var item in _figureArray)
            {
                Console.WriteLine(item + " с площадью: " + item.GetSquare());
            }
            
            Console.WriteLine();
            Array.Sort(_figureArray, new FigureComparer());
            Console.WriteLine("Отсортированный с помощью IComparer<Figure> массив №2: ");
            foreach (var item in _figureArray)
            {
                Console.WriteLine(item + " с площадью: " + item.GetSquare());
            }
        }

        public static void RunProgram()
        {
            RunDemo();
        }
    }
}
