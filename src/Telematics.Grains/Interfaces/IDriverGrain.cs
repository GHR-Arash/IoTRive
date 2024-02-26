using Orleans;
using Telematics.Grains.Models;

namespace Telematics.Grains
{
    public interface IDriverGrain : IGrainWithStringKey
    {
        Task<List<Trip>> GetTripHistoryAsync();
        // Add more methods as needed, e.g., for sending feedback
    }
}
