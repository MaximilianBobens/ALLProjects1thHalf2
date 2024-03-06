namespace AllProjects;

public class Dragon : AAnimal
{
    public Dragon(string name) : base(name)
    {
        Name = "Dragon";
    }

    public override void Sound()
    {
        Console.WriteLine($"kachhh bruu");
    }
}