using Orleans;
using Telematics.Grains.Models;

namespace Telematics.Grains.Geofencing
{
    public interface IGeofencingGrain : IGrainWithStringKey
    {
        Task AddGeofenceAsync(Geofence geofence);
        Task RemoveGeofenceAsync(string geofenceId);
        Task<bool> IsVehicleInsideAnyGeofenceAsync((double Latitude, double Longitude) vehicleLocation);
        Task RecordGeofenceEventAsync(GeofenceEvent geofenceEvent);
        Task<List<GeofenceEvent>> GetGeofenceBreachesAsync(DateTime startDate, DateTime endDate);

    }
}
