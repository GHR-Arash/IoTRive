namespace Telematics.Grains.Models
{
    public class Alert
    {
        public DateTime Timestamp { get; set; }
        public string Type { get; set; } // e.g., "GeofenceBreached", "SafetyIncident"
        public string Description { get; set; }
        // Additional alert details as needed
    }
}
