using EWriter.Entities.Entities;
using EWriter.Entities.RequestFeatures;
using EWriter.Repositories.Abstract;
using EWriter.Repositories.EfCore.Extension;
using Microsoft.EntityFrameworkCore;

namespace EWriter.Repositories.EfCore.Concrete
{
    public class GroupRepository : RepositoryBase<Group>, IGroupRepository
    {
        public GroupRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateGroup(Group group) => Create(group);

        public void DeleteGroup(Group group) => Delete(group);

        public async Task<PagedList<Group>> GetAllGroupsAsync(GroupParameters parameters, bool trackChanges)
        {
            var groups = await FindAll(trackChanges)
                .Search(parameters.SearchTerm)
                .Sort(parameters.OrderBy)
                .ToListAsync();

            return PagedList<Group>
                .ToPagedList(groups, parameters.PageNumber, parameters.PageSize);
        }

        public async Task<Group> GetOneGroupByIdAsync(Guid id, bool trackChanges) => await FindByCondition(group => group.Id == id, false).
                    Include(group => group.GroupMemberships)
                    .SingleOrDefaultAsync();

        public void UpdateGroup(Group group) => Update(group);
    }
}
