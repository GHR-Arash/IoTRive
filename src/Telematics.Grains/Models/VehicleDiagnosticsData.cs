namespace Telematics.Grains.Models
{
    // Assuming VehicleDiagnosticsData is defined elsewhere in your project
    public class VehicleDiagnosticsData
    {
        public string VehicleId { get; set; }
        public double EngineTemperature { get; set; }
        public double FuelLevel { get; set; }
        public double TirePressure { get; set; }
        public double DistanceTravelled { get; internal set; }
        // Add other diagnostics properties as needed
    }
}
