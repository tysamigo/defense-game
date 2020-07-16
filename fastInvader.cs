namespace DefenseGame
{
    class FastInvader : Invader
    {
        protected override int StepSize{ get; } = 2;

        public override int Health { get; protected set; } = 2; // Health of Invader
        
        public FastInvader(Path path) : base(path)
        {}


    }
}