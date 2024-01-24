namespace EWriter.Repositories.Abstract
{
    /// <summary>
    /// This interface for management all repositories
    /// </summary>
    public interface IRepositoryManager
    {
        // IProductRepository Product { get; }
        Task SaveAsync();
    }
}
