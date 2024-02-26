using Orleans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telematics.Grains.Interfaces;
using Telematics.Grains.Models;

namespace Telematics.Grains.Tracking
{

    public class GpsTrackingGrain : Grain, IGpsTrackingGrain
    {
        private LocationData _currentLocation;
        private readonly List<LocationData> _locationHistory = new();

        public Task UpdateLocationAsync(LocationData location)
        {
            _currentLocation = location;
            // Optionally, add the location to the history for tracking over time
            _locationHistory.Add(location);
            return Task.CompletedTask;
        }

        public Task<LocationData> GetCurrentLocationAsync()
        {
            return Task.FromResult(_currentLocation);
        }

        public Task<List<LocationData>> GetHistoricalLocationsAsync(DateTime startDate, DateTime endDate)
        {
            var historicalLocations = _locationHistory
                .Where(location => location.Timestamp >= startDate && location.Timestamp <= endDate)
                .ToList();
            return Task.FromResult(historicalLocations);
        }
    }
}
