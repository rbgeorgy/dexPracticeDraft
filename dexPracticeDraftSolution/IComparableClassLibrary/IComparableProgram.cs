using System;
namespace IComparableClassLibrary
{
    static class IComparableProgram
    {
        private static Figure[] _figureArray;
        public static void Generate()
        {
            var rand = new Random();
            _figureArray = new Figure[100];
            for (int i = 0; i < _figureArray.Length; i++)
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
                        while (_figureArray[i] == null)
                        {
                            try
                            {
                                _figureArray[i] = new Triangle((rand.Next(1, 10)), rand.Next(1, 10), rand.Next(1, 10));
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Не удалось сгенерировать треугольник. Пробуем ещё раз..");
                            }
                        }
                        break;
                }
            }
        }

        public static void RunDemo()
        {
            Generate();
            Array.Sort(_figureArray);
            Console.WriteLine("Отсортированный с помощью наследования от IComparable массив: ");
            foreach (var item in _figureArray)
            {
                Console.WriteLine(item + " с площадью: " + item.GetSquare());
            }
            Console.WriteLine();
            
            Array.Sort(_figureArray, new PerimeterFigureComparer());
            Console.WriteLine("Отсортированный с помощью PerimeterComparer<Figure> массив: ");
            foreach (var item in _figureArray)
            {
                Console.WriteLine(item + " с периметром: " + item.GetSquare());
            }
        }

        public static void RunProgram()
        {
            RunDemo();
        }
    }
}
