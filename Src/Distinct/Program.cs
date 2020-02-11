using System;
using System.Collections.Generic;
using System.Linq;

namespace Distinct
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] A = new int[6] { 2, 1, 1, 2, 3, 1 };
            int[] A = new int[1] { 2 };

            var result = solution(A);

            Console.ReadLine();
        }

        public static int solution(int[] A)
        {
            int result = 0;
            List<int> nums = A.ToList();

            // CHECK
            if (nums.Count < 0 || nums.Count > 100000)
                return 0;
            
            // num, adet
            Dictionary<int, int> paired = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                //if (num < -1000000 || num > 1000000)
                //    return 0;

                if (paired.ContainsKey(num))
                    paired[num] = paired[num] + 1;
                else paired.Add(num, 1);
            }

            //nums.ForEach((num) =>
            //{
            //    if (paired.ContainsKey(num))
            //        paired[num] = paired[num] + 1;
            //    else paired.Add(num, 1);
            //});

            //result = paired.FirstOrDefault(d => d.Value == 1).Key;
            result = paired.Count();
            return result;
        }
    }
}
