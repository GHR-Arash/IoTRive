using Orleans;
using Telematics.Grains.DriverBehavior;
using Telematics.Grains.Interfaces;
using Telematics.Grains.Models;

namespace Telematics.Grains.Reporting
{

    public class AnalyticsGrain : Grain, IAnalyticsGrain
    {
        public async Task<DriverBehaviorReport> AnalyzeDriverBehaviorAsync(DateTime startDate, DateTime endDate)
        {
            // Placeholder for driver behavior data aggregation
            var speedingIncidents = new List<SpeedingIncident>();
            var harshBrakingIncidents = new List<HarshBrakingIncident>();

            // In a real scenario, fetch this data from a data source or other grains
            // For demonstration, we are initializing with empty lists

            // Example analysis - count incidents and categorize by severity
            var speedingAnalysis = AnalyzeSpeedingIncidents(speedingIncidents);
            var brakingAnalysis = AnalyzeBrakingIncidents(harshBrakingIncidents);

            return new DriverBehaviorReport
            {
                StartDate = startDate,
                EndDate = endDate,
                SpeedingIncidentsAnalysis = speedingAnalysis,
                HarshBrakingIncidentsAnalysis = brakingAnalysis,
            };
        }

        private SpeedingAnalysis AnalyzeSpeedingIncidents(List<SpeedingIncident> incidents)
        {
            // Example analysis logic
            var analysis = new SpeedingAnalysis
            {
                TotalIncidents = incidents.Count,
                HighSeverityIncidents = incidents.Count(i => i.SpeedOverLimit >= 20), // Example threshold
            };

            return analysis;
        }

        private BrakingAnalysis AnalyzeBrakingIncidents(List<HarshBrakingIncident> incidents)
        {
            // Example analysis logic
            var analysis = new BrakingAnalysis
            {
                TotalIncidents = incidents.Count,
                HighSeverityIncidents = incidents.Count(i => i.DecelerationRate > 5), // Example threshold
            };

            return analysis;
        }
    }
}
