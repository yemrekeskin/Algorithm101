using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrencesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] A = new int[8] { 9, 3, 9, 3, 9 , 7, 9 , 11 };
            int[] A = new int[7] { 1, 5, 3, 1, 5, 5 , 5 };
            //int[] A = new int[5] { -1, 1, 3, 3, 1 };

            var result = solution(A);

            Console.ReadLine();
        }

        public static int solution(int[] A)
        {
            int result = 0;

            if(!CheckNums(A))
            {
                return result;
            }

            List<int> unpaireds = new List<int>();
            List<int> paireds = new List<int>();

            foreach (int num in A)
            {
                if(unpaireds.Contains(num))
                {
                    unpaireds.Remove(num);
                    paireds.Add(num);
                }
                else
                {
                    unpaireds.Add(num);
                }
            }

            if (unpaireds.Count > 1)
                return result;

            result = unpaireds[0];
            return result;
        }

        public static bool CheckNums(int[] A)
        {
            List<int> nums = A.ToList();

            // Array Check
            //if (nums.Count == 0 || nums.Count > 1000000)
              //  return false; // ?

            foreach (int num in nums)
            {
                // Range Check
                if (num < 1 || num > 1000000000)
                    return false;

                // Odd Check
                if (num % 2 != 1) 
                    return false;

            }
            return true;
        }
    }

}
