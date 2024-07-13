using ExFixacaoExcecoes.Entities.Exceptions;

namespace ExFixacaoExcecoes.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            if (withdrawLimit <= 0)
            {
                throw new DomainException("Withdraw limit error: Must be greater then zero!");
            }

            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance <= 0)
            {
                throw new DomainException("Withdraw error: Not enough balance");
            }

            if (amount > WithdrawLimit)
            {
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit");
            }

            Balance -= amount;
        }
    }
}