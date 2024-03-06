namespace AllProjects;
public class Cinema
{
    private Movie[] _movies;

    public Cinema(int movieCount)
    {
        _movies = new Movie[movieCount]; // Initialisierung des _movies-Arrays mit der gewünschten Anzahl von Filmen
    }

    public void CreateMovies(int amount)
    {
        string[] defaultTitles = { "Film 1", "Film 2", "Film 3" };
        int[] defaultDurations = { 2, 3, 4, 5, 6 };
        string[] defaultGenre = { "Testi", "tees", "te" };
        int[] defaultProductionYear = { 1923, 1999, 2001, 2004, 2023 };
        Random random = new Random();

        for (int i = 0; i < amount; i++)
        {
            string title = defaultTitles[random.Next(defaultTitles.Length)];
            int duration = defaultDurations[random.Next(defaultDurations.Length)];
            string genre = defaultGenre[random.Next(defaultGenre.Length)];
            int year = defaultProductionYear[random.Next(defaultProductionYear.Length)];
            _movies[i] = new Movie(title, duration, genre,year);
        }
    }

    public void PrintMovies()
    {
        foreach (Movie movie in _movies)
        {
            Console.WriteLine(movie);
        }
    }
}