namespace AllProjects;

public class Coffee : Drink
{
    protected bool HasMilk { get; set; }
    public Coffee()
    {
        Name = "Unknown";
        Temperature = 0;
        HasMilk = true;
    }
    public Coffee(string name, int temperature, bool hasMilk) : base(name, temperature)
    {
        HasMilk = hasMilk;
    }

    public override string ToString()
    {
        return $"Name: {Name} Temperature {Temperature} has milk? {HasMilk}";
    }
  
}