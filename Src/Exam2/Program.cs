using System;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = solution(-17, 37);

            Console.WriteLine("Hello World!");
        }

        public static int solution(int A, int B)
        {
            int count = 0;
            A = A < 1 ? 1 : A;
            // tam kare sayılar 1 dahil başlar
            for (int i = A; i <= B; i++)
            {
                double result = Math.Sqrt(i);
                if (result % 1 == 0) count++;
            }
            return count;
        }
    }
}
