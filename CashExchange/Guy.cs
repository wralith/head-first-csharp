namespace CashExchange;

public class Guy
{
    public string Name;
    public int Cash;

    public void WriteMyInfo()
    {
        Console.WriteLine(Name + " has " + Cash + " bucks.");
    }

    public int GiveCash(int amount)
    {
        if (Cash < amount)
        {
            Console.WriteLine("I don't have enough money!");
            return 0;
        }

        if (amount <= 0)
        {
            Console.WriteLine("Hmmm, not a valid amount...");
            return 0;
        }

        Cash -= amount;
        return Cash;
    }

    public void ReceiveCash(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Hmmm, not a valid amount...");
            return;
        }

        Cash += amount;
    }
}