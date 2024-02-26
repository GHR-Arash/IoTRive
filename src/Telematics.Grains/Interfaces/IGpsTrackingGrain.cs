using Orleans;
using Telematics.Grains.Models;
using Telematics.Grains.Tracking;

namespace Telematics.Grains.Interfaces
{
    public interface IGpsTrackingGrain : IGrainWithStringKey
    {
        Task UpdateLocationAsync(LocationData location);
        Task<LocationData> GetCurrentLocationAsync();
        Task<List<LocationData>> GetHistoricalLocationsAsync(DateTime startDate, DateTime endDate);
    }
}
