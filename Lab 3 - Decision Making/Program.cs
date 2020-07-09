using System;

namespace Lab_3___Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Decision Maker!\n");

            GetUserInput("Whats your name?");
            string name = Console.ReadLine();

            do
            {
                GetUserInput($"{name}, please enter a number from 1 - 100:");
                int userNum = int.Parse(Console.ReadLine());

                IsOddOrEven(userNum);
            } while (Continue());
        }
    

        static string GetUserInput(string userResponse)
        {
            //created a seperate method to get any input. 
            Console.WriteLine(userResponse);
            return userResponse;
        }

        static void IsOddOrEven(double userNumber)
        {

            while (userNumber >= 1 && userNumber <= 100)
            {
                if (userNumber % 2 != 0)
                {
                    Console.WriteLine("Odd");
                }
                else if (userNumber % 2 == 0)
                {
                    Console.WriteLine("Even");

                    if (userNumber > 1 && userNumber < 25)
                    {
                        Console.WriteLine($"{userNumber} is Even");
                    }
                }
                else
                {
                    Console.WriteLine("The number you entered is not valid");
                }
                break;
            }

        }
        static bool Continue()
        {
            GetUserInput("Would you like to enter another number? Please enter y/n: ");
            string anotherNum = Console.ReadLine().ToLower();

            if (anotherNum == "yes" || anotherNum == "y")
            {
                Console.WriteLine("Yay! \n");
                return true;
            }
            else if (anotherNum == "no" || anotherNum == "n")
            {
                Console.WriteLine("Thanks for your input, have a nice day!");
                return false;
            }
            else
            {
                Console.WriteLine("Error! Please answer with a either y/n: ");
                return Continue();
            }

        }
    }
    
}
