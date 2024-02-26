using Orleans;
using Telematics.Grains.Models;

namespace Telematics.Grains.Geofencing
{

    public class GeofencingGrain : Grain, IGeofencingGrain
    {
        private readonly List<Geofence> _geofences = new();
        private readonly List<GeofenceEvent> _geofenceEvents = new();

        public Task AddGeofenceAsync(Geofence geofence)
        {
            _geofences.Add(geofence);
            return Task.CompletedTask;
        }
        public Task RemoveGeofenceAsync(string geofenceId)
        {
            var geofence = _geofences.FirstOrDefault(g => g.Id == geofenceId);
            if (geofence != null)
            {
                _geofences.Remove(geofence);
            }
            return Task.CompletedTask;
        }
        public Task<bool> IsVehicleInsideAnyGeofenceAsync((double Latitude, double Longitude) vehicleLocation)
        {
            foreach (var geofence in _geofences)
            {
                if (IsInsideGeofence(vehicleLocation, geofence))
                {
                    return Task.FromResult(true);
                }
            }
            return Task.FromResult(false);
        }
        public Task<List<GeofenceEvent>> GetGeofenceBreachesAsync(DateTime startDate, DateTime endDate)
        {
            var breaches = _geofenceEvents
                .Where(@event => @event.Timestamp >= startDate && @event.Timestamp <= endDate)
                .ToList();
            return Task.FromResult(breaches);
        }
        public Task RecordGeofenceEventAsync(GeofenceEvent geofenceEvent)
        {
            _geofenceEvents.Add(geofenceEvent);
            return Task.CompletedTask;
        }

        private bool IsInsideGeofence((double Latitude, double Longitude) location, Geofence geofence)
        {
            var distance = GetDistance(location, (geofence.CenterLatitude, geofence.CenterLongitude));
            return distance <= geofence.Radius;
        }
        private double GetDistance((double Latitude, double Longitude) location1, (double Latitude, double Longitude) location2)
        {
            // Simplified calculation. Consider using a more accurate distance formula for production.
            var dLat = (location2.Latitude - location1.Latitude) * (Math.PI / 180.0);
            var dLon = (location2.Longitude - location1.Longitude) * (Math.PI / 180.0);

            var lat1 = location1.Latitude * (Math.PI / 180.0);
            var lat2 = location2.Latitude * (Math.PI / 180.0);

            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(lat1) * Math.Cos(lat2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            const double EarthRadius = 6371; // Kilometers
            return EarthRadius * c;
        }
    }
}
