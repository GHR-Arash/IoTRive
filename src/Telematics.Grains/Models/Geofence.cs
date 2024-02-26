namespace Telematics.Grains.Models
{
    public class Geofence
    {
        public string Id { get; set; }
        public double CenterLatitude { get; set; }
        public double CenterLongitude { get; set; }
        public double Radius { get; set; } // Radius in kilometers
    }
}
