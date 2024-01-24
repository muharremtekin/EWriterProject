using EWriter.Entities.Entities;
using System.Linq.Dynamic.Core;
using System.Reflection;

namespace EWriter.Repositories.EfCore.Extension
{
    public static class GroupRepositoryExtensions
    {
        public static IQueryable<Group> Search(this IQueryable<Group> groups, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return groups;

            var lowerCaseTerm = searchTerm.Trim().ToLower();
            return groups.Where(group => group.GroupName.ToLower().Contains(lowerCaseTerm) || group.GroupDescription.ToLower().Contains(lowerCaseTerm));
        }

        public static IQueryable<Group> Sort(this IQueryable<Group> groups, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString)) return groups.OrderBy(group => group.Id);

            var orderParams = orderByQueryString.Trim().Split(',');

            var propertyInfos = typeof(Group).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var orderQuery = OrderQueryBuilder.CreateOrderQuery<Group>(orderByQueryString);

            if (string.IsNullOrWhiteSpace(orderQuery))
                return groups.OrderBy(group => group.Id);

            return groups.OrderBy(orderQuery);
        }
    }
}
