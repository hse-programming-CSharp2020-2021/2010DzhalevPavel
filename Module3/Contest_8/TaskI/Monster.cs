using System;

public class Monster : Mob
{
    private int Position { get; set; }
    public Monster(int hp, int attack, int position) : base(hp, attack)
    {
        Position = position;
    }

    public void AttackHero(Mob hero, int position)
    {
        if (position == Position)
        {
            Console.WriteLine($"Mario meet monster on {position}");
            AttackMob(hero);
        }
    }

    public override string ToString()
    {
        return $"Monster with HP = {HP} and attack = {Attack}";
    }
}