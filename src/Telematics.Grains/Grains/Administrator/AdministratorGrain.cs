using Orleans;

namespace Telematics.Grains.Administration
{
    public class AdministratorGrain : Grain, IAdministratorGrain
    {
        private readonly Dictionary<string, User> _users = new Dictionary<string, User>();
        private SystemConfiguration _systemConfiguration = new SystemConfiguration();

        public Task AddUserAsync(User user)
        {
            _users[user.UserId] = user;
            return Task.CompletedTask;
        }

        public Task<User> GetUserAsync(string userId)
        {
            _users.TryGetValue(userId, out var user);
            return Task.FromResult(user);
        }

        public Task UpdateSystemConfigurationAsync(SystemConfiguration configuration)
        {
            _systemConfiguration = configuration;
            return Task.CompletedTask;
        }

        public Task<SystemConfiguration> GetSystemConfigurationAsync()
        {
            return Task.FromResult(_systemConfiguration);
        }
    }
}
