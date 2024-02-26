using Orleans;
using Telematics.Grains.Models;
namespace Telematics.Grains
{
    public interface IDispatcherGrain : IGrainWithStringKey
    {
        Task AssignTaskToDriver(string taskId, string driverId);
        Task<List<Alert>> GetRecentAlertsAsync();
    }
}
