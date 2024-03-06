namespace AllProjects;

    public abstract class APlayer
    {
        public string Name { get; set; }

        public APlayer(string name)
        {
            this.Name = name;
        }

        public void Running()
        {
            Console.WriteLine("Player rennt");
        }

        public virtual void Fight()
        {
            Console.WriteLine("Player is in a fight");
        }

        public void Jump()
        {
            Console.WriteLine("Player jumps");
        }

        public abstract void PerformingMagic();
    }
