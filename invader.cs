using System;

namespace DefenseGame
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0; // This keeps track of the invader's location on the path
        
        protected virtual int StepSize{ get; } = 1;

        // This is a Computed Property using the angle bracket notation syntax
        // Gets the MapLocation of the invader based on its _pathStep
        public MapLocation Location => _path.GetLocationAt(_pathStep);
        
        // This is a Computed Property using Curly Braces syntax
        // True if the invader has reached the end of the path
        public bool HasScored { get { return _pathStep >= _path.Length; } }
        
        public virtual int Health { get; protected set; } = 2; // Health of Invader, initialized to 2 w/private setter
        
        public bool IsNeutralized => Health <= 0;
        
        public bool IsActive => !(IsNeutralized || HasScored);
        
        public Invader(Path path)
        {
            _path = path;
        }
        
        // This method uses the newer single line syntax w/fat arrow
        public void Move() => _pathStep += StepSize;
        
        // This method uses the more traditional syntax w/curly braces
        public virtual void DecreaseHealth(int factor)
        {
            Health -= factor;
            Console.WriteLine("Shot at and hit an invader!");
        }
    }
}