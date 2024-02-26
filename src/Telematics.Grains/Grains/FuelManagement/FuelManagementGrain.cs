using Orleans;
using Telematics.Grains.Models;

namespace Telematics.Grains.FuelManagement
{

    public class FuelManagementGrain : Grain, IFuelManagementGrain
    {
        private readonly List<FuelData> _fuelDataList = new();

        public Task UpdateFuelDataAsync(FuelData data)
        {
            _fuelDataList.Add(data);
            return Task.CompletedTask;
        }

        public Task<FuelEfficiencyData> GetFuelEfficiencyAsync()
        {
            if (!_fuelDataList.Any())
            {
                return Task.FromResult(new FuelEfficiencyData
                {
                    AverageEfficiency = 0,
                    TotalFuelConsumed = 0,
                    TotalDistanceTravelled = 0
                });
            }

            double totalFuel = _fuelDataList.Sum(data => data.FuelConsumed);
            double totalDistance = _fuelDataList.Sum(data => data.DistanceTravelled);
            double averageEfficiency = totalDistance / totalFuel;

            return Task.FromResult(new FuelEfficiencyData
            {
                AverageEfficiency = averageEfficiency,
                TotalFuelConsumed = totalFuel,
                TotalDistanceTravelled = totalDistance
            });
        }
    }
}
