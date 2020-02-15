using System;
using System.Collections.Generic;
using System.Linq;

namespace SubStringList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string str = "aaa";

            List<string> substrings = new List<string>();
            List<string> polindromeList = new List<string>();

            int counter = 0;

            for (int i = 1; i < str.Length; i++)
            {
                for (int j = 0; j <= str.Length - i; j++)
                {
                    string substring = str.Substring(j, i);
                    substrings.Add(substring);

                    if(isPalindrome(substring))
                    {
                        polindromeList.Add(substring);
                        counter++;
                    }
                }
            }



            Console.ReadLine();
        }

        public static bool isPalindrome(string s)
        {
            var r = new string(s.Reverse().ToArray());
            return s == r;
        }
    }
}
