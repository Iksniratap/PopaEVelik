using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int widght = int.Parse(Console.ReadLine());
            int spaces = 2 * widght - 4;
            int dots = 2;
            int stars = 1;
            int sideDots = widght - 1;
            int spaces2 = 0;
            int stars2 = 1;
            int monkeyA = widght*2 - 3;

            Console.WriteLine(new string('*', widght * 2 + 1));
            Console.WriteLine(".*{0} *.", new string(' ', spaces));
            for (int i = 0; i < widght - 2; i++)
            {
                Console.Write("{0}{1}{2}{1}{0}",
                    new string('.', dots),
                    new string('*', stars),
                    (new string('@', spaces - 1)));
                Console.WriteLine();
                dots++;
                spaces -= 2;

            }
            Console.WriteLine("{0}{1}{0}", (new string('.', widght)), (new string('*', 1)));
            for (int i = 0; i < widght-2; i++)
            {
                Console.WriteLine("{0}{1}{2}@{2}{1}{0}",
                    (new string('.', sideDots)),
                    new string('*', stars2),
                    new string(' ', spaces2));
                sideDots--;
                spaces2++;

            }
            Console.WriteLine(".*{0}*.", new string('@', monkeyA));
            Console.Write(new string ('*',widght*2+1));

        }
    }
}

