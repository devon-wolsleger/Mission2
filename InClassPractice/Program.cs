using System;

// Mission 2 Assignment 
// Devon Wolsleger 

namespace InClassPractice
{

    class DiceRoller
    {
        static void Main()
        {
            //Variables to hold the information 
            var rolls = GetRollCount();
            var totals = new int[13];

            //For loop that simulates rolling two dice and counting the total times a specific number was rolled
            for (var i = 0; i < rolls; i++)
            {
                var dice1 = new Random().Next(1, 7);
                var dice2 = new Random().Next(1, 7);
                var total = dice1 + dice2;
                totals[total]++;
            }

            for (var i = 2; i <= 12; i++)
            {
                var percentage = (totals[i] / (double)rolls) * 100;
                Console.WriteLine($"{i}: {percentage:0.00}% {new string('*', (int)percentage)}");
            }
            Console.Write(Environment.NewLine + "Thank you for rolling with me! Hope you have a great day!" + Environment.NewLine);
        }

        static int GetRollCount()
        {
            Console.Write("Hello and welcome to my dice roll simulator!" + Environment.NewLine + "DICE ROLLING SIMULATION RESULTS"
                + Environment.NewLine + "Each '*' represents 1 % of the total number of rolls." + Environment.NewLine + Environment.NewLine + "Enter number of rolls: " + Environment.NewLine);
            var input = Console.ReadLine();
            return int.TryParse(input, out var rolls) ? rolls : 0;
        }
        
    }
}




