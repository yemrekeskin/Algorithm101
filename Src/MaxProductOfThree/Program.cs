using System;

namespace MaxProductOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int solution(int[] A)
        {
            // sıralıyorum
            Array.Sort(A);

            // POSSIBLE 1
            int a = 0;
            if (A[0] < 0 && A[1] < 0)
                a = A[0] * A[1] * A[A.Length - 1]; // - * - * +

            // POSSIBLE 2
            int b = A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3];
            // son üç sayı

            if (a > b && (A[0] < 0 && A[1] < 0)) return a;
            else return b;
        }
    }
}
