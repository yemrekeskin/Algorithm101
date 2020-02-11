using System;
using System.Collections.Generic;
using System.Linq;

namespace CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int n = 8;
            string s = "UDDDUDUU";
            int result = countingValleys(n, s);


            Console.ReadLine();
        }

        // Complete the countingValleys function below.
        static int countingValleys(int n, string steps)
        {
            var valleys = 0;
            var deltas = new[] { 1, -1 };
            var directions = new[] { 'U', 'D' };
            var current = 0;

            foreach (var s in steps.ToCharArray())
            {
                if (!directions.Contains(s)) throw new ArgumentException();

                var effective = Array.IndexOf(directions, s);

                var temp = current;

                current += deltas[effective];
                if (current == 0 && temp < 0)
                    valleys++;
            }

            return valleys;
        }
    }
}
