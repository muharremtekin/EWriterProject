using EWriter.Entities.Entities;
using EWriter.Entities.RequestFeatures;
using EWriter.Entities.RequestFeatures.RequestParameters;

namespace EWriter.Repositories.Abstract;
public interface IQuizRepository : IRepositoryBase<Quiz>
{
    Task<PagedList<Quiz>> GetAllFaultsAsync(QuizParameters faultParameters, bool trackChanges);
    Task<Quiz> GetFaultByIdAsync(Guid id, bool trackChanges);
    void CreateFault(Quiz quiz);
    void UpdateFault(Quiz quiz);
    void DeleteFault(Quiz quiz);
}