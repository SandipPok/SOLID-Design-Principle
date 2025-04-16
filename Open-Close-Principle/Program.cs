using Open_Close_Principle.Methods.E_Commerce;
using Open_Close_Principle.Methods.Notification_System;

class Program
{
    static void Main(string[] args)
    {
    LOOP:
        Console.WriteLine(@"1. E-commerce System with Open Closed Principle
2. Notification System Demo with Open Closed Principle");
        Console.Write("\nEnter the choices: ");
        int.TryParse(Console.ReadLine(), out int choice);
        Console.WriteLine("");

        switch (choice)
        {
            case 1:
                var discount = new RegularDiscount();
                var calc = new DiscountCalculator(discount);

                double discountPrice = calc.CalculateFinalDiscount(100);

                Console.WriteLine("Normal Discount : {0}", discountPrice);

                var premiumDiscount = new PremiumDiscount();
                calc = new DiscountCalculator(premiumDiscount);
                discountPrice = calc.CalculateFinalDiscount(100);

                Console.WriteLine("Premium Discount : {0}", discountPrice);

                break;
            case 2:
                var emailNotification = new EmailNotification();
                var sender = new NotificationSender(emailNotification);
                sender.SendNotification("Hello, this is a test email notification!");

                var smsNotification = new SMSNotification();
                sender = new NotificationSender(smsNotification);
                sender.SendNotification("Hello, this is a test SMS notification!");
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