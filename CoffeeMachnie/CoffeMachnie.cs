namespace AllProjects;

public class CoffeMachnie
{
    private Drink[] _drinks;
    public CoffeMachnie(int count)
    {
        _drinks = new Drink[count];
    }

    public void GenerateDrinks(int amount)
    {
        string[] defaultName = { "Espresso", "Americano", "Latte", "Cappuccino", "Macchiato", "Mocha", "Flat White", "Affogato",};
        int[] defaultTemperature = { 37, 38, 39, 40, 41, 42, 44 };
        Random random = new Random();

        for (int i = 0; i < amount; i++)
        {
            string randomName = defaultName[random.Next(defaultName.Length)];
            int randomTemperature = defaultTemperature[random.Next(defaultName.Length)];
            _drinks[i] = new Drink(randomName, randomTemperature);
        }
    }

    public void PrintDrinks()
    {
        foreach (Drink drink in _drinks)
        {
            Console.WriteLine(drink);
        }
    }
}