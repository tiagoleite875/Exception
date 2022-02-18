using System.Globalization;
using exception.Entites.Exception;

namespace exception.Entites
{
    class Account
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
            if(amount > WithdrawLimit)
            {
                throw new DominionException("Withdraw error: the amount exceeds wuthdraw limits");
            }
            if(amount > Balance)
            {
                throw new DominionException("Withdraw error : Not enough balance.");
            }
            Balance -= amount;
        }
        public override string ToString()
        {
            return "New Balance: "
                + Balance.ToString("f2",CultureInfo.InvariantCulture);
        }
    }
}
