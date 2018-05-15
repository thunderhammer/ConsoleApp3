using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i;
            double d;
            //bool b;
            DateTime dato;
            TimeSpan ts;
            string n = "";
            char c = 'f'; // A single character declaration. Unlike others, you use ' ' instead of " " to encapsulate the content


            double[] løn = { 2000, 4000, 500, 2500 };
            double sum = 0;
            for (int i = 0; i < løn.Length; i++)                
            {
                sum += løn[i];
            }
            string[,] skak = new string[8, 8];
            skak[0, 0] = "T";


            int[] a;
            int[] b;
            a = new int[40000];
            b = new int[3];
            a[1] = 5;
            
            if (a == b)
            Console.WriteLine("Ens");

            a = b;
            if (a == b)
                Console.WriteLine("ens");
            int[] x = { 5, 1, 4, 5, 8, 2 };
            int[] y = { 5, 1, 4, 5, 8, 2 };
            if (x == y)
            { Console.WriteLine("samme reference");
            }
            else
            {
                Console.WriteLine("Ikke samme reference");
            }
                if (x.Equals(y))
                    Console.WriteLine("Nu er vi ens");
            
      /*          static bool Sammenlign(int[] a, int[] b)
                {
                    if (a.Length != b.Length)
                        return false;
                bool ens = true;
                    for (int ii = 0; int < ii.Length; ii++)
                    {
                        if (a[if] != b[if]) {
                ens = false;
            }
                return ens;
            } 
                
                    } */
 
        }
    }
}
