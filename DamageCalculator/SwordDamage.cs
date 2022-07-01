using System.Diagnostics;

namespace DamageCalculator;

public class SwordDamage
{
    private const int BaseDamage = 3;
    private const int FlameDamage = 2;

    /// <summary>
    /// Contains a calculated damage.
    /// </summary>
    public int Damage { get; private set; }

    private int roll;

    /// <summary>
    /// Sets or gets the 3d6 roll.
    /// </summary>
    public int Roll
    {
        get => roll;
        set
        {
            roll = value;
            CalculateDamage();
        }
    }

    private bool magic;

    /// <summary>
    /// True if the sword is magic, else false.
    /// </summary>
    public bool Magic
    {
        get => magic;
        set
        {
            magic = value;
            CalculateDamage();
        }
    }

    private bool flaming;

    /// <summary>
    /// True if the sword is flaming, else false.
    /// </summary>
    public bool Flaming
    {
        get => flaming;
        set
        {
            flaming = value;
            CalculateDamage();
        }
    }

    /// <summary>
    /// Calculates the damage based on current properties
    /// </summary>
    public void CalculateDamage()
    {
        var magicMultiplier = 1M;
        if (Magic) magicMultiplier = 1.75M;

        Damage = BaseDamage;
        Damage = (int)(Roll * magicMultiplier) + BaseDamage;
        if (Flaming) Damage += FlameDamage;
    }

    /// <summary>
    /// The constructor calculates damage based on default Magic
    /// and flaming values and a starting 3d6 roll.
    /// </summary>
    /// <param name="startingRoll">Starting 3d6 roll.</param>
    public SwordDamage(int startingRoll)
    {
        roll = startingRoll;
        CalculateDamage();
    }
}