namespace Telematics.Grains.Models
{
    public class Trip
    {
        public string TripId { get; set; }
        public string DriverId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double Distance { get; set; }
        // Additional trip details as needed
    }
}
