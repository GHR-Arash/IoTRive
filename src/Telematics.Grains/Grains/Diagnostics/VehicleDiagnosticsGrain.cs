using Orleans;
using Telematics.Grains.Interfaces;
using Telematics.Grains.Models;

namespace Telematics.Grains.Diagnostics
{

    public class VehicleDiagnosticsGrain : Grain, IVehicleDiagnosticsGrain
    {
        private VehicleDiagnosticsData _diagnosticsData;

        public Task UpdateDiagnosticsAsync(VehicleDiagnosticsData diagnostics)
        {
            _diagnosticsData = diagnostics;
            return Task.CompletedTask;
        }

        public Task<VehicleDiagnosticsData> GetDiagnosticsAsync()
        {
            return Task.FromResult(_diagnosticsData);
        }
    }
}
