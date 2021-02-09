using System;

public abstract class Mob
{
    public int HP { get; private set; }
    protected int Attack { get; }

    protected Mob(int hp, int attack)
    {
        HP = hp;
        Attack = attack;
    }
    
    public void AttackMob(Mob other)
    {
        do
        {
            Console.WriteLine($"{other} attacked {this}");
            Console.WriteLine($"{this} attacked {other}");
            HP -= other.Attack;
            other.HP -= Attack;
        } while (other.HP > 0 && HP > 0);
    }
}