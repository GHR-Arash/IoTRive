using Orleans;
using Telematics.Grains.DriverBehavior;
using Telematics.Grains.Models;

namespace Telematics.Grains.Interfaces
{
    public interface IDriverBehaviorGrain : IGrainWithStringKey
    {
        Task RecordSpeedingIncidentAsync(SpeedingIncident incident);
        Task RecordHarshBrakingIncidentAsync(HarshBrakingIncident incident);
        Task<DriverBehaviorSummary> GetDriverBehaviorSummaryAsync();
    }
}
