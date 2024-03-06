namespace AllProjects;

public class Player
{
    public string Name { get; set; }

    public int Heal { get; set; }
    private int _jump; // Feld zur Speicherung des Sprungwerts
    private int _attackPower;

    public int Jump
    {
        get
        {
            return _jump;
        }
        set
        {
            Jump = value;
        }
    }

    public int AttackPower
    {
        get
        {
            return _attackPower;
        }

        set
        {
            AttackPower = value;
        }
    }

    public Player(string name, int heal, int jump, int attackPower)
    {
        Name = name;
        Heal = heal;
        Jump = jump;
        AttackPower = attackPower;
    }

    public void  Fight()
    {
        Console.WriteLine($"He {Name} is fighting");
    }

    public virtual void Fighting()
    {
        throw new NotImplementedException();
    }

    public virtual void PerformingMagic()
    {
        throw new NotImplementedException();
    }
}