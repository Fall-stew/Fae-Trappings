using System;

class Direction
{
    public string Name;
    public string Description;

    public Direction(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("You are heading: " + Name);
        Console.WriteLine(Description);
    }
}