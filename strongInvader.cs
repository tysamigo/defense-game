namespace DefenseGame
{
    class StrongInvader : Invader
    {
        public override int Health { get; protected set; } = 2; // Health of Invader, initialized to 2 w/private setter
        
        public StrongInvader(Path path) : base(path)
        {}


    }
}