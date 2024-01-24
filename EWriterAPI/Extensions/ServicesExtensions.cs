using EWriter.Repositories.EfCore.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EWriter.WebAPI.Extensions;

public static class ServicesExtensions
{
    public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<RepositoryContext>(
            options => options
            .UseNpgsql(configuration
            .GetConnectionString("sqlConnection"))
        );
    }
    public static void ConfigureIdentity(this IServiceCollection services)
    {
        var builder = services.AddIdentity<IdentityUser<Guid>, IdentityRole<Guid>>(opts =>
        {
            opts.SignIn.RequireConfirmedAccount = true;
            opts.Password.RequireDigit = false;
            opts.Password.RequireLowercase = false;
            opts.Password.RequireUppercase = false;
            opts.Password.RequireNonAlphanumeric = false;
            opts.Password.RequiredLength = 5;

            opts.User.RequireUniqueEmail = true;
            opts.User.AllowedUserNameCharacters = "abcçdefghijklmnoöpqrsştuüvwxyzABCÇDEFGHIİJKLMNOÖPQRSŞTUÜVWXYZ0123456789";
        })
        .AddEntityFrameworkStores<RepositoryContext>()
        .AddDefaultTokenProviders();
    }
}

