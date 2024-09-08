using UkrBuildDataAPI.Data.Repository.Interfaces;

namespace UkrBuildDataAPI.Data.Repository.Implementation
{
    public class PostgreStateRepository : IPostgreStateRepository
    {
        private readonly PostgreContext _context;

        public PostgreStateRepository(PostgreContext context)
        {
            this._context = context;
        }

        public async Task<bool> CheckConnection()
        {
            return await _context.Database.CanConnectAsync();
        }
    }
}
