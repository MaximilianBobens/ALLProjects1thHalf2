namespace AllProjects;

public class CloneTrooper : Player
{
    protected string Info { get; set; }
    protected CloneTrooper(string name, int jump, int heal, int attackPower, string info) : base(name, jump, heal, attackPower)
    {
        Info = info;
    }
}