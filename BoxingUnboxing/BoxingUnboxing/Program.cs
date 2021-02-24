using System;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var watchBoxing = new System.Diagnostics.Stopwatch();
            double toBox = Math.PI;
            watchBoxing.Start();
            object toBoxObject = toBox;
            for (int i = 0; i < 1000000; i++)
            {
                toBoxObject = toBox;
            }
            watchBoxing.Stop();
            Console.WriteLine($"Boxing 100000 Double Execution Time: {watchBoxing.ElapsedMilliseconds} ms");
            
            var watchUnoxing = new System.Diagnostics.Stopwatch();
            watchUnoxing.Start();
            double unboxedDouble = (double) toBoxObject;
            for (int i = 0; i < 1000000; i++)
            {
                unboxedDouble = (double) toBoxObject;
            }
            
            watchUnoxing.Stop();
            Console.WriteLine($"Unboxing 100000 Double Execution Time: {watchUnoxing.ElapsedMilliseconds} ms");
            

        }
    }
}