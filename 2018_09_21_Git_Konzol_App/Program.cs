using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_09_21_Git_Konzol_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg a tömb elemeinek számát: ");
            int db = Convert.ToInt32(Console.ReadLine()); 
            int[] szamok_tomb = new int[db];
            Console.WriteLine();
            Console.WriteLine("Adjon még {0} darab számot: ",db);
            int max;
            for (int i = 0; i < szamok_tomb.Length; i++)
            {
                Console.Write("Adja meg a(z) {0} számot: ", i+1);
                szamok_tomb[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = szamok_tomb[0];
            for (int i = 0; i < szamok_tomb.Length; i++)
            {
                if (szamok_tomb[i] > max)
                {
                    max = szamok_tomb[i];
                }
            }
            Console.WriteLine("A bekért számok legnagyobb eleme: {0}",max);
            Console.ReadKey();
        }
    }
}