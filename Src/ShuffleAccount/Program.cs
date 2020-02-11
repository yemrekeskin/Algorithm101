using System;
using System.Collections.Generic;

namespace ShuffleAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // 123456
            // --> result : 162534

            var result = solution(123456);
            Console.WriteLine("RESULT --> {0}", result);

            Console.ReadLine();
        }

        public static int solution(int A)
        {
            string value = String.Empty;

            if (A < 0 || A > 1000000000) return 0;

            var N = A.ToString().Length;

            while (A.ToString().Length > 0 && A != 0)
            {
                var last = A % 10;

                int digits = (int)(Math.Log10(A));
                var first = (int)(A / (int)(Math.Pow(10, digits)));

                if (digits == 0) value = value + first;
                else value = value + first + last;

                var temp = ((int)Math.Pow(10, digits) * first) + last;
                A = (A - temp) / 10;
            }

            /*int digits = (int)(Math.Log10(A));
            var firstDigit = (int)(A / (int)(Math.Pow(10, digits)));

            var lastDigit = A % 10;

            var d = (int)(Math.Pow(10, digits));
            var remaining = (d * firstDigit) + lastDigit;

            var newA = (A - remaining) / 10;*/

            return  Convert.ToInt32(value);
        }
    }
}
