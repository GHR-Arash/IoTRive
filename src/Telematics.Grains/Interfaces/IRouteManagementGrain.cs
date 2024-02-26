using Orleans;


namespace Telematics.Grains.Tracking
{
    public interface IRouteManagementGrain : IGrainWithStringKey
    {
        Task SetPredefinedRouteAsync(string routeName, List<LocationData> routePoints);
        Task<List<LocationData>> GetPredefinedRouteAsync(string routeName);
        Task RecordHistoricalRouteAsync(List<LocationData> routePoints);
        Task<List<LocationData>> GetHistoricalRoutesAsync(DateTime startDate, DateTime endDate);
    }
}
