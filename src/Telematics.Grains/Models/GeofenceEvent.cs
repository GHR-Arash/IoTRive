using System;

namespace Telematics.Grains.Models
{
    public class GeofenceEvent
    {
        public string VehicleId { get; set; }
        public DateTime Timestamp { get; set; }
        public GeofenceEventType EventType { get; set; }
        public string GeofenceId { get; set; } // Identifier for the geofenced area
    }

    public enum GeofenceEventType
    {
        Entered,
        Exited
    }
}
