namespace AllProjects;


public class Game
{
    private APlayer[] player;

    public Game()
    {
        player = new APlayer[3];
        Random rand = new Random();
        
        for (int i = 0; i < player.Length; i++)
        {
            switch (rand.Next(1,3))
            {
                case 1:
                    player[i] = new Sorcerer("Sorcerer "+ i);
                    break;
                case 2:
                    player[i] = new Druid($"Druid {i}");
                    break;
                case 3:
                    player[i] = new Swordsman($"Swordsman {i}");
                    break;   
            }
        }
    }

    public void PrintRunning()
    {
        foreach (var a in player)
        {
            a.Running();
        }
    }
    
    public void PrintFighting()
    {
        foreach (var a in player)
        {
            a.Fight();
        }
    }
    
    public void PrintJumping()
    {
        foreach (var a in player)
        {
            a.Jump();
        }
    }
    
    public void PrintPerformMagic()
    {
        foreach (var a in player)
        {
            a.PerformingMagic();
        }
    }
}