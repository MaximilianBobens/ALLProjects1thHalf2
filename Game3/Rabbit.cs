namespace AllProjects;

public class Rabbit : AAnimal
{
    public Rabbit(string name) : base(name)
    {
        Name = "Rabbit";
    }

    public override void Sound()
    {
        Console.WriteLine("Rrraraa");
    }
}