namespace AllProjects;

public class House
{
    public string Color { get; set; }
    public int Count { get; set; }
    
    public House(string color, int count)
    {
        Color = color;
        Count = count;
    }

    public override string ToString()
    {
        return $"Color {Color} RoomCount {Count}";
    }
}