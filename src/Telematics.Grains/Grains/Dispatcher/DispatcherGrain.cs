using Orleans;
using Telematics.Grains.Models;

namespace Telematics.Grains
{
    public class DispatcherGrain : Grain, IDispatcherGrain
    {
        private readonly List<DriverTask> _tasks = new List<DriverTask>();
        private readonly List<Alert> _alerts = new List<Alert>();

        public Task AssignTaskToDriver(string taskId, string driverId)
        {
            _tasks.Add(new DriverTask { TaskId = taskId, DriverId = driverId });
            // Notify the driver grain or update a shared data source as needed
            return Task.CompletedTask;
        }

        public Task<List<Alert>> GetRecentAlertsAsync()
        {
            // In a real application, alerts could be dynamically fetched from a database or an in-memory cache
            return Task.FromResult(_alerts.Where(alert => (DateTime.UtcNow - alert.Timestamp).TotalDays < 1).ToList());
        }

        // Implement additional methods as required
    }
}
