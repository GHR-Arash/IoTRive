namespace Telematics.Grains.Models
{
    public class VehicleSafetySummary
    {
        public int TotalSafetyEvents { get; set; }
        public int CollisionWarningsCount { get; set; }
        public int LaneDepartureWarningsCount { get; set; }
        public int AutomaticEmergencyBrakingsCount { get; set; }
        // Additional summary metrics can be added here
    }
}
