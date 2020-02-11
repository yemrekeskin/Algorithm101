using System;

namespace BugFixesd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] A = new int[7] { 1, 2, 3, 3, 1, 3, 1 };

            var result = solution(3, A);
            Console.WriteLine("RESULT --> {0}", result);

            Console.ReadLine();
        }

        public static int solution(int M, int[] A)
        {
            int N = A.Length;
            int[] count = new int[M + 1];
            for (int i = 0; i <= M ; i++)
            {
                count[i] = 0;
            }

            int maxOccurence = 1;
            int index = -1;

            for (int i = 0; i < N; i++)
            {
                if(count[A[i]] > 0)
                {
                    int tmp = count[A[i]];
                    if(tmp > maxOccurence)
                    {
                        maxOccurence = tmp;
                        index = i;
                    }
                }
                else
                {
                    count[A[i]] = 1;
                }
            }
            return A[index];
        }
    }
}
