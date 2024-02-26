using Orleans;


namespace Telematics.Grains.Tracking
{

    public class RouteManagementGrain : Grain, IRouteManagementGrain
    {
        private readonly Dictionary<string, List<LocationData>> _predefinedRoutes = new();
        private readonly List<List<LocationData>> _historicalRoutes = new();

        public Task SetPredefinedRouteAsync(string routeName, List<LocationData> routePoints)
        {
            _predefinedRoutes[routeName] = routePoints;
            return Task.CompletedTask;
        }

        public Task<List<LocationData>> GetPredefinedRouteAsync(string routeName)
        {
            _predefinedRoutes.TryGetValue(routeName, out var route);
            return Task.FromResult(route ?? new List<LocationData>());
        }

        public Task RecordHistoricalRouteAsync(List<LocationData> routePoints)
        {
            _historicalRoutes.Add(routePoints);
            return Task.CompletedTask;
        }

        public Task<List<LocationData>> GetHistoricalRoutesAsync(DateTime startDate, DateTime endDate)
        {
            var filteredRoutes = _historicalRoutes
                .Where(route => route.Any(point => point.Timestamp >= startDate && point.Timestamp <= endDate))
                .ToList();
            return Task.FromResult(filteredRoutes.FirstOrDefault());
        }
    }
}
