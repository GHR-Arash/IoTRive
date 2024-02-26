using Orleans;
using System;
using System.Threading.Tasks;
using Telematics.Grains.Models;

namespace Telematics.Grains.Maintenance
{
    public class PredictiveMaintenanceGrain : Grain, IPredictiveMaintenanceGrain
    {
        public async Task<MaintenancePrediction> PredictMaintenanceAsync(string vehicleId)
        {
            // Example: Fetch diagnostics data for the vehicle
            var diagnosticsGrain = GrainFactory.GetGrain<IDiagnosticsGrain>(vehicleId);
            var diagnosticsData = await diagnosticsGrain.GetDiagnosticsDataAsync();

            // Simplified predictive logic based on diagnostics data
            var prediction = new MaintenancePrediction();
            if (diagnosticsData.EngineTemperature > 100) // Example condition
            {
                prediction.IsMaintenanceNeeded = true;
                prediction.Recommendation = "Check engine cooling system.";
            }
            else if (diagnosticsData.TirePressure < 30) // Another example condition
            {
                prediction.IsMaintenanceNeeded = true;
                prediction.Recommendation = "Inspect tire pressure.";
            }
            else
            {
                prediction.IsMaintenanceNeeded = false;
                prediction.Recommendation = "No immediate maintenance required.";
            }

            return prediction;
        }
    }
}
