namespace Telematics.Grains.Models
{
    public class FuelEfficiencyData
    {
        public double AverageEfficiency { get; set; } // Kilometers per liter
        public double TotalFuelConsumed { get; set; }
        public double TotalDistanceTravelled { get; set; }
    }
}
