using Orleans;
using Telematics.Grains.Models;

namespace Telematics.Grains.FuelManagement
{
    public interface IFuelManagementGrain : IGrainWithStringKey
    {
        Task UpdateFuelDataAsync(FuelData data);
        Task<FuelEfficiencyData> GetFuelEfficiencyAsync();
    }
}
