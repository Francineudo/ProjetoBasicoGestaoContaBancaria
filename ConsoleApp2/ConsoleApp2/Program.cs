using ConsoleApp2.entities;
using ConsoleApp2.entities.exptions;
using System.Globalization;


namespace ProcessFile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, balance, withdrawLimit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                account.Withdraw(amount);
                Console.WriteLine("new balance: " + account.Balance.ToString("f2"), CultureInfo.InvariantCulture);
            }
            catch (DomainExceptions e)
            {
                Console.WriteLine("withdraw error: " + e.Message);
            }

        }
    }
}
