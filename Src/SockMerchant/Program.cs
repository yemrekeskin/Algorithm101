using System;
using System.Collections.Generic;

namespace SockMerchant
{
    class Program
    {
        // Complete the sockMerchant function below.
        // Eşleşen kayıtların sayısını bulmak
        // çorap dükkanında renkleri eşleşen çorapların sayısını bulmak
        // 1-2-1-2-1-3-2
        static int sockMerchant(int[] sockPile)
        {
            int pairFound = 0;
            var paired = new List<int>();

            foreach (var sock in sockPile)
            {
                if(paired.Contains(sock))
                {
                    pairFound++;
                    paired.Remove(sock);
                }
                else
                {
                    paired.Add(sock);
                }
            }
            return pairFound;
        }
        
        static void Main(string[] args)
        {
            string socks = "1 2 1 1 2 3 3 4 5";

            var ar_temp = socks.Split(' ');
            var ar = Array.ConvertAll(ar_temp, Int32.Parse);

            var result = sockMerchant(ar);
            Console.WriteLine("Paired Socks --> " + result);

            Console.ReadLine();
        }
    }
}
