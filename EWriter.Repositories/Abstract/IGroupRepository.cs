using EWriter.Entities.Entities;
using EWriter.Entities.RequestFeatures;

namespace EWriter.Repositories.Abstract
{
    public interface IGroupRepository : IRepositoryBase<Group>
    {
        Task<PagedList<Group>> GetAllGroupsAsync(GroupParameters parameters, bool trackChanges);
        Task<Group> GetOneGroupByIdAsync(Guid id, bool trackChanges);
        void CreateGroup(Group group);
        void UpdateGroup(Group group);
        void DeleteGroup(Group group);
    }
}
