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
            // The else statement is used to execute a block of code if the condition in the if statement is false. In this example, if the grade is less than 50, the else block will be executed, printing "Better Luck Next Time!" to the console.

            // if (condition)
            {
                // block of code to be executed if the condition is True
            }
            // else
            {
                // block of code to be executed if the prior condition is not True
            }

            int age;
            Console.WriteLine("What is your age?");
            int.TryParse(Console.ReadLine(), out age);

            if (age >= 16)
            {
                Console.WriteLine(" The roads are not safe!");
            }

            else
            {
                Console.WriteLine("I can drive without fear!");
            }



            int bet;
            Console.WriteLine("How much would you like to bet? ");
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
            else (grade1 > 85)
                Console.WriteLine("That is a A!");
            //By adding the else to the if statements, we grouped them all into the same logical block.
            // What did the ELSE at the end do?
            //It guaranteed that something happened in our if...else if block. A final else is optional.


            //TASK 1:- Multiple Choice Question

            string answer = Console.ReadLine();

            Console.WriteLine("Multiple Choice Question");
            Console.WriteLine("Which Planet is known as the Red Planet?");
            Console.WriteLine("A. Earth");
            Console.WriteLine("B. Mars");
            Console.WriteLine("C. Jupiter");
            Console.WriteLine("D. Venus");
            Console.WriteLine("Enter Your choice (A, B, C, or D):");
            answer = Console.ReadLine().ToUpper();

            // Convert input to uppercase so both lowercase and uppercase answers are accepted

            if (answer == "A")
            {
                Console.WriteLine("Incorrect! Earth is Known as the Blue Planet.");
            }

            else if (answer == "B")
            {
                Console.WriteLine("Correct! Mars is Known as the Red Planet.");
            }

            else if (answer == "C")
            {
                Console.WriteLine("Incorrect! Jupiter is Known as the Gas Giant.");
            }

            else if (answer == "D")
            {
                Console.WriteLine("Incorrect! Venus is Known as the Brightest Planet.");
            }

            else
            {
                Console.WriteLine("Invalid choice! Please enter A, B, C, or D.");
            }

            // Task 2:-The State Of War











        }
    }   
}
