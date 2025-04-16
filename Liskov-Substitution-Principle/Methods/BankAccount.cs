namespace Liskov_Substitution_Principle.Methods
{
    public abstract class BankAccount
    {
        protected double _balance;
        public virtual void Deposit(double amount)
        {
            _balance += amount;
            Console.WriteLine($"Deposit: {amount}, Total Amount: {_balance}");
        }

        public abstract void Withdraw(double amount);
        public double GetBalance()
        {
            return _balance;
        }
    }
    public class RegularAccount : BankAccount
    {
        public override void Withdraw(double amount)
        {
            if (_balance >= amount)
            {
                _balance -= amount;
                Console.WriteLine($"Withdraw: {amount}, Balance: {_balance}");
            }
            else
            {
                Console.WriteLine($"Trying to Withdraw: {amount}, Insufficient Funds, Available Funds: {_balance}");
            }
        }
    }
    public class FixDipositAccount:BankAccount
    {
        private bool termEnd = false;
        public override void Withdraw(double amount)
        {
            if (!termEnd)
            {
                Console.WriteLine("Cannot withdraw from a fixed term deposit account until term ends");
            }
            else if (_balance >= amount)
            {
                _balance -= amount;
                Console.WriteLine($"Withdraw: {amount}, Balance: {_balance}");
            }
            else
            {
                Console.WriteLine($"Trying to Withdraw: {amount}, Insufficient Funds, Available Funds: {_balance}");
            }
        }
    }
}
