namespace CardPicker;

internal class CardPicker
{
    public static string[] PickSomeCards(int numberOfCards)
    {
        var pickedCards = new string[numberOfCards];
        for (var i = 0; i < numberOfCards; i++) pickedCards[i] = RandomValue() + " of " + RandomSuit();

        return pickedCards;
    }

    private static string RandomValue()
    {
        var random = new Random().Next(1, 14);

        return random switch
        {
            1 => "Ace",
            11 => "Jack",
            12 => "Queen",
            13 => "King",
            _ => random.ToString()
        };
    }

    private static string RandomSuit()
    {
        var random = new Random().Next(0, 3);

        return random switch
        {
            0 => "Spades",
            1 => "Hearts",
            2 => "Diamonds",
            _ => "Clubs"
        };
    }
}