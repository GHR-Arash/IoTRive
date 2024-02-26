using Orleans;
using Telematics.Grains.Interfaces;
using Telematics.Grains.Models;

namespace Telematics.Grains.Diagnostics
{

    public class EngineDiagnosticsGrain : Grain, IEngineDiagnosticsGrain
    {
        private EngineDiagnosticsData _engineDiagnosticsData;

        public Task UpdateEngineDiagnosticsAsync(EngineDiagnosticsData diagnostics)
        {
            _engineDiagnosticsData = diagnostics;
            return Task.CompletedTask;
        }

        public Task<EngineDiagnosticsData> GetEngineDiagnosticsAsync()
        {
            // Ensure there's always some data returned, possibly initializing an empty object
            // if no diagnostics data has been set yet.
            _engineDiagnosticsData ??= new EngineDiagnosticsData();
            return Task.FromResult(_engineDiagnosticsData);
        }
    }
}
