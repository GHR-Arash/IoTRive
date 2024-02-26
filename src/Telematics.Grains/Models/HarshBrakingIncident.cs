namespace Telematics.Grains.DriverBehavior
{
    public class HarshBrakingIncident
    {
        public DateTime Time { get; set; }
        public double DecelerationRate { get; set; } // Deceleration rate in m/s^2
    }
}
