using System;

class Program
{
    static void Main()
    {
        //Global Variable
        bool hasPendent = false;


        // Welcome message
        Console.WriteLine("Welcome to the world of fae and folk research, please tell us your name?");
        string playerName = Console.ReadLine();
        Console.WriteLine("You, fair researcher, have been on the lookout for supernatural beings within the forest that surrounds you. You've found and studied unicorns, dragons, gnomes, and even the dangerous kelpies. \n Today is the day you try and find the infamous fae folk. The morning sun rises from the horizon, sunlight breaking through the trees and into your cabin. It drifts over the fabric of your coat, highlighting it\'s striking green hue. It\'s time to set forth, do you bring anything with you?");
        Console.WriteLine("Do you: \n 1. Read your research. \n 2. Bring protection charm. \n 3. Bring nothing, you won't be gone long.");

        // First option before setting out
        string directionChoice = Console.ReadLine();
        if (directionChoice.Equals("1"))
        {
            Console.WriteLine("The leather of your notebook is worn. Having spent days and nights researching your findings has caused some weathering to your pages.\r\n\r\nIt reads:\r\nFindings so far: To find the fae you must travel deep into the forest, maybe into the mossy glens, or even under the rocks. They are known to be mischievous, cunning creatures that will try to trick and trap you. I've been told some rules in my traveling by the locals that I need to remember.\r\n\r\nRules:\r\nBring Protection charm\r\n*It's ok if I don't bring it, I just need to be more careful.*\r\nDon't say thank you\r\nDon't say " + playerName + "\r\nDon't accept food or water\r\nStay polite");

            Console.WriteLine("Press enter to close notebook");
            Console.ReadLine();
            Console.WriteLine("It\'s time to set forth, do you bring anything with you?");
            Console.WriteLine("Do you: \n 2. Bring protection charm. \n 3. Bring nothing, you won't be gone long.");

           directionChoice = Console.ReadLine();
        }
        
        if (directionChoice.Equals("2"))
        {
            hasPendent = true;
        }
        else if (directionChoice.Equals("3"))
        {
            hasPendent = false;
        }
        else
        {
            Console.WriteLine("Invalid option. Your research ends here.");
            return;
        }

        Console.WriteLine("You set off into the woods, the leaves and sticks crunching beneath your feet. The trees changing into painted colors. It could be minutes or hours before you can even encounter the fae. The vail is the thinnest this time of year during Samahain. The walk is long and tedious, nothing note worthy, no encounters, nothing. Hours would pass as the sun would dance above you only to slowly descend. Right when the sky changed from the vibrate blue to purples, pinks, and oranges a flash of movement catches your eye. it was quick, subtle, but undoubtly magical. \r\n\r\nThere, flying around you laughing, is a small creature, no bigger than your wrist to the top of your middle finger. \"Well well well.\" the voices is clear despite their size. \"What is a mortal like you doing so deep in the forest?\" They ask, a small grin on their lips. Their body is a pure white, five abyssal eyes, and wings clear like a fly.");

        Console.WriteLine("1. You brought the protection charm. This fae is rubbing you the wrong way. \n 2. Well, I\'ve been researching supernatural creatures and the tales of folk within these woods. I was hoping to study the fae folk and learn of their nature. \n 3.Well it's my business not yours. I live in these woods also and see no reason to explain or tell you anything that you're not entitled to. \n 4. I'm a traveler and seemed to have strayed from the path. I apologize if I offended you in any way. Could you tell me if there is a way out of these woods?");

        string Choice = Console.ReadLine();
        //if (directionChoice.Equals("1"))


    //    // Create the character based on the input
    //    Character player = new Character(playerName, classChoice);

        //    // Create a wild monster
        //    Monster monster = new Monster("Wild Monster", 10);

        //     // Create directions
        //    Direction north = new Direction("North", "You head towards its snowy peaks. \n The air is thin and the wind howls fiercely. \n You can see the peak of the mountain in the distance. \n You can feel the cold air biting at your skin. \n Suddenly, you hear a roar in the distance. \n It sounds like it is coming closer.");
        //    Direction south = new Direction("South", "You venture low into its dense vegetation. The trees are dense and the undergrowth is thick. \n You can hear the sounds of various creatures in the distance. \n Suddenly, you hear a rustling in the bushes. Claws fly out from the leaves and you are thrown back. A wild monster stands before you, ready to attack.");
        //    Direction east = new Direction("East", "You walk along the riverbank. The sound of rushing water fills the air. \n You can see fish swimming in the clear water, while birds sing noisily all around. \n Suddenly, you hear a splash in the distance. A creature slithers up from the water.");
        //    Direction west = new Direction("West", "You find yourself in a dark cave. The walls are damp and the air is musty. \n You can hear the sound of dripping water echoing through the cave. \n Suddenly, you hear a growl in the darkness. Two amber eyes stare at you from the darkness.");

        //    // Choose a direction
        //    Console.WriteLine("Choose a direction to start your adventure: North, South, East, West.");
        //    string directionChoice = Console.ReadLine();

        //    if (directionChoice.Equals("North", StringComparison.OrdinalIgnoreCase))
        //    {
        //        north.DisplayInfo();
        //    }
        //    else if (directionChoice.Equals("South", StringComparison.OrdinalIgnoreCase))
        //    {
        //        south.DisplayInfo();
        //    }
        //    else if (directionChoice.Equals("East", StringComparison.OrdinalIgnoreCase))
        //    {
        //        east.DisplayInfo();
        //    }
        //    else if (directionChoice.Equals("West", StringComparison.OrdinalIgnoreCase))
        //    {
        //        west.DisplayInfo();
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid direction. The adventure ends here.");
        //        return;
        //    }

        //    Console.WriteLine("\nYou encounter a wild monster! What will you do?");
        //    PerformActions(player, monster);

        //    Console.WriteLine("And so ends the story of our brave adventurer.");
        //    Console.ReadLine();
        //}

        //  static void PerformActions(Character character, Monster monster)
        //{
        //    while (character.Health > 0 && monster.Health > 0)
        //    {
        //        Console.WriteLine(character.Name + " is performing an action. Choose: 1 for Attack, 2 for Cast Spell");
        //        string action = Console.ReadLine();

        //        if (action == "1")
        //        {
        //            character.Attack(monster);
        //        }
        //        else if (action == "2")
        //        {
        //            character.CastSpell(monster);
        //        }

        //        character.DisplayHealth();
        //        character.DisplayStoryBasedOnHealth(); // Display story based on character's health
        //        monster.DisplayHealth();
        //        monster.DisplayStoryBasedOnHealth(character); // Display story based on monster's health

        //        if (monster.Health > 0)
        //        {
        //            monster.Attack(character);
        //            character.DisplayHealth();
        //            character.DisplayStoryBasedOnHealth(); // Display story based on character's health
        //        }

        //        if (character.Health <= 0)
        //        {
        //            Console.WriteLine(character.Name + " has been squished in the strong hug of the beast and can no longer enjoy a bowl of ramen or...life.");
        //        }
        //        else if (monster.Health <= 0)
        //        {
        //            Console.WriteLine(monster.Name + " is an empty shell. It's dead inside. Literally. Friendship is the only thing that could have saved it. " + character.Name + " has failed.\n A small tear rolls down " + character.Name + "'s cheek as they realize the weight of their actions.\n " + character.Name + " devours a bowl of ramen in silence, contemplating the fragility of life and the importance of friendship.");
        //        }
        //    }
    }
}