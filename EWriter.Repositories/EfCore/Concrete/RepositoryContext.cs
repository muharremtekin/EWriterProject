using EWriter.Entities.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EWriter.Repositories.EfCore.Concrete;

public class RepositoryContext : IdentityDbContext<IdentityUser<Guid>, IdentityRole<Guid>, Guid>
{
    public RepositoryContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

    //dbsteler
    DbSet<Group> Groups { get; set; }
    DbSet<GroupAdmin> GroupAdmins { get; set; }
    DbSet<GroupMembership> GroupMemberships { get; set; }
    DbSet<Post> Posts { get; set; }
    DbSet<ContentType> PostTypes { get; set; }
    DbSet<Question> Questions { get; set; }
    DbSet<QuestionInformation> QuestionInformations { get; set; }
    DbSet<Quiz> Quiz { get; set; }
    DbSet<StudentAnswer> StudentAnswers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
