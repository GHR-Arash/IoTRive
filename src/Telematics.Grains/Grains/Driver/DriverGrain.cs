using Orleans;
using Telematics.Grains.Models;

namespace Telematics.Grains
{
    public class DriverGrain : Grain, IDriverGrain
    {
        private List<Trip> _tripHistory = new List<Trip>();

        public Task<List<Trip>> GetTripHistoryAsync()
        {
            // In a real application, trip data would likely be fetched from a database
            return Task.FromResult(_tripHistory);
        }

        // Implement additional methods as required
    }
}
