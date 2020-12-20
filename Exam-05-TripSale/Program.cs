using System;

namespace Exam_05_TripSale
{
    class Program
    {
        static void Main(string[] args)
        {
            int seaVacation = int.Parse(Console.ReadLine());
            int mountainVacation = int.Parse(Console.ReadLine());
            string orderInput = "";
            int profit = 0;
            while (true)
            {
                orderInput = Console.ReadLine();
                if (orderInput == "Stop")
                {
                    break;
                }
                else if (orderInput == "sea" && seaVacation >=1)
                {                
                    profit += 680;
                    seaVacation--;
                }
                else if (orderInput == "mountain" && mountainVacation >=1)
                {
                    profit += 499;
                    mountainVacation--;
                }
                if (mountainVacation == 0 && seaVacation == 0)
                {
                    break;
                }
            }
            if (seaVacation == 0 && mountainVacation == 0)
            {
                Console.WriteLine("Good job! Everything is sold.");
                Console.WriteLine("Profit: {0} leva.", profit);
            }
            else
            {
                Console.WriteLine("Profit: {0} leva.", profit);
            }
        }
    }
}
