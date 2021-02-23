using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IQueryable
{

    class Product
    {
        public String Name { get; set; }
        public int Number { get; set; }
        public DateTime Time { get; set; }
        public bool IsAvailable { get; set;}

        public Product(String name, int number, DateTime time, bool isAvailable)
        {
            Name = name;
            Number = number;
            Time = time;
            IsAvailable = isAvailable;
        }

    }

    enum ProductEnum
    {
        Name, Number, Time, IsAvailable
    }

    class Program
    {
        private static Product[] products;
        static string[] productNames = { "Samsung", "Apple", "Huawei", "Nokia",
            "Sony", "HTC", "Motorola", "Lenovo",
            "Xiaomi", "Lg", "Meizu", "Asus", "ZTE", "Acer" };
        
        public static DateTime UnixTimeStampToDateTime( double unixTimeStamp )
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970,1,1,0,0,0,0,System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds( unixTimeStamp ).ToLocalTime();
            return dtDateTime;
        }
        
        public static bool NextBoolean(Random random)
        {
            return random.Next() > (Int32.MaxValue / 2);
        }
        
        static void Generate()
        {
            var rand = new Random();
            products = new Product[100];
            for (int i = 0; i < 100; ++i)
            {
                int rndIndex = rand.Next(productNames.Length);
                int rndNumber = rand.Next(0, 100);
                int rndUnixTime = rand.Next(1610000000,1614082083);
                products[i] = new Product(productNames[rndIndex], rndNumber, UnixTimeStampToDateTime(rndUnixTime), NextBoolean(rand));
                rand.Next(0, 100);
            }
        }

        static void Print(IEnumerable<Product> a, ProductEnum whatToPrint)
        {
            foreach (var item in a)
            {
                switch (whatToPrint)
                {
                    case ProductEnum.Name:
                        Console.WriteLine(item.Name);
                        break;
                    case ProductEnum.Number:
                        Console.WriteLine(item.Number);
                        break;
                    case ProductEnum.Time:
                        Console.WriteLine(item.Time);
                        break;
                    default: Console.WriteLine(item.IsAvailable);
                        break;
                }
            }
        }

        static void FirstDemo()
        {
            var numberDemo = products.Where(p => p.Number % 2 == 0).OrderBy(p => p.Number);
            Print(numberDemo, ProductEnum.Number);
        }

        static void SecondDemo()
        {
            var nameDemo = products.GroupBy(p => p.Name.Length).Select(g => new {Length = g.Key, Words = g});
            foreach (var item in nameDemo)
            {
                Console.WriteLine("Brands with length " + item.Words.Key + ":");
                foreach (var word in item.Words)
                    Console.WriteLine(word.Name);
            
            }
        }

        static void ThirdDemo()
        {
            String toReturn = products.All(p => ((DateTimeOffset) p.Time).ToUnixTimeSeconds() > 1614000000)
                ? "Все даты позднее, чем " + UnixTimeStampToDateTime(1614000000)
                : products.Any(p => ((DateTimeOffset) p.Time).ToUnixTimeSeconds() > 1614000000)
                    ? "Есть даты не позднее, чем " + UnixTimeStampToDateTime(1614000000)
                    : "Нет ни одной даты позднее, чем " + UnixTimeStampToDateTime(1614000000);
            Console.WriteLine(toReturn);
        }

        static void Main(string[] args)
        {
            Generate();
            //FirstDemo();
            //SecondDemo();
            //ThirdDemo();

            var isAvailableDemo = products.Where(p => p.IsAvailable).GroupBy(p => p.Name)
                .Select(g => new {Name = g.Key, productsWithCurrentName = g});
            List<int> sums = new List<int>();
            foreach (var item in isAvailableDemo)
            {
                int checkSum = item.productsWithCurrentName.Sum(p => p.Number);
                sums.Add(checkSum);
            }

            Console.WriteLine("Максимальное количество доступного товара одного бренда: " + sums.Max());
            Console.WriteLine("Минимальное количество доступного товара одного бренда: " + sums.Min());

        }
    }
}