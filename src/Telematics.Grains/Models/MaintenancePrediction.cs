namespace Telematics.Grains.Models
{
    public class MaintenancePrediction
    {
        public bool IsMaintenanceNeeded { get; set; }
        public string Recommendation { get; set; }
    }
}
