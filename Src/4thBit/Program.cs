using System;

namespace _4thBit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //int number = 23;
            int number = 10;
            int result = fourthBit(number);

            Console.ReadLine();
        }

        /*
         * Complete the 'fourthBit' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER number as parameter.
         */
        public static int fourthBit(int number)
        {
            string bit = Convert.ToString(number, 2);
            if(bit.Length >= 4)
            {
                string val = bit.Substring(bit.Length - 4)[0].ToString();
                return Convert.ToInt32(val);
            }
            else
            {
                return 0;
            }            
        }
    }
}
