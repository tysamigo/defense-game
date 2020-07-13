namespace DefenseGame
{
    class MapLocation : Point
    {
        // Verifies if the Maplocation being constructed is actually on the map
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            if (!map.OnMap(this))
            {
                throw new OutOfBoundsException(x + "," + y + " is outside the boundaries of the map.");
            }
        }
        
        // Determines if this MapLocation Object is in range of the MapLocation Object being passed in
        public bool InRangeOf(MapLocation location, int range)
        {
            return DistanceTo(location) <= range;
        }
    }
}