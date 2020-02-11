using System;
using System.Linq;

namespace RepeatedString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string s = "aba";
            long n = 10;
            long result = repeatedString(s, n);

            Console.ReadLine();
        }

        // Complete the repeatedString function below.
        static long repeatedString(string s, long n)
        {
            long repeatedCount = n / s.Length;
            long occurences = s.ToCharArray().Count(d => d == 'a');

            int temp = 0;
            if (repeatedCount * s.Length != n)
            {
                int remaining = Convert.ToInt32(n - (repeatedCount * s.Length));
                temp = s.Substring(0, remaining).ToCharArray().Count(d => d == 'a');
            }
            return (repeatedCount * occurences) + temp;
        }
    }
}
