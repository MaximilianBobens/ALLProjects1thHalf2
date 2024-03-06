namespace AllProjects;

public class Horse : AAnimal
{
    public Horse(string name):base(name)
    {
        Name = "Pferd";
    }
    public override void Sound()
    {
        Console.WriteLine("Neighthing");
    }
}