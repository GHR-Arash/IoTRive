using Orleans;
using Telematics.Grains.Models;

namespace Telematics.Grains.Maintenance
{
    public interface IPredictiveMaintenanceGrain : IGrainWithStringKey
    {
        Task<MaintenancePrediction> PredictMaintenanceAsync(string vehicleId);
    }
}
