public class StatementPrinter
{
    public void Print(BankAccount account)
    {
        Console.WriteLine($"Statement for Amount: {account.AccountNumber}");
        foreach (var transaction in account._transactions)
        {
            Console.WriteLine(transaction);
        }
    }
}
