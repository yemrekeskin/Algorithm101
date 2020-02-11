using System;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 1234567;
            var result = solution(A);

            Console.ReadLine();
        }

        public static int solution(int A)
        {
            string Text = A.ToString();
            string result = String.Empty;
            for (int i = 0; i <= (Text.Length -1) / 2; i++)
            {
                if (i == Text.Length -1 - i)
                {
                    result = result + Text[i];
                }
                else
                {
                    result = result + Text[i] + Text[Text.Length - 1 - i];
                }                
            }

            return int.Parse(result);
        }
    }
}
