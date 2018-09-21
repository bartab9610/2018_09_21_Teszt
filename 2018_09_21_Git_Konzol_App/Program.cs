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
            int db;
            if (!int.TryParse(Console.ReadLine(), out db))
            {
                Console.WriteLine("Nem szám!");
                Console.ReadKey();
                return;
            }
            int[] szamok_tomb = new int[db];
            Console.WriteLine();
            Console.WriteLine("Adjon még {0} darab számot: ", db);
            int max;
            for (int i = 0; i < szamok_tomb.Length; i++)
            {
                Console.Write("Adja meg a(z) {0} számot: ", i + 1);
                if (!int.TryParse(Console.ReadLine(), out szamok_tomb[i]))
                {
                    Console.WriteLine("Nem szám!");
                    Console.ReadKey();
                    return;
                }
            }
            max = szamok_tomb[0];
            for (int i = 0; i < szamok_tomb.Length; i++)
            {
                if (szamok_tomb[i] > max)
                {
                    max = szamok_tomb[i];
                }
            }
            Console.WriteLine("A bekért számok legnagyobb eleme: {0}", max);
            int min;
            min = szamok_tomb[0];
            for (int i = 0; i < szamok_tomb.Length; i++)
            {
                if (szamok_tomb[i] < min)
                {
                    min = szamok_tomb[i];
                }
            }
            Console.WriteLine("A bekért számok legkisebb eleme: {0}", min);
            Console.ReadKey();

        }
    }
}