public class Movie
{
    protected string Title { get; set; }
    protected int productionYear;
    protected int ProductionYear
    {
        get { return productionYear; }
        set
        {
            if (productionYear > 2000) ;
            else
            {
                productionYear = value;
                Console.WriteLine("New Movie");
            }
        }
    }
    protected int MovieDuration { get; set; }
    protected string Genre { get; set; }

    public Movie()
    {
        Title = "Default";
        MovieDuration = 0;
        Genre = "Default genre";
    }

    public Movie(string title, int movieDuration, string genre,int productionYear) : this(genre)
    {
        Title = title;
        MovieDuration = movieDuration;
        ProductionYear = productionYear;
        Genre = "Unterhaltungsfilm";
    }
    public Movie(string genre)
    {
        Genre = genre;
    }

    public override string ToString()
    {
        return $"Title: {Title}, Duration: {MovieDuration}, Genre: {Genre} Productionyear: {ProductionYear}";
    }
}