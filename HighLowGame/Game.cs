namespace HighLowGame;

public static class Game
{
    public const int Maximum = 10;
    private static Random random = new Random();
    private static int _currentNumber = random.Next(1, Maximum + 1);
    private static int _pot = 10;

    public static int GetPot()
    {
        return _pot;
    }

    public static void Hint()
    {
        const int half = Maximum / 2;
        if (_currentNumber >= half)
            Console.WriteLine($"The number is at least {half}");
        else Console.WriteLine($"The number is at most {half}");
        _pot--;
    }

    public static void Guess(bool higher)
    {
        var nextNumber = random.Next(1, Maximum + 1);
        if ((higher && nextNumber >= _currentNumber) || (!higher && nextNumber <= _currentNumber))
        {
            Console.WriteLine("You guessed right!");
            _pot++;
        }
        else
        {
            Console.WriteLine("Your guess is wrong.");
            _pot--;
        }

        _currentNumber = nextNumber;
        Console.WriteLine($"Current number is {_currentNumber}");
    }
}