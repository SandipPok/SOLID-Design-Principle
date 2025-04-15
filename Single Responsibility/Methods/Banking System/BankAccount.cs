public class BankAccount
{
    public int AccountNumber { get; private set; }
    public double Balance { get; private set; }
    public List<string> _transactions = new List<string>();

    public BankAccount(int accountNumber)
    {
        AccountNumber = accountNumber;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        _transactions.Add($"Deposited ${amount}. New Balance: ${Balance}");
    }

    public void Withdraw(double amount)
    {
        Balance -= amount;
        _transactions.Add($"Withdrew ${amount}. New Balance: ${Balance}");
    }
}
