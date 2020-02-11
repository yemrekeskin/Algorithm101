using System;

namespace JumpingOnTheClouds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] c = { 0, 1, 0, 0, 0, 1, 0 };
            int result = jumpingOnClouds(c);

            Console.ReadLine();
        }

        static int jumpingOnClouds(int[] c)
        {
            int steps = 0;
            for (int i = 0; i < c.Length - 1; i++)
            {
                if (i + 2 < c.Length && c[i + 2] == 0) i++;
                steps++;
            }
            return steps;
        }
    }
}
