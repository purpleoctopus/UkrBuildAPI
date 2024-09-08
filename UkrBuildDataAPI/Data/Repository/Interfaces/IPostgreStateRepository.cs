namespace UkrBuildDataAPI.Data.Repository.Interfaces
{
    public interface IPostgreStateRepository
    {
        public Task<bool> CheckConnection();
    }
}
