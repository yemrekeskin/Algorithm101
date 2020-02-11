using System;

namespace EpicFall
{
    class Program
    {
        static void Main(string[] args)
        {
            // en çok tekrar eden karakterin index bilgisini elde etmek için
             
            var str = "abbcccddddcccbbaa";

            char[] c = str.ToCharArray();
            int count = 1;

            int longestRun = 0;
            int longestPosition = 0;

            int position = 0;

            for (int i = 0; i < c.Length - 2; i++)
            {
                position = i;
                if (c[i] == c[i + 1]) count++;
                else
                {
                    if (longestRun < count)
                    {
                        longestRun = count;
                        longestPosition = position - count + 1;
                    }
                    else count = 1;
                }
            }
        }
    }
}
