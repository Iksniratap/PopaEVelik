using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam19March
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double lenghtSide = double.Parse(Console.ReadLine());
            double heightRoof = double.Parse(Console.ReadLine());

            double sideArea = height * lenghtSide;
            double windowArea = 1.5 * 1.5;
            double twoSidesArea = (sideArea * 2)-windowArea*2;
            double backSide = height * height;
            double backAndFrontSide = backSide * 2-2.4;
            double totalArea = twoSidesArea + backAndFrontSide;
            double greenColour = totalArea / 3.4;



            double twoRectangels = (height * lenghtSide)*2;
            double twoTriangles = 2 * ((height * heightRoof) / 2);
            double totalRoofSide = twoRectangels + twoTriangles;
            double redColour = totalRoofSide / 4.3;

            Console.WriteLine("{0:f2}", greenColour);
            Console.WriteLine("{0:f2}",redColour);

        }
    }
}
