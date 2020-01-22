using System;

namespace Lab_3___Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! What is your name? ");
            string name = Console.ReadLine();

            string userContinue = "y";

            while (userContinue == "y")
            {

                Console.WriteLine("Pick a positive number between 1 and 100. Enter number: ");
                int num = int.Parse(Console.ReadLine());

                if ((num >= 0) && (num <= 100))
                {
                    Console.WriteLine($"Awesome {name}, thanks for picking a positive number ");

                    if (num % 2 != 0)
                    {
                        Console.WriteLine($"{name}, you have picked an odd number");
                    }
                    else if ((num % 2 == 0) && (num >= 2) && (num <= 25))
                    {
                        Console.WriteLine($"{name}, you have picked an even number that is less than or equal to 25");
                    }
                    else if ((num % 2 == 0) && (num >= 26) && (num <= 60))
                    {
                        Console.WriteLine($"{name}, you have picked an even number that is less than or equal to 60");
                    }
                    else if ((num % 2 == 0) && (num >= 60))
                    {
                        Console.WriteLine($"{name}, you have picked an even number that is great to or equal to 60");
                    }
                    else if ((num % 2 != 0) && (num <= 60))
                    {
                        Console.WriteLine($"{name}, you have picked an odd number that is less than or equal to 60");
                    }
                }
                else
                {
                    Console.WriteLine($"{name}, you have entered something invalid \nPlease enter another positive number: ");
                }
                userContinue = "";
                while ((userContinue != "y") && (userContinue != "n"))
                {
                    Console.WriteLine($"\n{name}, would you like to pick another positive number? Enter y/n: ");
                    userContinue = Console.ReadLine();
                }
            }
            Console.WriteLine($"Thank you {name} for playing, have a great day!");

        }
    }
}
