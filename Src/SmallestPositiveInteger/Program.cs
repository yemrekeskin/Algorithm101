using System;
using System.Collections.Generic;
using System.Linq;

namespace SmallestPositiveInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //int[] A = new int[6] { 1, 3, 6, 4, 1, 2 };
            //int[] A = new int[3] { 1, 2, 3 };
            int[] A = new int[2] { -1, -3 };

            var result = Solution.solution(A);
            
            Console.ReadLine();
        }
    }

    public static class Solution {
        public static int solution(int[] A)
        {
            List<int> nums = A.ToList();
            List<int> paired = new List<int>();

            if (nums.Count < 1 || nums.Count > 1000000)
                return 0;

            int result = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] < -1000000 || nums[i] > 1000000)
                    return 0;

                int next = nums[i] + 1;
                if(nums.Contains(next))
                {
                    continue;
                }
                else
                {
                    if (next > 0)
                        paired.Add(next);
                } 
            }

            result = paired.Count == 0 ? 1 : paired.Min();
            return result;
        }
    }
}
