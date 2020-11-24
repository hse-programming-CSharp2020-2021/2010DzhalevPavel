using System;
using System.Globalization;
using System.IO;

public class Wizard : LegendaryHuman
{
    private string name;
    private int healthPoints;
    private int power;
    private string rank;

    public string Rank
    {
        get => rank;
        set
        {
            if(value!="Neophyte"||value!="Adept"||value!="Charmer"||value!="Sorcerer"||value!="Master"||value!="Archmage")
                throw new ArgumentException("Invalid wizard rank.");
            rank = value;
        }
    }

    public Wizard(string name, int healthPoints, int power, string rank) : base(name, healthPoints,
        power)
    {
        this.name = name;
        this.healthPoints = healthPoints;
        this.power = power;
        this.rank = rank;
        Name = name;
        HealthPoints = healthPoints;
    }

    public override void Attack(LegendaryHuman enemy)
    {
        int rankNumber;
        switch (rank)
        {
            case "Neophyte":
                rankNumber = 1;
                break;
            case "Adept":
                rankNumber = 2;
                break;
            case "Charmer":
                rankNumber = 3;
                break;
            case "Sorcerer":
                rankNumber = 4;
                break;
            case "Master":
                rankNumber = 5;
                break;
            case "Archmage":
                rankNumber = 6;
                break;
            default:
                rankNumber = 0;
                break;

        }
        int wizAttack = power * (int)Math.Pow(rankNumber, 1.5) + HealthPoints / 10;

        if (enemy.GetType().FullName == "Wizard")
        {
            if (enemy.HealthPoints <= 0 || HealthPoints <= 0)
            {
            }
            else
            {
                Console.WriteLine($"{rank} Wizard {Name} with HP {HealthPoints} attacked " +
                                  $"{((Wizard)enemy).Rank} Wizard {enemy.Name} with HP {enemy.HealthPoints}.");
                enemy.HealthPoints-= wizAttack;
                if(enemy.HealthPoints<=0)
                    Console.WriteLine($"{((Wizard)enemy).Rank} Wizard {enemy.Name} with HP {enemy.HealthPoints} is dead.");
            }
            
        }
        else
        {
            if (enemy.HealthPoints <= 0 || HealthPoints <= 0)
            {
            }
            else
            {
                Console.WriteLine($"{rank} Wizard {Name} with HP {HealthPoints} attacked " +
                                  $"Knight {enemy.Name} with HP {enemy.HealthPoints}.");
                enemy.HealthPoints -= wizAttack;
                if(enemy.HealthPoints<=0)
                    Console.WriteLine($"Knight {enemy.Name} with HP {enemy.HealthPoints} is dead.");
            }
            
        }
        
    }
}