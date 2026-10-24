using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peperuda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int wingWidth = n - 2;
            int halfRows = n - 2;

            for (int i = 0; i < halfRows; i++)
            {
                char symbol = (i % 2 == 0) ? '*' : '-';
                string wing = new string(symbol, wingWidth);
                Console.WriteLine($"{wing}\\ /{wing}");
            }

            string bodySpaces = new string(' ', wingWidth + 1);
            Console.WriteLine($"{bodySpaces}@{bodySpaces}");

            for (int i = 0; i < halfRows; i++)
            {
                char symbol = (i % 2 == 0) ? '*' : '-';
                string wing = new string(symbol, wingWidth);
                Console.WriteLine($"{wing}/ \\{wing}");
            }
        }
    }
}
