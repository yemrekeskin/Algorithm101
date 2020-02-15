using System;
using System.Linq;

namespace PalindromeCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var s = "aaa";
            var r = countPalindromes(s);

            Console.ReadLine();
        }

        public static int countPalindromes(string s)
        {
            int counter = 0;
            int n = s.Length;

            for (int i = 0; i < n; i++)
            {
                int d = i, b = i;
                
                for (int L = 0; L < n; L++)
                {
                    if ((d >= 0) && (b < n) && (s[b] == s[d]))
                    {
                        counter++;
                        d--;
                        b++;
                    }
                }
                
                d = i; b = i + 1;

                for (int L = 0; L < n; L++)
                {
                    if ((d >= 0) && (b < n) && (s[b] == s[d]))
                    {
                        counter++;
                        d--;
                        b++;
                    }
                }
                
            }
            return counter;
        }

        //public static int countPalindromes(string s)
        //{
        //    if (String.IsNullOrEmpty(s)) return 0;

        //    int n = s.Length;
        //    if (n == 1) return 1;

        //    int count = 0;

        //    // subsets
        //    bool[,] status = new bool[n,n];

        //    // SubString --> if Length = 1
        //    for (int i = 0; i < n; i++)
        //    {
        //        status[i, i] = true;
        //        count++;
        //    }

        //    // SubString --> if Length = 2
        //    for (int i = 0; i < n - 1; i++)
        //    {
        //        if(s.Substring(i) == s.Substring(i+1))
        //        {
        //            status[i, i] = true;
        //            count++;
        //        }                
        //    }

        //    return count;
        //}

        public static bool isPalindrome(string s)
        {
            var r = new string(s.Reverse().ToArray());
            return s == r;
        }
    }
}
