namespace AllProjects;

public class Druide : Player
{
    protected int SpecialPower { get; set; }
    public Druide(string name, int heal, int jump, int attackPower,int specialPower) : base(name, jump, heal, attackPower)
    {
        SpecialPower = specialPower;
    }
}