namespace AllProjects;

public class Sorcerer : APlayer
{
    public Sorcerer(string name):base(name)
    {
    }
    
    public override void Fight()
    {
        Console.WriteLine($"The {Name} is fighting");
    }

    public new void Jump()
    {
        Console.WriteLine($"The {Name} is jumping");
    }
    public override void PerformingMagic()
    {
        Console.WriteLine($"The {Name} is using the summoning spell");
    }
}
