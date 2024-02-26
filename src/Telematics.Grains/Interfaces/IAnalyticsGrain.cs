using Orleans;
using Telematics.Grains.Models;

namespace Telematics.Grains.Interfaces
{
    public interface IAnalyticsGrain : IGrainWithGuidKey
    {
        Task<DriverBehaviorReport> AnalyzeDriverBehaviorAsync(DateTime startDate, DateTime endDate);
    }
}
