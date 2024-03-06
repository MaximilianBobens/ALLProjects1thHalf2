namespace AllProjects;

public class Drink
{
    protected string Name { get; set; }
    protected int Temperature { get; set; }

    public Drink()
    {
        Name = "Unknown";
        Temperature = 0;
    }

    public Drink(string name, int temperature)
    {
        Name = name;
        Temperature = temperature;
    }

    public override string ToString()
    {
        return $"Name: {Name} Temperature: {Temperature}";
    }
    
}