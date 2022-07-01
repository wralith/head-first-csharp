namespace HighLowGame;

internal static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the High and Low game.");
        Console.WriteLine($"Guess the number between 1 and {Game.Maximum}");
        Game.Hint();
        while (Game.GetPot() > 0)
        {
            Console.WriteLine("Press h for highter, 1 for lower, ? to buy a hint,\n" +
                              $"or any other key to quit with {Game.GetPot()}");
            var key = Console.ReadKey(true).KeyChar;
            if (key == 'h') Game.Guess(true);
            else if (key == 'l') Game.Guess(false);
            else if (key == '?') Game.Hint();
            else return;
        }

        Console.WriteLine("Game over, pot is empty!!");
    }
}