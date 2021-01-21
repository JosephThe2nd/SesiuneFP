using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema1();
            //Problema2();
            //Problema3();
            //Problema4();
            //Problema5();
            //Problema6();
            

        }
        /// <summary>
        /// Scrieți o funcție recursivă care să returneze cea mai mică cifră pară a unui număr natural
        /// transmis ca parametru. Dacă numărul nu conține nici o cifră pară, se va returna valoarea -1.
        /// </summary>
        private static int Problema7(int n, int min = -1)
        {
            if (n / 10 > 0)
            {
                if (n % 2 == 0)
                {
                    if (min == -1 || n % 10 < min) return Problema7(n / 10, n % 10);
                    else return Problema7(n / 10, min);


                }
                else return Problema7(n / 10, min);
            }
            else return min;
        }

        /// <summary>
        /// Scrieți o funcție care primește ca parametru un număr natural nenul n și afișează primele n 
        /// elemente ale șirului 1,1,1,2,2,1,1,1,2,2,2,3,3,3,…
        /// </summary>
        private static void Problema6()
        {
            int n = int.Parse(Console.ReadLine());
            int a = 1;
            while(n > 0)
            {
                for(int i = 1; i<= a ; i++)
                {
                    for(int j = a; j > 0; j--)
                    {
                        Console.Write(i + " ");
                        n--;
                        if (n == 0) return;         
                    }
                }
                a++;
            }

        }

        private static bool Problema5()
        {
           // L = 2piR Lungimea ecuatorului daca aduni 1 => L = 2piR + 1 => L = 2pi(R + 1 / 2pi) => distanta dintre Ecuador si Pamant R+1 / 2pi - R = 1 / 2pi = 0.15m = 15cm //
            Console.WriteLine("Lungimea pisicii este:");
            int LungimePisica = int.Parse(Console.ReadLine());

            if (LungimePisica <= 15) return true;
            else

            return false;
        }

        /// <summary>
        /// . Scrieți o funcție care citește de la tastatura un număr natural n și o matrice pătratică cu n
        /// linii și n coloane formată din numere naturale mai mari sau egale decât 2, după care 
        /// determină suma numerelor prime de sub diagonala secundară
        /// </summary>
        private static void Problema4()
        {
            static bool Prim(int nr)
            {
                if (nr % 2 == 0) return false;
                int max = (int)Math.Floor(Math.Sqrt(nr));

                for (int i = 3; i <= max; i += 2)

                    if (nr % i == 0)
                        return false;

                return true;
            }

            int n = int.Parse(Console.ReadLine());
            int s = 0;
            int[,] a = new int[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());

                    if (i + j > n + 1)
                    {
                        if (Prim(a[i, j]))
                        {
                            s = s + a[i, j];
                        }
                    }
                }

            Console.WriteLine($"Suma elementelor prime de sub diagonala principala este {s}");
        }
      
        /// <summary>
        /// Scrieți o funcție care citește de la tastatura o listă de numere până se introduce valoarea 
        /// zero. Funcția va determina și va afișa cele mai mari trei numere din listă. Valoarea zero care 
        /// termină lista nu se consideră că face parte din lista de numere care trebuie prelucrate. Lista
        /// conține cel puțin 3 numere. În rezolvarea acestei probleme nu veți folosi tablouri. 
        /// </summary>
        private static void Problema3()
        {
            int n = int.Parse(Console.ReadLine());
            int max1 = 0;
            int max2 = 0;
            int max3 = 0;
            int lista = 0;
            while(n != 0)
            {
                if(lista > 2)
                {
                    if(n > max1 && max1 <= max2 && max1 <= max3)
                    { 
                        max1 = n;
                    }
                    else if(n > max2 && max2 <= max1 && max2 <= max3)
                    {
                        max2 = n;
                    }
                    else if(n > max3 && max3<= max1 && max3 <= max2)
                    {
                        max3 = n;
                    }
                     n = int.Parse(Console.ReadLine());

                }
                lista++;
            }
            Console.WriteLine($"Cele mai mari 3 valori din lista sunt {max1} {max2} {max3}");

        }

        /// <summary>
        /// Scrieți o funcție care primește ca argument un vector de numere întregi și o valoare t.
        /// Funcția determină și afișează indicii a două elemente din vector a căror sumă este egală cu t. 
        /// Se poate presupune că pentru fiecare input problema are o singură soluție iar un element nu 
        /// poate fi folosit de două ori în sumă (cei doi indici sunt diferiți). Pentru punctaj maxim creați o
        /// soluție eficientă. 
        /// </summary>
        private static void Problema2()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea k");
            int t = int.Parse(Console.ReadLine());
            int len = v.Length;
            for (int i = 0; i < len; i++)
            {
                if (v[i] <= t)
                {
                    int diferenta = t - v[i];
                    for (int j = i + 1; j < len; j++)
                    {
                        if (v[j] == diferenta)
                        {
                            Console.WriteLine($"Cele doua pozitii sunt: {i} si {j}");
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Scrieți o funcție care primește ca argument un număr natural n și întoarce complementul
        /// față de 9 al numărului.Ex.n = 4690 -> 5309.
        /// </summary>
        private static void Problema1()
        {
            Console.WriteLine("Introduceti un numar natural:");
           int n = Convert.ToInt32(Console.ReadLine());
            int p = 1, c, nr = 0;
            while (n != 0)
            {
                c = n % 10;
                c = 9 - c;
                n = n / 10;
                nr = c * p + nr;
                p = p * 10;
            }
            Console.WriteLine($"Complementul fata de 9 al nuamrului este {nr}");
            Console.ReadKey();
        }
    }
}
