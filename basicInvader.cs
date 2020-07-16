namespace DefenseGame
{
    class BasicInvader : Invader
    {        
        
        public override int Health { get; protected set; } = 2; // Health of Invader
        public BasicInvader(Path path) : base(path)
        {}


    }
}