using System;

namespace PassingCars
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 1, 0, 1, 1 };
            int n = A.Length;

            var result = solution(A);

            Console.ReadLine();
        }

        public static int solution(int[] A)
        {
            int l = A.Length;

            int countZero = 0;
            int countPairs = 0;

            int exceed = 1000000000;

            for (int i = 0; i < l; i++)
            {
                if (A[i] == 1) countPairs += countZero;
                else countZero++;
            }

            if (countPairs > exceed || countPairs < 0) return -1;
            else return countPairs;
        }
    }
}
