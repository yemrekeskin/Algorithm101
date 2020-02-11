using System;
using System.Collections.Generic;
using System.Linq;

namespace CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] A = new int[5] { 3, 8, 9, 7, 6 };
            int[] A = new int[4] { 1, 2, 3, 4 };

            var result = solution(A, 4);

            Console.ReadLine();
        }

        public static int[] solution(int[] A, int K)
        {
            
            List<int> nums = A.ToList();
            int[] result = new int[nums.Count];

            if (nums.Count == 0 || K == 0)
                return A;

            if (nums.Count < 0 || nums.Count > 100)
                return A;

            if (K < 0 || K > 100)
                return A;

            int cyclicNum = K % nums.Count;

            for (int i = 0; i < nums.Count; i++)
            {
                int stepNumber = i + cyclicNum;
                stepNumber = stepNumber % (nums.Count);

                result[stepNumber] = nums[i];
            }

            //var newNums = nums.Skip(1).Take(nums.Count() - 1).ToList();
            //newNums.Add(nums[0]);

            //int first = nums[0];
            //nums.RemoveAt(0);
            //nums.Add(first);

            return result.ToArray();
        }
    }
}
