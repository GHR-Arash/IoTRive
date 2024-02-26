using Orleans;
using Telematics.Grains.Interfaces;
using Telematics.Grains.Models;

namespace Telematics.Grains.DriverBehavior
{

    public class DriverBehaviorGrain : Grain, IDriverBehaviorGrain
    {
        private readonly List<SpeedingIncident> _speedingIncidents = new();
        private readonly List<HarshBrakingIncident> _harshBrakingIncidents = new();

        public Task RecordSpeedingIncidentAsync(SpeedingIncident incident)
        {
            _speedingIncidents.Add(incident);
            return Task.CompletedTask;
        }

        public Task RecordHarshBrakingIncidentAsync(HarshBrakingIncident incident)
        {
            _harshBrakingIncidents.Add(incident);
            return Task.CompletedTask;
        }

        public Task<DriverBehaviorSummary> GetDriverBehaviorSummaryAsync()
        {
            var summary = new DriverBehaviorSummary
            {
                TotalSpeedingIncidents = _speedingIncidents.Count,
                TotalHarshBrakingIncidents = _harshBrakingIncidents.Count,
                // Additional metrics can be calculated here
            };

            return Task.FromResult(summary);
        }
    }
}
