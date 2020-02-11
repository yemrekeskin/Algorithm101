using System;

namespace LeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //An array of integers .
            //An integer, the number of rotations.

            int[] a = { 1, 2, 3, 4, 5 };
            int d = 2;
            int[] result = rotLeft(a, d);

            Console.ReadLine();
        }

        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            int remainingRotateCount = d % a.Length;

            var result = new int[a.Length];
            for (int i = remainingRotateCount; i < a.Length ; i++)
            {
                var item = a[i];
                result[i - remainingRotateCount] = item;
            }
            return result;
        }
    }
}
