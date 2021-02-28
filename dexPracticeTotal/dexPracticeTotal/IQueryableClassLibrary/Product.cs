using System;

namespace IQueryableClassLibrary
{
    public class Product
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
}