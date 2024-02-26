using Orleans;
using Telematics.Grains.Models;
using Telematics.Grains.Tracking;

namespace Telematics.Grains.Vehicle
{
    public interface IVehicleGrain : IGrainWithStringKey
    {
        Task UpdateVehicleStatusAsync(VehicleStatus status);
        Task<VehicleStatus> GetVehicleStatusAsync();
        Task UpdateLocationAsync(LocationData location);
        Task<LocationData> GetCurrentLocationAsync();
    }
}
