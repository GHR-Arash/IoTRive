namespace Telematics.Grains.DriverBehavior
{
    public class SpeedingIncident
    {
        public DateTime Time { get; set; }
        public double SpeedOverLimit { get; set; } // Speed over the limit in km/h
    }
}
