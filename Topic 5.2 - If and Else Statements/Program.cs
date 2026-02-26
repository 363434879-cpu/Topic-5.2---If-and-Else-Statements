using System;

namespace Topic_5._2___If_and_Else_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grade;
            Console.WriteLine("What was your grade?");
            int.TryParse(Console.ReadLine(), out grade);

            if (grade >= 50)
                Console.WriteLine("You Passed!");
            else
                Console.WriteLine("Better Luck Next Time!");


            int age;
            Console.WriteLine("What is your age?");
            int.TryParse(Console.ReadLine(), out age);

            if (age >= 16)
            {
                Console.WriteLine("The roads are not safe!");
            }
            else
            {
                Console.WriteLine("I can drive without fear!");
            }


            int bet;
            Console.WriteLine("How much would you like to bet?");
            if (int.TryParse(Console.ReadLine(), out bet))
            {
                Console.WriteLine("You bet " + bet.ToString("C"));
            }
            else
            {
                Console.WriteLine("That is not a valid number.");
                Console.WriteLine("Your bet will be set to the minimum of $1.00.");
                bet = 1;
            }


            int grade1;
            Console.WriteLine("What was your grade?");
            int.TryParse(Console.ReadLine(), out grade1);

            if (grade1 < 50)
                Console.WriteLine("That is an F!");
            else if (grade1 <= 65)
                Console.WriteLine("That is a D!");
            else if (grade1 <= 75)
                Console.WriteLine("That is a C!");
            else if (grade1 <= 85)
                Console.WriteLine("That is a B!");
            else
                Console.WriteLine("That is an A!");


            // TASK 1 – Multiple Choice Question

            Console.WriteLine("\nMultiple Choice Question");
            Console.WriteLine("Which planet is known as the Red Planet?");
            Console.WriteLine("A. Earth");
            Console.WriteLine("B. Mars");
            Console.WriteLine("C. Jupiter");
            Console.WriteLine("D. Venus");
            Console.WriteLine("Enter your choice (A, B, C, or D):");

            string answer = Console.ReadLine().ToUpper();

            if (answer == "A")
                Console.WriteLine("Incorrect! Earth is known as the Blue Planet.");
            else if (answer == "B")
                Console.WriteLine("Correct! Mars is known as the Red Planet.");
            else if (answer == "C")
                Console.WriteLine("Incorrect! Jupiter is known as the Gas Giant.");
            else if (answer == "D")
                Console.WriteLine("Incorrect! Venus is known as the Brightest Planet.");
            else
                Console.WriteLine("Invalid choice! Please enter A, B, C, or D.");


            // TASK 2 – The State of Water

            Console.WriteLine("\nInput the temperature of water in Celsius:");
            int temp;
            int.TryParse(Console.ReadLine(), out temp);

            if (temp <= 0)
            {
                Console.WriteLine("The water is in a solid state (ice).");
            }
            else if (temp < 100)
            {
                Console.WriteLine("The water is in a liquid state.");
            }
            else if (temp >= 100)
            {
                Console.WriteLine("The water is in a gaseous state (steam).");
            }

            else
            {
                Console.WriteLine("Invalid temperature input.");
            }


          //Task 3- How Old Are You Revisited






        }
    }
}