using Orleans;
using Telematics.Grains.Models;


namespace Telematics.Grains.Grains.Safety
{
    public interface IVehicleSafetyGrain : IGrainWithStringKey
    {
        Task RecordSafetyEventAsync(SafetyEvent safetyEvent);
        Task<VehicleSafetySummary> GetVehicleSafetySummaryAsync();
    }

    public class VehicleSafetyGrain : Grain, IVehicleSafetyGrain
    {
        private readonly List<SafetyEvent> _safetyEvents = new();

        public Task RecordSafetyEventAsync(SafetyEvent safetyEvent)
        {
            _safetyEvents.Add(safetyEvent);
            return Task.CompletedTask;
        }

        public Task<VehicleSafetySummary> GetVehicleSafetySummaryAsync()
        {
            var summary = new VehicleSafetySummary
            {
                TotalSafetyEvents = _safetyEvents.Count,
                CollisionWarningsCount = _safetyEvents.Count(e => e.Type == SafetyEventType.CollisionWarning),
                LaneDepartureWarningsCount = _safetyEvents.Count(e => e.Type == SafetyEventType.LaneDepartureWarning),
                AutomaticEmergencyBrakingsCount = _safetyEvents.Count(e => e.Type == SafetyEventType.AutomaticEmergencyBraking)
            };

            return Task.FromResult(summary);
        }
    }
}
