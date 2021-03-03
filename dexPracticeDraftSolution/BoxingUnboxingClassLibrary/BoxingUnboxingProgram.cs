using System;

namespace BoxingUnboxingClassLibrary
{
    static class BoxingUnboxingProgram
    {
        public static void RunProgram()
        {
            var watch = new System.Diagnostics.Stopwatch();
            double toBox = Math.PI;
            watch.Start();
            object toBoxObject = toBox;
            for (int i = 0; i < 1000000; i++)
            {
                toBoxObject = toBox;
            }
            watch.Stop();
            Console.WriteLine($"Boxing 100000 Double Execution Time: {watch.ElapsedMilliseconds} ms");
            watch.Reset();

            watch.Start();
            double unboxedDouble = (double)toBoxObject;
            for (int i = 0; i < 1000000; i++)
            {
                unboxedDouble = (double)toBoxObject;
            }

            watch.Stop();
            Console.WriteLine($"Unboxing 100000 Double Execution Time: {watch.ElapsedMilliseconds} ms");
        }
    }
}
