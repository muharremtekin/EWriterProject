using EWriter.Repositories.Abstract;

namespace EWriter.Repositories.EfCore.Concrete;
public class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryContext _repositoryContext;

    public RepositoryManager(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
    }
    public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
}

