using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj słowo: ");
            string slowo = Console.ReadLine();
            Console.WriteLine("Podaj ilość powtórzeń: ");
            int ilosc = Convert.ToInt32(Console.ReadLine());
            Slowka(slowo, ilosc);
            Console.ReadKey();
        }
        public static void Slowka(string word, int times)
        {
            for(int i = 0; i < times; i++)
            {
                Console.Write(word);
            }
        }
    }
}
