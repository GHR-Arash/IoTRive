using Orleans;
using Telematics.Grains.Models;
using Telematics.Grains.Tracking;

namespace Telematics.Grains.Vehicle
{
    public class VehicleGrain : Grain, IVehicleGrain
    {
        private VehicleStatus _currentStatus = new VehicleStatus();
        private LocationData _currentLocation = new LocationData();

        public Task UpdateVehicleStatusAsync(VehicleStatus status)
        {
            _currentStatus = status;
            return Task.CompletedTask;
        }

        public Task<VehicleStatus> GetVehicleStatusAsync()
        {
            return Task.FromResult(_currentStatus);
        }

        public Task UpdateLocationAsync(LocationData location)
        {
            _currentLocation = location;
            return Task.CompletedTask;
        }

        public Task<LocationData> GetCurrentLocationAsync()
        {
            return Task.FromResult(_currentLocation);
        }
    }
}
