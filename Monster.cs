using System;
using System.Reflection;

class Monster
{
    public string Name;
    public int Health;

    public Monster(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void Attack(Character character)
    {
        Console.WriteLine(Name + " attacks " + character.Name + "!");
        character.Health -= 2; // Monster attack decreases character's health
    }

    public void DisplayHealth()
    {
        Console.WriteLine(Name + "'s health: " + Health);
    }
     // Method to display story pieces based on health
    public void DisplayStoryBasedOnHealth(Character character)
    {
        if (Health > 9)
        {
            Console.WriteLine(Name + " makes smoochy faces at " + character.Name + " and tries to be friends. They offer you a bowl of ramen.");
        }
        else if (Health > 7)
        {
            Console.WriteLine(Name + " winks at " + character.Name + " and offers another big bowl of ramen.");    
        }
        else if (Health > 5)
        {
            Console.WriteLine(Name + " asks if this is a date, and if so, why is " + character.Name + " trying to kill it?");
        }
        else if (Health > 3)
        {
            Console.WriteLine(Name + " wonders why " + character.Name + " is so mean. It just wanted to have a meal with " + character.Name + ". " + character.Name + " is a monster.");
        }
    
    }
}