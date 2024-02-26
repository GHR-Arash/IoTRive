namespace Telematics.Grains.Models
{
    // Example diagnostics data class for an engine.
    // Extend this class based on the specific diagnostics data you need to store and process.
    public class EngineDiagnosticsData
    {
        public string VehicleId { get; set; }
        public double EngineTemperature { get; set; }
        public int Rpm { get; set; }
        // Consider adding additional fields such as error codes, oil pressure, etc.
    }
}
