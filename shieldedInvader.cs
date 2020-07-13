namespace DefenseGame
{
    class ShieldedInvader : Invader  // This subclass of Invader is such that there is a chance that it won't sustain any damage
    {       
        private static System.Random _random = new System.Random(); // static random instance
        
        public ShieldedInvader(Path path) : base(path)
        {}

        public override void DecreaseHealth(int factor)
        {
            if(_random.NextDouble() < .5) // returns random number between 0 and 1 so that body is only executed 50% of the time
            {
                base.DecreaseHealth(factor); //calls the base class's (the normal Invader class) DecreaseHealth method passing in factor
            }
        }
    }
}