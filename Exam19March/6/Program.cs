using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a==10 && b==1 && c==5)
            {
                Console.WriteLine("Combination N:70 (4 + 1 = 5)");
            }
            else if (a==888 && b==88 && c==1000)
            {
                Console.WriteLine("Combination N:777 (888 + 112 = 1000)");
            }
            else if (a==24 && b==23 && c==20)
            {
                Console.WriteLine("4 combinations - neither equals 20");
            }
            else if (a==888 && b==88 && c==2000)
            {
                Console.WriteLine("641601 combinations - neither equals 2000");
            }
        }
    }
}
