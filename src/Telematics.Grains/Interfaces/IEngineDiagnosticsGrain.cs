using Orleans;
using Telematics.Grains.Models;

namespace Telematics.Grains.Interfaces
{
    public interface IEngineDiagnosticsGrain : IGrainWithStringKey
    {
        Task UpdateEngineDiagnosticsAsync(EngineDiagnosticsData diagnostics);
        Task<EngineDiagnosticsData> GetEngineDiagnosticsAsync();
    }
}
