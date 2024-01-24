using EWriter.Entities.Entities;
using EWriter.Entities.RequestFeatures;
using EWriter.Entities.RequestFeatures.RequestParameters;

namespace EWriter.Repositories.Abstract
{
    public interface IPostRepository : IRepositoryBase<Post>
    {
        Task<PagedList<Post>> GetAllPostsByUserIdAsync(PostParameters parameters, bool trackChanges);
        Task<PagedList<Post>> GetAllPostsByGroupIdAsync(PostParameters parameters, bool trackChanges);
        Task<Post> GetOnePostByIdAsync(Guid id, bool trackChanges);
        void CreatePost(Post post);
        void UpdatePost(Post post);
        void DeletePost(Post post);
    }
}
