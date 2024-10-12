namespace ConsoleApp1.Exam
{
    // Encapsulation Example
    public class BankAccount
    {
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            Balance = amount;
        }

        public string Withdraw(decimal amount)
        {
            if (amount > Balance) {
                return "Insufficient funds.";
            }
            Balance -= amount;
            return "Something";
        }

        public void Transfer(BankAccount target, decimal amount)
        {
            if (this.Balance >= amount)
            {
                Withdraw(amount);
                target.Deposit(amount);
            }
        }
    }

}
