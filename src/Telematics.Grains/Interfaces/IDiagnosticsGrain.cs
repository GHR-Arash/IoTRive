using Orleans;
using Telematics.Grains.Models;

public interface IDiagnosticsGrain : IGrainWithStringKey
{
    Task<DiagnosticsData> GetDiagnosticsDataAsync();
}


