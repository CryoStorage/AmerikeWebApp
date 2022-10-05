namespace Crapi_API.Models
{
    public class Player
    {
        public long Id { get; set; }
        public int Jumps { get; set; }
        public int Wins { get; set; }
        public int Deaths { get; set; }
        public int OrbsCollected { get; set; }
        public int OrbsSpent { get; set; }
        public int AdsWatched { get; set; }
        public long PlayTime { get; set; }
        public long AvgPlaySession { get; set; }
        public long DistanceClimbed { get; set; }
        public long DistanceFallen { get; set; }

    }
}
