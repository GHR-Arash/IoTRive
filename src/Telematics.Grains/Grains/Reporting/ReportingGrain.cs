using Orleans;
using Telematics.Grains.FuelManagement;
using Telematics.Grains.Geofencing;
using Telematics.Grains.Interfaces;
using Telematics.Grains.Models;

namespace Telematics.Grains.Reporting
{
    public class ReportingGrain : Grain, IReportingGrain
    {
        public async Task<FleetReport> GenerateFleetReportAsync(DateTime startDate, DateTime endDate)
        {
            // Example identifiers for demonstration. Replace these with actual identifiers from your application context.
            var vehicleIds = new List<string> { /* list of vehicle IDs */ };

            // Fetching data from FuelManagementGrains for each vehicle
            var fuelTasks = vehicleIds.Select(id => GrainFactory.GetGrain<IFuelManagementGrain>(id).GetFuelEfficiencyAsync());
            var fuelResults = await Task.WhenAll(fuelTasks);

            // Assuming each vehicle has a diagnostics grain
            var diagnosticsTasks = vehicleIds.Select(id => GrainFactory.GetGrain<IVehicleDiagnosticsGrain>(id).GetDiagnosticsAsync());
            var diagnosticsResults = await Task.WhenAll(diagnosticsTasks);

            // Assuming a single geofencing grain for simplicity, or adjust as needed
            var geofencingGrain = GrainFactory.GetGrain<IGeofencingGrain>("geofencingGrainKey");
            var geofenceBreaches = await geofencingGrain.GetGeofenceBreachesAsync(startDate, endDate);

            // Process results here (simplified aggregation logic)
            var fuelConsumption = fuelResults.Sum(result => result.TotalFuelConsumed);
            var totalDistanceTravelled = diagnosticsResults.Sum(result => result.DistanceTravelled);
            var numberOfGeofenceBreaches = geofenceBreaches.Count;

            return new FleetReport
            {
                StartDate = startDate,
                EndDate = endDate,
                TotalFuelConsumption = fuelConsumption,
                TotalDistanceTravelled = totalDistanceTravelled,
                NumberOfGeofenceBreaches = numberOfGeofenceBreaches,
                // Populate other report fields as necessary
            };
        }
    }
}
