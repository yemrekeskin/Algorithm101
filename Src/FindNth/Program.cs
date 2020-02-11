using System;

namespace FindNth
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = findNth(2);
            var result2 = SumDigit(123);
            var result3 = IsLucky(123456);
            var result4 = IsLucky(1234562);

            Console.ReadLine();
        }

        static int findNth(int A)
        {
            int count = 0;

            for (int current = 1;; current++)
            {
                int sum = 0;
                for (int x = current; x > 0; x = x / 10)
                    sum = sum + x % 10;

                if (sum == 10) count++;

                if (count == A) return current;

            }
        }

        static int SumDigit(int A)
        {
            int sum = 0;

            while(A > 0)
            {
                var last = A % 10;
                sum += last;
                A = A / 10;
            }

            return sum;
        }

        static bool IsLucky(int A)
        {
            bool[] controller = new bool[10];

            for (int i = 0; i < controller.Length - 1; i++)
                controller[i] = false;

            while(A > 0)
            {
                int digit = A % 10;
                if (controller[digit]) return false;
                controller[digit] = true;
                A = A / 10;
            }
            return true;
        }
    }
}
