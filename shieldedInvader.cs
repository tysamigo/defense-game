namespace DefenseGame
{
    class ShieldedInvader : Invader  // This subclass of Invader is such that there is a chance that it won't sustain any damage
    {
        public ShieldedInvader(Path path) : base(path)
        {

        }
    }
}