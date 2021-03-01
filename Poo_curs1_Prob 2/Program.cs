using System;

namespace Poo_curs1_Prob_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine($"Suma este {returnSum(v)}");
        }
        static int returnSum(int[] v)
        {
            int s = 0;
            for (int i = 0; i < v.Length; i++)
            {
                s += i;
            }
            return s;
        }
    }
}
