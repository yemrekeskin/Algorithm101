using System;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = 1234;
            var result = ReverseNumber(d);

            string e = "Emre";
            var result2 = ReverseText(e);

            Console.ReadLine();
        }

        static int ReverseNumber(int A)
        {
            int reverse = 0;
            while(A > 0)
            {
                int remainder = A % 10; // last digit
                reverse = (reverse * 10) + remainder;

                A = A / 10; 
            }
            return reverse;
        }

        static string ReverseText(string A)
        {
            string reverse = String.Empty;

            int length = A.Length - 1;
            while(length >= 0)
            {
                reverse += A[length];
                length--;
            }

            return reverse;
        }
    }
}
