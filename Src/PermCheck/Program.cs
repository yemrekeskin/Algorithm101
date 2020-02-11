using System;
using System.Linq;

namespace PermCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //int[] A = new int[3] { 4, 1, 3 };
            int[] A = new int[3] { 4, 1, 1 };

            var result = solution(A);
            Console.WriteLine("RESULT --> {0}", result);

            Console.ReadLine();
        }

        public static int solution(int[] A)
        {
            int value = 0;

            int N = A.Length;        
            if (N > 100000 || N == 0) return value;
            // duplicate values detect
            if (N != A.Distinct().Count()) return value;


            var sumUntilN = N * (N + 1) / 2;
            var sumElements = A.Select(x => (long)x).Sum();

            if (sumElements == sumUntilN) value = 1;

            return value;
        }
    }
}
