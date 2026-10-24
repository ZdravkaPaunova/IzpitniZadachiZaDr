using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorZaTupiParoli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int sym1 = 1; sym1 <= n; sym1++)
            {
                for (int sym2 = 1; sym2 <= n; sym2++)
                {
                    for (char sym3 = 'a'; sym3 < 'a' + l; sym3++)
                    {
                        for (char sym4 = 'a'; sym4 < 'a' + l; sym4++)
                        {
                            for (int sym5 = 1; sym5 <= n; sym5++)
                            {
                                if (sym5 > sym1 && sym5 > sym2)
                                {
                                    Console.Write($"{sym1}{sym2}{sym3}{sym4}{sym5} ");
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
