using System;

namespace Exam_02_MaidenParty
{
    class Program
    {
        static void Main(string[] args)
        {
            // reading input data
            double partyPrice = double.Parse(Console.ReadLine());
            int loveMsgs = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int keyHolders = int.Parse(Console.ReadLine());
            int cartoons = int.Parse(Console.ReadLine());
            int luckySurprices = int.Parse(Console.ReadLine());

            // initializing price per good
            double loveMsgPrice = 0.60;
            double rosePrice = 7.20;
            double keyHolderPrice = 3.60;
            double cartoonPrice = 18.20;
            double luckySurpricePrice = 22.00;

            //processing data
            int totalOrders = loveMsgs + roses + keyHolders + cartoons + luckySurprices;
            double totalIncome = loveMsgs * loveMsgPrice + roses * rosePrice + keyHolders * keyHolderPrice + cartoons * cartoonPrice + luckySurprices * luckySurpricePrice;
           
            //check for discount
            if (totalOrders >= 25)
            {
                totalIncome *= 0.65;
            }

            //total amount after pay for hosting
            totalIncome *= 0.9;

            //generating output
            if (totalIncome >= partyPrice)
            {
                Console.WriteLine("Yes! {0:F2} lv left.",totalIncome - partyPrice);
            }
            else
            {
                Console.WriteLine("Not enough money! {0:F2} lv needed.",(partyPrice-totalIncome));
            }
        }
    }
}
