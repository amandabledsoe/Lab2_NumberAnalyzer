using System;

namespace Lab2_NumberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runningProgram = true;
            bool runningAgain;
            string userName;
            string userInput;
            string userAnswer;
            bool isANumber;

            Console.WriteLine("Welcome to the Number Analyzer Application!");
            Console.WriteLine("");
            Console.WriteLine("With whom do we have the pleasure of working today?");
            Console.Write("Enter your name here: ");
            userName = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"Wonderful to meet you, {userName}! Let's dig in and begin analyzing your numbers.");
            Console.WriteLine("");

            while (runningProgram)
            {
                Console.WriteLine("Enter a whole number between 1 and 100.");
                userInput = Console.ReadLine();
                isANumber = int.TryParse(userInput, out int number);
                if (isANumber)
                {
                    if (number <= 100 && number >= 1)
                    {
                        if (number % 2 == 0 && number < 25)
                        {
                            Console.WriteLine("");
                            Console.WriteLine($"Your number, {number}, is even and less than 25.");
                            Console.WriteLine("");
                        }
                        else if (number % 2 == 0 && (number > 25 && number <= 60))
                        {
                            Console.WriteLine("");
                            Console.WriteLine($"Your number, {number}, is even and between 26 and 60 inclusive.");
                            Console.WriteLine("");
                        }
                        else if (number % 2 == 0 && number > 60)
                        {
                            Console.WriteLine("");
                            Console.WriteLine($"Your number, {number}, is even and greater than 60.");
                            Console.WriteLine("");
                        }
                        else if (number % 2 != 0 && number < 60)
                        {
                            Console.WriteLine("");
                            Console.WriteLine($"Your number, {number}, is odd and less than 60.");
                            Console.WriteLine("");
                        }
                        else if (number % 2 != 0 && number > 60)
                        {
                            Console.WriteLine("");
                            Console.WriteLine($"Your number, {number}, is odd and greater than 60.");
                            Console.WriteLine("");
                        }
                        runningAgain = true;
                        while (runningAgain)
                        {
                            Console.WriteLine($"Would you like to analyze another number {userName}?");
                            Console.Write("Enter 'Y' or 'yes' to analyze another number, or enter 'n' or 'no' to exit: ");
                            userAnswer = Console.ReadLine().ToLower();
                            if (userAnswer == "y" || userAnswer == "yes")
                            {
                                Console.WriteLine("");
                                runningAgain = false;
                                runningProgram = true;
                            }
                            else if (userAnswer == "n" || userAnswer == "no")
                            {
                                Console.WriteLine("");
                                runningAgain = false;
                                runningProgram = false;
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Sorry, I didn't understand that response.");
                                Console.WriteLine("");
                                runningAgain = true;
                            }
                        }
                    }
                    else if (number > 100 || number < 1)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Sorry, that number is out of range. Let's try again.");
                        Console.WriteLine("");
                        runningProgram = true;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, that doesnt appear to be a whole number. Please try again.");
                    Console.WriteLine("");
                    runningProgram = true;
                }
            }
            Console.WriteLine($"Thank you for using the Number Analyzer Application today, {userName}!");
            Console.WriteLine("Goodbye...");
        }
    }
}
