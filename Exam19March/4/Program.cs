using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int lections = int.Parse(Console.ReadLine());
            double moneyForLectors = double.Parse(Console.ReadLine());
           

            double lectionsJelev = 0;
            double lectionsRoyal = 0;
            double lectionsRoli = 0;
            double lectionsTrofon = 0;
            double lectionsSino = 0;
            double othersLections = 0;
            double salaryJelev = 0;
            double salaryRoyal = 0;
            double salaryRoli = 0;
            double salaryTrofon = 0;
            double salarySino = 0;
            double othersSalary = 0;

            double moneyForOneLection = moneyForLectors / lections;

            for (int i = 0; i < lections; i++)
            {
               var nameLector = Console.ReadLine();
                if (nameLector == "Jelev")
                {
                    lectionsJelev++;
                    salaryJelev = lectionsJelev * moneyForOneLection;

                }
                else if (nameLector == "RoYaL")
                {
                    lectionsRoyal++;
                    salaryRoyal = lectionsRoyal * moneyForOneLection;

                }
                else if (nameLector == "Roli")
                {
                    lectionsRoli++;
                    salaryRoli = lectionsRoli * moneyForOneLection;
                }
                else if (nameLector == "Trofon")
                {
                    lectionsTrofon++;
                    salaryTrofon = lectionsTrofon * moneyForOneLection;
                }
                else if (nameLector == "Sino")
                {
                    lectionsSino++;
                    salarySino = lectionsSino * moneyForOneLection;
                }
                else
                {
                    othersLections++;
                    othersSalary = othersLections * moneyForOneLection;                     
                }
            }
            Console.WriteLine("Jelev salary: {0:f2} lv", salaryJelev);
            Console.WriteLine("RoYaL salary: {0:f2} lv", salaryRoyal);
            Console.WriteLine("Roli salary: {0:f2} lv", salaryRoli);
            Console.WriteLine("Trofon salary: {0:f2} lv", salaryTrofon);
            Console.WriteLine("Sino salary: {0:f2} lv", salarySino);
            Console.WriteLine("Others salary: {0:f2} lv", othersSalary);

        }
    }
}
