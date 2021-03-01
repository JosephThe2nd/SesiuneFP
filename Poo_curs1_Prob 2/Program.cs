using System;

namespace Poo_curs1_Prob_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine($"Suma este {returnSum(v)}");
            int suma = sumRecursiv(v, 0);
            Console.WriteLine($"Suma este {suma}");
        }
        /*
        static int returnSum(int[] v)
        {
            int s = 0;
            for (int i = 0; i < v.Length; i++)
            {
                s += i;
            }
            return s;
        }
        */
        static int sumRecursiv(int[] v , int index)
        {
            if (index == v.Length)
            {
                return 0;
            }
            return v[index] + sumRecursiv(v , index + 1);

        }
    }
}
