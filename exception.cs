namespace DefenseGame
{
    class DefenseGameException : System.Exception
    {
        public DefenseGameException()
        {
        }
        
        public DefenseGameException(string message) : base(message)
        {
        }
    }
    
    class OutOfBoundsException : DefenseGameException
    {
        public OutOfBoundsException()
        {
        }
        
        public OutOfBoundsException(string message) : base(message)
        {
        }
    }
}