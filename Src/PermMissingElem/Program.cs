using System;
using System.Linq;

namespace PermMissingElem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] A = new int[4] { 2, 3, 1, 5 };
            var result = solution(A);

            Console.WriteLine("RESULT --> {0} ",result);

            Console.ReadLine();
        }

        public static int solution(int[] A)
        {
            var N = A.Length;

            if (N == 0) return 1;
            
            if (N < 0 || N > 100000)
                return 1;

            var n = N + 1;
            var sumOfElements = n * (n + 1) / 2;
            var value = sumOfElements - A.Select(x => (long)x).Sum();

            return (int)value;
        }
    }
}
