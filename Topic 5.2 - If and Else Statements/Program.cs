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

           







        }
    }   
}
