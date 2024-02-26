using Orleans;

namespace Telematics.Grains.Administration
{
    public interface IAdministratorGrain : IGrainWithStringKey
    {
        Task AddUserAsync(User user);
        Task<User> GetUserAsync(string userId);
        Task UpdateSystemConfigurationAsync(SystemConfiguration configuration);
        Task<SystemConfiguration> GetSystemConfigurationAsync();
    }
}
public class User
{
    public string UserId { get; set; }
    public string Name { get; set; }
    public string Role { get; set; } // e.g., Driver, Dispatcher
    // Additional user properties as needed
}

public class SystemConfiguration
{
    public string ConfigurationId { get; set; }
    public Dictionary<string, string> Settings { get; set; } = new Dictionary<string, string>();
    // Additional configuration properties as needed
}
