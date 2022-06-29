// See https://aka.ms/new-console-template for more information

namespace CharacterCreation;

class Program
{
    static void Main(string[] args)
    {
        AbilityScoreCalculator calculator = new AbilityScoreCalculator();

        while (true)
        {
            calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
            calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divided by");
            calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
            calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");

            calculator.CalculateAbilityScore();
            Console.WriteLine("Calculated ability score: " + calculator.Score);

            Console.WriteLine("Press Q to quit, any other key to continue");
            var keyChar = Console.ReadKey(true).KeyChar;
            if (keyChar is 'Q' or 'q') return;
        }
    }

    /// <summary>
    /// Writes a prompt and reads an int value from the console.
    /// </summary>
    /// <param name="lastUsedValue">The default value</param>
    /// <param name="prompt">Prompt to print to the console</param>
    /// <returns>The int value read, or the default value if unable to parse</returns>
    static int ReadInt(int lastUsedValue, string? prompt)
    {
        Console.WriteLine(prompt + " [" + lastUsedValue + "]: ");
        
        var userInput = Console.ReadLine();
        if (int.TryParse(userInput, out var output))
        {
            Console.WriteLine("    Using value " + output);
            return output;
        }

        Console.WriteLine("    Using default value " + lastUsedValue);
        return lastUsedValue;
    }

    static double ReadDouble(double lastUsedValue, string? prompt)
    {
        Console.WriteLine(prompt + " [ " + lastUsedValue + " ]: ");
        
        var userInput = Console.ReadLine();
        if (double.TryParse(userInput, out var output))
        {
            Console.WriteLine("    Using value " + output);
            return output;
        }

        Console.WriteLine("    Using default value " + lastUsedValue);
        return lastUsedValue;
    }
}