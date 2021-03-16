using System;
using System.Net;

public delegate void AtackHeroOnPosition(Mob hero, int position);
public class Game
{
    private int CastlePostion { get; set; }
    private int CountOfMonsters { get; set; }

    private readonly Hero _hero;
    private readonly Boss _boss;
    
    public AtackHeroOnPosition attackHero;
    
    public Game(int castlePosition, int countOfMonster, Hero hero, Boss boss)
    {
        CastlePostion = castlePosition;
        CountOfMonsters = countOfMonster;
        _hero = hero;
        _boss = boss;
    }
    public void Play()
    {
        for (int i = 0; i < CastlePostion; i++)
        {
            attackHero?.Invoke(_hero, i);
            if (_hero.HP <= 0)
            {
                Console.WriteLine("You Lose! Game over!");
                return;
            }
        }

        _boss.AttackMob(_hero);
        
        if (_hero.HP <= 0)
        {
            Console.WriteLine("You Lose! Game over!");
            return;
        }

        Console.WriteLine(_hero.IsHpMoreThen75()
            ? "You win! Princess released!"
            : "Thank you, Mario! But our princess is in another castle... You lose!");
    }
}
