using Liskov_Substitution_Principle.Methods;

class Program
{
    static void Main(string[] args)
    {
    LOOP:
        Console.WriteLine(@"1. Creating Different Shapes with Liskov Substitution Principle
2. Bank Account Demo with Liskov Substitution Principle");
        Console.Write("\nEnter the choices: ");
        int.TryParse(Console.ReadLine(), out int choice);
        Console.WriteLine("");

        switch (choice)
        {
            case 1:
                var rect = new Rectangle { Width = 5, Height = 9 };
                double area;
                area = rect.GetArea();
                Console.WriteLine(area);

                area = rect.ChangeDimensions(rect, 10, 20);
                Console.WriteLine(area);

                var square = new Square { Side = 5 };
                area = square.GetArea();

                Console.WriteLine(area);
                break;
            case 2:
                Console.WriteLine("RegularAccount:");
                var regular = new RegularAccount();
                regular.Deposit(1000);
                regular.Withdraw(500);
                regular.Withdraw(600);
                regular.Deposit(2000);
                regular.Deposit(1000);

                Console.WriteLine("\nFixedDepositAccount:");
                var fixDeposit = new FixDipositAccount();
                fixDeposit.Deposit(1000);
                fixDeposit.Withdraw(500);
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