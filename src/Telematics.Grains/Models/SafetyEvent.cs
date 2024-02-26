namespace Telematics.Grains.Models
{
    public class SafetyEvent
    {
        public DateTime Time { get; set; }
        public SafetyEventType Type { get; set; }
        public string Description { get; set; } // Additional details about the event
    }
}
