namespace AllProjects;

public class Snake : AAnimal
{
    public Snake(string name) : base(name)
    {
        Name = "Snake";
    }

    

    public override void Sound()
    {
        Console.WriteLine("schhhhhh");
    }
}