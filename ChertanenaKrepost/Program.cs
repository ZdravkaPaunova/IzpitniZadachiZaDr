using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChertanenaKrepost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int colWidth = n / 2;
            int midWidth = 2 * n - 2 * colWidth - 4;

            string colSpaces = new string('^', colWidth);
            string midUnderscores = new string('_', midWidth);

            Console.WriteLine($"/{colSpaces}\\{midUnderscores}/{colSpaces}\\");

            for (int i = 0; i < n - 2; i++)
            {
                if (i == n - 3)
                {
                    string innerSpaces = new string(' ', colWidth + 1);
                    Console.WriteLine($"|{innerSpaces}{midUnderscores}{innerSpaces}|");
                }
                else
                {
                    string allSpaces = new string(' ', 2 * n - 2);
                    Console.WriteLine($"|{allSpaces}|");
                }
            }

            string colUnderscores = new string('_', colWidth);
            string midSpaces = new string(' ', midWidth);
            Console.WriteLine($"\\{colUnderscores}/{midSpaces}\\{colUnderscores}/");
        }
    }
}