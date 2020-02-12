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

        static int[] rotLeft(int[] arr, int d)
        {
            var result = new int[arr.Length]; // 5
            
            // 5 - 1 = 4
            var effective = arr.Length - (d % arr.Length);

            for (int i = 0; i < arr.Length; i++)
            {
                result[(i + effective) % arr.Length] = arr[i];
            }

            return result;
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");

        //    //An array of integers .
        //    //An integer, the number of rotations.

        //    int[] a = { 1, 2, 3, 4, 5 };
        //    int d = 3;
        //    int[] result = rotLeft(a, d);

        //    Console.ReadLine();
        //}

        //static int[] rotLeft(int[] arr, int d)
        //{
        //    var temp = arr;
        //    for (int i = 0; i < d; i++)
        //    {
        //        temp = swap(temp);
        //    }
        //    return temp;
        //}

        //static int[] swap(int[] arr)
        //{
        //    var first = arr[0];
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        arr[i - 1] = arr[i];
        //    }
        //    arr[arr.Length - 1] = first;
        //    return arr;
        //}
    }
}
