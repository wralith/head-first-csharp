namespace CardPicker;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the number of cards to pick: ");
        var input = Console.ReadLine();

        if (int.TryParse(input, out var numberOfCards))
        {
            var cards = CardPicker.PickSomeCards(numberOfCards);
            foreach (var card in cards) Console.WriteLine(card);
        }
        else
        {
            Console.WriteLine("You should have enter a number...");
        }
    }
}