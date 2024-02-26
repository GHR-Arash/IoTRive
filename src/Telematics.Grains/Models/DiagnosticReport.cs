namespace Telematics.Grains.Models
{
    public class DiagnosticReport
    {
        public string VehicleId { get; set; }
        public double EngineTemperature { get; set; }
        public double FuelLevel { get; set; }
        // Other diagnostic fields
    }
}
