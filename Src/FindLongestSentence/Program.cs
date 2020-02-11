using System;
using System.Collections.Generic;

namespace FindLongestSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Write a C# Sharp Program to display the following pattern using the alphabet.";

            var result = GetLongestWords(text);

            Console.ReadLine();
        }

        public static string getLongestSentence(string A)
        {
            string value = String.Empty;

            char[] separators = new char[] { '!', '.', '?' };
            string[] sentences1 = "First sentence. Second sentence!".Split(separators);
            string[] sentences2 = "First sentence. Second sentence!".Split('!', '.', '?');

            return value;
        }

        public static string GetLongestWords(string A)
        {
            string[] words = A.Split(new[] { " " }, StringSplitOptions.None);

            string longestWord = String.Empty;
            int controller = 0;
            foreach (string word in words)
            {
                if(word.Length > controller)
                {
                    longestWord = word;
                    controller = word.Length;
                }
            }

            return longestWord;
        }

    }
}
