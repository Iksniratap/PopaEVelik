using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int needesCups = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());

            int hoursWork = workers * workDays * 8;
            int cupsProduction = hoursWork / 5;

            if (cupsProduction<needesCups)
            {
                Console.WriteLine("Losses: {0:f2}", (needesCups-cupsProduction)*4.2);
            }
            else if (cupsProduction>=needesCups)
            {
                Console.WriteLine("{0:f2} extra money", (cupsProduction-needesCups)*4.2);
            }
        }
    }
}
