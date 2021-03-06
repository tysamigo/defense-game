using System;

namespace DefenseGame
{
    class Tower
    {
        protected virtual int Range { get; } = 1; // how far the tower can shoot
        protected virtual int Power { get; } = 1; // how much to decrease the invader's health
        protected virtual double Accuracy { get; } = .75; // how accurate the tower is at successfully shooting an invader
        
        private static readonly Random _random = new Random(); // allows the tower to miss its target by using the Random Class to generate a random number
        
        private readonly MapLocation _location;
        
        public Tower(MapLocation location)  // Initialize the tower's location on the map
        {
            _location = location;
        }
        
        // Determines if the tower hits its target by comparing the 
        // randomly generated number with the accuracy of the tower.
        private bool IsSuccessfulShot()
        {
            return _random.NextDouble() < Accuracy;
        }
        
        // Loops through the invaders array and shoots at them
        public void FireOnInvaders(Invader[] invaders)
        {
            foreach(Invader invader in invaders)
            {
                if(invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if(IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(Power);
                        Console.WriteLine("Shot at and hit an invader!");
                        if(invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralized an invader!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Shot at and missed an invader");
                    }
                    break;
                }
            }
        }
    }
}