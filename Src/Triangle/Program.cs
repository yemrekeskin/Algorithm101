using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int solution(int[] A)
        {
            Array.Sort(A);
            if (A.Length < 3) return 0;

            for (int i = 0; i < A.Length - 2; i++)
            {
                if(A[i] + A[i+1] > A[i+2])
                {
                    return 1;
                    //break;
                }
            }
            return 0;
        }
    }
}
