namespace Telematics.Grains.Models
{
    public class FuelData
    {
        public DateTime Date { get; set; }
        public double FuelConsumed { get; set; } // Liters
        public double DistanceTravelled { get; set; } // Kilometers
    }
}
