using System;

namespace Dartz
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string shotType = "";
            int points = 0;
            int score = 301;
            bool isRetire = false;
            int succesfullShots = 0;
            int unsuccessfullShots = 0;
            int temporaryScore = 0;
            while (score > 0)
            {
                shotType = Console.ReadLine();
                if (shotType == "Retire")
                {
                    isRetire = true;
                    break;
                }
                points = int.Parse(Console.ReadLine());
                temporaryScore = score;
                switch (shotType)
                {
                    case "Single":
                        temporaryScore = score - points;
                        break;
                    case "Double":
                        temporaryScore = score - points * 2;
                        break;
                    case "Triple":
                        temporaryScore = score - points * 3;
                        break;
                    default:
                        break;
                }
                if (temporaryScore > 0)
                {
                    score = temporaryScore;
                    succesfullShots++;
                }
                else if (temporaryScore < 0)
                {
                    unsuccessfullShots++;
                }
                else
                {
                    succesfullShots++;
                    break;
                }
            }
            if (isRetire == true)
            {
                Console.WriteLine("{0} retired after {1} unsuccessful shots.", name, unsuccessfullShots);
            }
            else
            {
                Console.WriteLine("{0} won the leg with {1} shots.", name, succesfullShots);
            }
        }
    }
}
