using EWriter.Entities.Entities;
using EWriter.Entities.RequestFeatures;
using EWriter.Entities.RequestFeatures.RequestParameters;
using EWriter.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace EWriter.Repositories.EfCore.Concrete;

public class PostRepository : RepositoryBase<Post>, IPostRepository
{
    public PostRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public void CreatePost(Post post) => CreatePost(post);

    public void DeletePost(Post post) => Delete(post);

    /// <summary>
    /// TR: Bu fonksiyon belirtilen grupta patlaşılan gönderileri döndürür.
    /// </summary>
    /// <param name="parameters"> PostParameters.GroupId </param>
    /// <param name="trackChanges"> değişiklikleri izlemek istiyor musun? </param>
    /// <returns></returns>
    public async Task<PagedList<Post>> GetAllPostsByGroupIdAsync(PostParameters parameters, bool trackChanges)
    {
        var posts = await FindAll(trackChanges)
            .Where(g => g.GroupId == parameters.GroupId)
            .OrderBy(p => p.CreateDate).ToListAsync();

        return PagedList<Post>.ToPagedList(posts, parameters.PageNumber, parameters.PageSize);
    }

    public async Task<PagedList<Post>> GetAllPostsByUserIdAsync(PostParameters parameters, bool trackChanges)
    {
        var userPosts = await FindAll(trackChanges).
            OrderBy(p => p.CreateDate).ToListAsync();

        return PagedList<Post>.ToPagedList(userPosts, parameters.PageNumber, parameters.PageSize);
    }

    public async Task<Post> GetOnePostByIdAsync(Guid id, bool trackChanges) => await FindByCondition(p => p.Id == id, false).SingleOrDefaultAsync();

    public void UpdatePost(Post post) => Update(post);
}
