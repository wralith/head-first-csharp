namespace SwordDamage;

// Page 231
static class Program
{
    static Random random = new Random();

    public static void Main()
    {
        var damageCalculator = new SwordDamage{};
        while (true)
        {
            Console.WriteLine("0 for no magic/flame, 1 for magic, 2 for flaming, 3 for both, anything else to quit");
            damageCalculator.CalculateDamage();
            var pressedKey = Console.ReadLine();
            damageCalculator.Roll = random.Next(1, 24);
            switch (pressedKey)
            {
                case "0":
                    damageCalculator.SetMagic(false);
                    damageCalculator.SetFlaming(false);
                    break;
                case "1":
                    damageCalculator.SetMagic(true);
                    damageCalculator.SetFlaming(false);
                    break;
                case "2":
                    damageCalculator.SetMagic(false);
                    damageCalculator.SetFlaming(true);
                    break;
                case "3":
                    damageCalculator.SetFlaming(true);
                    damageCalculator.SetMagic(true);
                    break;
                default:
                    return;
            }


            Console.WriteLine($"Rolled {damageCalculator.Roll} for {damageCalculator.Damage} HP");
        }
    }
}