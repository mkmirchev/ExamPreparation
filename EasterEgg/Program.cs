using System;

namespace EasterEgg
{
    class Program
    {
        static void Main(string[] args)
        {
            int allEggs = int.Parse(Console.ReadLine());
            int redEggs = 0;
            int blueEggs = 0;
            int greenEggs = 0;
            int orangeEggs = 0;
            for (int i = 1; i <= allEggs; i++)
            {
                string color = Console.ReadLine();
                switch (color)
                {
                    case "red":
                        redEggs++;
                        break;
                    case "blue":
                        blueEggs++;
                        break;
                    case "green":
                        greenEggs++;
                        break;
                    case "orange":
                        orangeEggs++;
                        break;
                    default:
                        break;
                }

            }
            int maxEggs = 0;
            string maxEggsColor = "";
            if (redEggs > maxEggs)
            {
                maxEggs = redEggs;
                maxEggsColor = "red";
            }
            if (orangeEggs > maxEggs)
            {
                maxEggs = orangeEggs;
                maxEggsColor = "orange";
            }
            if (blueEggs > maxEggs)
            {
                maxEggs = blueEggs;
                maxEggsColor = "blue";
            }
            if (greenEggs > maxEggs)
            {
                maxEggs = greenEggs;
                maxEggsColor = "green";
            }
            Console.WriteLine("Red eggs: {0}", redEggs);
            Console.WriteLine("Orange eggs: {0}", orangeEggs);
            Console.WriteLine("Blue eggs: {0}", blueEggs);
            Console.WriteLine("Green eggs: {0}", greenEggs);
            Console.WriteLine("Max eggs: {0} -> {1}",maxEggs,maxEggsColor);
        }
    }
}
