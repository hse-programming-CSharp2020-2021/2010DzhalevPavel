using System;
using System.IO;

public class Knight : LegendaryHuman
{
    private string name;
    private string[] equipment;

    /*public int HealthPoints
    {
        get => healthPoints;
        set
        {
            if(value<50||value>300)
                throw new ArgumentException("Invalid health points value.");
            healthPoints = value;
        }
    }*/

    public string[] Equipment
    {
        get => equipment;
        set
        {
            if(value.Length==0)
                throw new ArgumentException("Not enough equipment." );
            equipment = value;
        }
    }

    /*public int Power
    {
        get => power;
        set
        {
            if(value<5||value>75)
                throw new ArgumentException("Invalid power value.");
            power = value;
        }
    }*/

    public Knight(string name, int healthPoints, int power, string[] equipment) : base(name, healthPoints, power)
    {
        this.name = name;
        HealthPoints = healthPoints;
        Equipment = equipment;
        Name = name;
        HealthPoints = healthPoints;
    }

    public override void Attack(LegendaryHuman enemy)
    {
        int knightAttack = Power + 10*equipment.Length;

        if (enemy.GetType().FullName == "Wizard")
        {
            if (enemy.HealthPoints <= 0 || HealthPoints <= 0)
            {
            }

            else
            {
                Console.WriteLine($"Knight {name} with HP {HealthPoints} attacked " +
                                  $"{((Wizard)enemy).Rank} Wizard {enemy.Name} with HP {enemy.HealthPoints}."); 
                enemy.HealthPoints = enemy.HealthPoints - knightAttack;
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
                Console.WriteLine($"Knight {name} with HP {HealthPoints} attacked " +
                                  $"Knight {enemy.Name} with HP {enemy.HealthPoints}.");
                if(enemy.HealthPoints<=0)
                    Console.WriteLine($"Knight {enemy.Name} with HP {enemy.HealthPoints} is dead.");
                enemy.HealthPoints = enemy.HealthPoints - knightAttack;
            }
            
            
        }
            
       
        
       
    }
}