using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Please pick a minimum value less than 5");
            string minAnswer = Console.ReadLine();
            int min = 0;

            Console.WriteLine($"Please pick a maximum value less than 25");
            string maxAnswer = Console.ReadLine();
            int max = 25;

            while (int.TryParse(minAnswer, out min) == false)
            {
                Console.WriteLine("Sorry, that is wrong. Try again.");
                Console.WriteLine("Enter your new minimum answer");
                minAnswer = Console.ReadLine();
            }

            Console.WriteLine("Good minimum!");


            while (int.TryParse(maxAnswer, out max) == false)
            {
                Console.WriteLine("Sorry, that is wrong. Try again.");
                Console.WriteLine("Enter your new maximum answer");
                maxAnswer = Console.ReadLine();
            }

            Console.WriteLine("Good maximum!");

            Random rand = new Random();
            int randomNum = rand.Next(min, max + 1);

            Console.WriteLine("Guess the random number");
            string answer = Console.ReadLine();
            int answerToNum = Convert.ToInt32(answer);

            while (answerToNum != randomNum)
            {
                Console.WriteLine("Sorry that is wrong. Try again");
                Console.WriteLine("Enter your new guess");
                answerToNum = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Congratulations! You got the random number correct!");
        }
    }
}
