using System;

namespace Exam_6_MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int input = int.Parse(Console.ReadLine());

            // colecting needed data for processing
            int a = input % 10;
            int b = input / 10 % 10;
            int c = input / 100;

            // processing data and representing output
            int production;
            for (int i = 1; i <= a; i++)
            {
                for (int k = 1; k <= b; k++)
                {
                    for (int j = 1; j <= c; j++)
                    {
                        production = i * k * j;
                        Console.WriteLine("{0} * {1} * {2} = {3};", i, k, j, production);
                    }
                }
            }

        }
    }
}
