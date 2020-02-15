using System;

namespace Exam4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int n = 15;
            fizzBuzz(n);

            Console.ReadLine();
        }

        public static void fizzBuzz(int n)
        {
            string result = String.Empty;
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    result += "Fizz";
                }
                if (i % 5 == 0)
                {
                    result += "Buzz";
                }
                if (i % 3 != 0 && i % 5 != 0)
                {
                    result += i.ToString();
                }
                result += "\n";
            }
            Console.WriteLine(result);
        }

        public static void newVersionFizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
