using System;
using System.Collections.Generic;
using System.Linq;

namespace RansomNote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] m = { "give", "me", "one", "grand", "today", "night" };
            string[] n = { "give", "one", "grand", "today" };

            checkMagazine(m, n);

            string[] m1 = { "two", "times", "three", "is", "not", "four" };
            string[] n1 = { "two", "times", "two", "is", "four" };

            checkMagazine(m1, n1);

            string[] m2 = { "ive", "got", "a", "lovely", "bunch", "of", "coconuts" };
            string[] n2 = { "ive", "got", "some", "coconuts" };

            checkMagazine(m2, n2);


            Console.ReadLine();
        }

        static void checkMagazine(string[] magazine, string[] note)
        {
            var dic = new SortedDictionary<string, int>();

            foreach (var group in magazine.GroupBy(x => x))
            {
                dic.Add(group.Key, group.Count());
            }

            foreach (var word in note.GroupBy(x => x))
            {
                var groupCount = dic.TryGetValue(word.Key, out int count);
                if (!groupCount || word.Count() > count)
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");
        }
    }
}
