namespace CharacterCreation;

public class AbilityScoreCalculator
{
    public int RollResult = 14;
    public double DivideBy = 1.75;
    public int AddAmount = 2;
    public int Minimum = 3;
    public int Score;

    public void CalculateAbilityScore()
    {
        // RollResult = Random.Shared.Next(4, 25);
        // Divide result to DivideBy field
        double divided = RollResult / DivideBy;
        // Add AddAmount to current result
        int added = AddAmount + (int)divided;

        Score = added < Minimum ? Minimum : added;
    }
}