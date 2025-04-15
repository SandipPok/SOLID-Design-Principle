using SingleResponsibilityDemo.Methods.Education_System;

public class Program
{
    public static void Main()
    {
    LOOP:
        Console.WriteLine(@"1. Bank Account Demo with Single Responsibility Principle
2. Education System Demo with Single Responsibility Principle");
        Console.Write("\nEnter the choices: ");
        int.TryParse(Console.ReadLine(), out int choice);
        Console.WriteLine("");

        switch (choice)
        {
            case 1:
                BankAccount acc = new BankAccount(123456);
                acc.Deposit(1000);
                acc.Withdraw(500);

                StatementPrinter printer = new StatementPrinter();
                printer.Print(acc);
                break;
            case 2:
                Student stu = new Student { Name = "John Doe" };
                stu.EnrollCourse("Math");
                stu.EnrollCourse("Science");

                stu.AssignGrade("Math", 3.5);
                stu.AssignGrade("Science", 4.0);

                GPACalculator gpaCalc = new GPACalculator();
                TranscriptGenerator transcript = new TranscriptGenerator(gpaCalc);

                transcript.PrintTranscript(stu);
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }
        Console.Write("\nDo you want to run again? ");
        char.TryParse(Console.ReadLine(), out char c);

        if (c == 'y')
        {
            goto LOOP;
        }
    }
}