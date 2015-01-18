using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travelerBob
{
    class travelerBob
    {
        static void Main()
        {
            string year = Console.ReadLine();
            int contractMonths = int.Parse(Console.ReadLine());
            int familyMonths = int.Parse(Console.ReadLine());
            int allMonths =  contractMonths + familyMonths;
            int normalMonths = 12 - allMonths;

            double contractTravels = contractMonths * 12;
            double familyTravels = familyMonths * 4;
            double normalTravels = 12 * normalMonths * (double)3/5;
            double allTravels = contractTravels + familyTravels + normalTravels;
            double LeapAddition = allTravels * 0.05;

            if (year == "normal")
            {
                Console.WriteLine((int)allTravels);
            }
            else
            {
                allTravels += LeapAddition;
                Console.WriteLine((int)allTravels);
            }
        }
    }
}
