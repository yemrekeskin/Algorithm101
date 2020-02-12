using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string s1 = "aardvark";
            string s2 = "apple";
            string result = twoStrings(s1, s2);


            Console.ReadLine();
        }

        // Complete the twoStrings function below.
        static string twoStrings(string s1, string s2)
        {
            char[] s1Words = s1.ToCharArray().Distinct().OrderBy(d => d).ToArray();

            foreach (char ch in s2.ToCharArray())
            {
                var d = Array.BinarySearch(s1Words, ch);
                if (d >= 0)
                    return "YES";
            }
            return "NO";
        }
    }
}
