using System;

namespace EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int customers = int.Parse(Console.ReadLine());
            double basketPrice = 1.5;
            double wreastPrice = 3.8;
            double bunnyPrice = 7.0;
            double totalPrice = 0;
            int itemCounter = 0;
            for (int i = 1; i <= customers; i++)
            {
                double currentCustomerBill = 0;
                while (true)
                {
                    string goodType = Console.ReadLine();
                    if (goodType == "Finish")
                    {
                        if (itemCounter %2==0)
                        {
                            currentCustomerBill *= 0.8;
                        }
                        Console.WriteLine("You purchased {0} items for {1:F2} leva.", itemCounter, currentCustomerBill);
                        totalPrice += currentCustomerBill;
                        itemCounter = 0;
                        break;
                    }
                    switch (goodType)
                    {
                        case "basket":
                            currentCustomerBill += basketPrice;
                            itemCounter++;
                            break;
                        case "wreath":
                            currentCustomerBill += wreastPrice;
                            itemCounter++;
                            break;
                        case "chocolate bunny":
                            currentCustomerBill += bunnyPrice;
                            itemCounter++;
                            break;
                        default:
                            break;
                    }
                }
            }
            Console.WriteLine("Average bill per client is: {0:F2} leva.",(double)totalPrice*1.0/customers);
        }
    }
}
