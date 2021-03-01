using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lungime array:");
            int lungime = int.Parse(Console.ReadLine());
            int[] arr = new int[lungime];
            for(int i = 0; i< lungime; i++)
            {
                arr[i] = i + 1;
            }
            afisareVector(arr);
            Console.WriteLine();
            Console.WriteLine("Nr rotatii");
            int nrRot = int.Parse(Console.ReadLine());
            int[] output = rotateArr(arr, nrRot);
            afisareVector(output);
            


        }
        static void afisareVector(int [] arr)
        {
            int l = arr.Length;
            for(int i = 0; i < l; i ++)
            {
                Console.Write(arr[i] +" ");
            }     

        }
        static int[] rotateArr(int[] array,int nrRot)
        {
           if(nrRot == 0)
            {
                return array;
            }

            int[] aux = new int [array.Length];
            int j = 0;
            for(int i = nrRot; i < array.Length; i++ )
            {
                aux[j] = array[i];
                j++;
            }
            for (int i = 0; i < nrRot; i++)
            {
                aux[j] = array[i];
                j++;
            }
            return(aux);

        }      
    }
}
