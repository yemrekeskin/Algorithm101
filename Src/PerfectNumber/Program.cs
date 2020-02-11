using System;

namespace PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var result = solution(4, 17);
            Console.WriteLine("RESULT --> {0}", result);

            Console.ReadLine();
        }

        public static int solution(int A, int B)
        {
            int count = 0;
            for (int i = A; i <= B; i++)
            {                    
                for (int j = 1; j * j <= i; j++)
                {
                    if (j * j == i)
                        count++;
                }
            }

            return count;
        }
    }
}
