namespace SwordDamage;

public class SwordDamage
{
    private const int BaseDamage = 3;
    private const int FlameDamage = 2;

    public int Roll;
    private decimal MagicMultiplier = 1M;
    private int FlamingDamage = 0;
    public int Damage;

    public void CalculateDamage()
    {
        Damage = (int)(Roll * MagicMultiplier) + BaseDamage + FlamingDamage;
    }

    public void SetMagic(bool isMagic)
    {
        MagicMultiplier = isMagic ? 1.75M : 1M;
        CalculateDamage();
    }

    public void SetFlaming(bool isFlaming)
    {
        if (isFlaming) Damage += FlameDamage;
    }
}