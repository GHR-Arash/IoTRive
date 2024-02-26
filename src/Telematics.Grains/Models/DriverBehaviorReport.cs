namespace Telematics.Grains.Models
{
    public class DriverBehaviorReport
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public SpeedingAnalysis SpeedingIncidentsAnalysis { get; set; }
        public BrakingAnalysis HarshBrakingIncidentsAnalysis { get; set; }
    }
}
