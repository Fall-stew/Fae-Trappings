using System;

class Character
{
    // Fields to store character information
    public string Name;
    public string Class;
    public int Health;

    // Constructor to set up a new character with a name, class, and health
    public Character(string name, string characterClass)
    {
        Name = name;
        Class = characterClass;
        Health = 10;  // Start all characters with 10 health
    }

    // Method for the character to attack
    public void Attack(Monster monster)
    {
        Console.WriteLine(Name + " attacks with somewhat mighty force! The monster is not amused.");
        monster.Health -= 1; // Health decreases after attack
    }

    // Method for the character to cast a spell (only if they are a Wizard) aka use of a list
    public void CastSpell(Monster monster)
  {
        if (Class == "Wizard")
        {
            string[] spellMessages = {
                "casts a magical spell! Ramen is spilled everywhere!",
                "casts a fireball! The air smells like burnt noodles.",
                "casts a lightning bolt! This monster will be well done. Most people would consider that monstrous.",
                "casts a confusion spell! It stares at you blankly",
                "casts a dancing spell! The monsters defenses are down."
            };

            Random random = new Random();
            int index = random.Next(spellMessages.Length);
            Console.WriteLine(Name + " " + spellMessages[index]);

            monster.Health -= 2; // Health decreases after spell
        }
        else
        {
            Console.WriteLine(Name + " cannot cast a spell because they are not a super cool wizard.");
        }
    }

    // Method to display the current health of the character
    public void DisplayHealth()
    {
        Console.WriteLine(Name + "'s health: " + Health);
    }
       // Method to display story pieces based on health
    public void DisplayStoryBasedOnHealth()
    {
        if (Health > 8)
        {
            Console.WriteLine(Name + " wonders if their life is worth more than a bowl of ramen.");
        }
        else if (Health > 5)
        {
            Console.WriteLine(Name + " needs to know if this was the best choice.");
        }
        else if (Health > 3)
        {
            Console.WriteLine(Name + " reconsiders their life choices and wishes they had eaten the ramen the monster gifted them.");
        }
    }
}