namespace AllProjects;

public abstract class AAnimal
{
    protected string Name { get; set; }
    public AAnimal(string name)
    {
        Name = name;
    }
    
    public void Eating(string food)
    {
    }
    
    public void Running()
    {
        Console.WriteLine($"Running");
    }

    public virtual void Moving()
    {
        Console.WriteLine($"Moving");
    }

    public abstract void Sound();
    
    public override string ToString()
    {
        return $"Name {Name}" ;
    }

  
    
    
}