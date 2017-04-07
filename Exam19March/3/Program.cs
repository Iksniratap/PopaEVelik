using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            double bank = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double moneyeNeeded = 0;
            string destination = "";
            string placeForSleep = "";
            if (bank <= 1000 && season == "Summer")
            {
                placeForSleep = "Camp";
                destination = "Alaska";
                moneyeNeeded = bank * 0.65;
                


            }
            else if (bank <= 1000 && season == "Winter")
            {
                destination = "Morocco";
                placeForSleep = "Camp";
                moneyeNeeded = bank * 0.45;

            }


            else if (bank > 1000 && bank <= 3000 && season == "Summer")
            {

                destination = "Alaska";
                placeForSleep = "Hut";
                moneyeNeeded = bank * 0.8;

            }
            else if (bank > 1000 && bank <= 3000 && season == "Winter")
            {
                destination = "Morocco";
                moneyeNeeded = bank * 0.6;
                placeForSleep = "Hut";


            }
            else if (bank > 3000 && season == "Summer")
            {
                placeForSleep = "Hotel";
                destination = "Alaska";
                moneyeNeeded = bank * 0.9;

            }
            else if (bank > 3000 && season == "Winter")
            {
                placeForSleep = "Hotel";
                destination = "Morocco";
                moneyeNeeded = bank * 0.9;

            }
            Console.WriteLine("{0} - {1} - {2:f2}", destination, placeForSleep, moneyeNeeded);

        }

    }

}

