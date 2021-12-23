using System;
using System.Collections.Generic;

namespace Equilibrium_index
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr =  { 0, -3, 5, -4, -2, 3, 1, 0 };
            Console.WriteLine(string.Join(",", Equilibrium(arr)));
        }

        public static List<int> Equilibrium(int[] arr)
        {
            int len = arr.Length;
            int[] left = new int[len];
            List<int> res = new List<int>();
            left[0] = arr[0];
            for (int i = 1; i < len; i++)
            {
                left[i] = arr[i]+left[i-1];
            }

            int right = 0;
            for (int i = len-1; i >=0 ; i--)
            {
                right += arr[i];
                if (right == left[i])
                    res.Add(i);
            }

            return res;
        }
    }
}
