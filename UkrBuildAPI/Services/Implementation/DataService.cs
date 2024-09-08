using UkrBuildAPI.Services.Interfaces;

namespace UkrBuildAPI.Services.Implementation
{
    public class DataService : IDataService
    {
        private readonly HttpClient httpClient = new HttpClient();

        private readonly string serviceUri;

        public DataService(IConfiguration configuration)
        {
            serviceUri = configuration.GetSection("Services")["DataService"] ?? throw new Exception("Bad Uri");
        }

        public async Task<bool> IsAvailable()
        {
            try
            {
                var response = await httpClient.GetAsync($"{serviceUri}/State");

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }

            return false;
        }
    }
}
