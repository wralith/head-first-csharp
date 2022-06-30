namespace RandomMenu;

public class MenuItem
{
    // Randomizer is static thus only one instance of it created
    // And shared among all the MenuItem class instances
    // Single instance of a random class is essential to avoid the same sequence of numbers
    public static Random Randomizer = new Random();

    public string[] Proteins = { "Roast Beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu" };

    public string[] Condiments =
        { "yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing" };

    public string[] Breads = { "rye", "white", "wheat", "pumpernickel", "a roll" };
    public string Description = "";
    public string Price;

    public void Generate()
    {
        string randomProtein = Proteins[Randomizer.Next(Proteins.Length)];
        string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
        string randomBread = Breads[Randomizer.Next(Breads.Length)];
        Description = $"{randomProtein} with {randomCondiment} on {randomBread}";

        decimal bucks = Randomizer.Next(2, 5);
        decimal cents = Randomizer.Next(1, 98);
        decimal price = bucks + (cents * .01M);
        Price = price.ToString("c");
    }
}

