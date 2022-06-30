namespace Elephants;

internal static class Program
{
    public static void Main(string[] args)
    {
        Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
        Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

        while (true)
        {
            var input = GetUserInput();
            switch (input)
            {
                case 1:
                    lloyd.WhoAmI();
                    break;
                case 2:
                    lucinda.WhoAmI();
                    break;
                case 3:
                    (lloyd, lucinda) = (lucinda, lloyd);
                    break;  
                case 5:
                    lucinda.SpeakTo(lloyd, "Hi, Lloyd");
                    break;
                default:
                    return;
            }
        }
    }

    private static int GetUserInput()
    {
        Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap, 5 for Lucinda to say 'Hi' to Lloyd");
        var input = Console.ReadLine();
        if (int.TryParse(input, out var intInput))
        {
            return intInput;
        }

        GetUserInput();
        return 0;
    }
}