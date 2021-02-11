using System;

public class Hero : Mob
{
    private readonly int _initialHp;
    public Hero(int hp, int attack) : base(hp,attack)
    {
        _initialHp = hp;
    }

    public bool IsHpMoreThen75()
    {
        if (HP >= 75*_initialHp/100) return true;
        return false;
    }

    public override string ToString()
    {
        return $"Mario with HP = {HP} and attack = {Attack}";
    } 
}

