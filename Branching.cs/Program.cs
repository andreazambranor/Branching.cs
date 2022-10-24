using System;


namespace Branching.cs
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Welcome to Package Express, please follow the instructions below.");

            Console.WriteLine("What is the weight of your package in kg?");
            string weight = Console.ReadLine();
            int weightInt = Convert.ToInt32(weight);
            if (weightInt > 50)
            {
                Console.WriteLine("Your package is too heavy to be shipped via Package express, have a good day!");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Please type the following information: ");

                Console.WriteLine("Package width in centimeters: ");
                string width = Console.ReadLine();
                int widthInt = Convert.ToInt32(width);

                Console.WriteLine("Package Height in centimeters: ");
                string height = Console.ReadLine();
                int heightInt = Convert.ToInt32(height);

                Console.WriteLine("Package length in centimeters: ");
                string length = Console.ReadLine();
                int lengthInt = Convert.ToInt32(length);

                int total = lengthInt + heightInt + widthInt;                

                if (total > 50)
                {
                    Console.WriteLine("Your package is too big to be shipped via Package Express");
                    Console.ReadLine();
                }

                else
                {
                    int product = widthInt * heightInt * lengthInt;
                    int productB = product * weightInt;
                    int quotient = productB / 100;

                    Console.WriteLine("Your estimated total for shipping this package is: $" + quotient);
                    Console.ReadLine();
                }

            }



        }
    }
}
