namespace Telematics.Grains.Models
{
    public class FleetReport
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double TotalFuelConsumption { get; set; }
        public double TotalDistanceTravelled { get; set; }
        public int NumberOfGeofenceBreaches { get; set; }
        // Include other relevant metrics for your fleet report
    }
}
