using Orleans;
using Telematics.Grains.Models;

namespace Telematics.Grains.Interfaces
{
    public interface IVehicleDiagnosticsGrain : IGrainWithStringKey
    {
        Task UpdateDiagnosticsAsync(VehicleDiagnosticsData diagnostics);
        Task<VehicleDiagnosticsData> GetDiagnosticsAsync();
    }
}
