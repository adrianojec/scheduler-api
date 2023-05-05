namespace Application.Context
{
    public interface IDataContext
    {
        Task<int> SaveCahngesAsync(CancellationToken cancellationToken = default);
    }
}