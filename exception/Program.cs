using exception.Entites;
using exception.Entites.Exception;
using System;
using System.Globalization;

namespace TratamentoDeExceções
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Inicial Balance: ");
                double Ibalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("with draw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, Ibalance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(amount);

                Console.WriteLine(account);
            }
            catch(DominionException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}