using Orleans;
using Telematics.Grains.Models;

namespace Telematics.Grains.Reporting
{
    public interface IReportingGrain : IGrainWithGuidKey
    {
        Task<FleetReport> GenerateFleetReportAsync(DateTime startDate, DateTime endDate);
    }
}
