namespace CashExchange;

internal static class Program
{
    public static void Main(string[] args)
    {
        var joe = new Guy { Name = "Joe", Cash = 50 };
        var bob = new Guy { Name = "Bob", Cash = 100 };

        while (true)

        {
            Console.WriteLine("Enter an amount: ");
            var insertedAmount = Console.ReadLine();
            if (insertedAmount == "") return;
            if (int.TryParse(insertedAmount, out var amount))
            {
                Console.WriteLine("Who should give the cash: ");
                var whichGuy = Console.ReadLine();
                if (whichGuy == "Joe")
                {
                    var money = joe.GiveCash(amount);
                    bob.ReceiveCash(money);
                }

                else if (whichGuy == "Bob")
                {
                    var money = joe.GiveCash(amount);
                    bob.ReceiveCash(money);
                }
                else
                {
                    Console.WriteLine("Please enter 'Joe' or 'Bob'");
                }
            }
            else
            {
                Console.WriteLine("Please enter an amount (or a blank line to exit)");
            }
        }
    }
}