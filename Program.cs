// See https://aka.ms/new-console-template for more information
namespace BankEncapsulation
{
    class program
    {
        static void Main(string[] arg)
        {
            var account = new BankAccount();
           
            Console.WriteLine("How much would you like to deposit?");

#pragma warning disable CS8604 // Possible null reference argument.
            var amountToDeposit = double.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
            account.Deposit(amountToDeposit);
            Console.WriteLine($"Thank you!  your balance is now {account.GetBalance()}");
        }
    }
}
