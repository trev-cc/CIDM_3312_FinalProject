using Microsoft.EntityFrameworkCore;

namespace BuffteksWebsite.Models
{
    public class BuffteksWebsiteContext : DbContext
    {
        public BuffteksWebsiteContext (DbContextOptions<BuffteksWebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<BuffteksWebsite.Models.Member> Member { get; set; }
        public DbSet<BuffteksWebsite.Models.Member> Client { get; set; }
        public DbSet<BuffteksWebsite.Models.Member> Project { get; set; }
        public DbSet<BuffteksWebsite.Models.Member> ClientContac { get; set; }
    }
}

/*dotnet
dotnet aspnet-codegenerator controller -name MembersController -m Member -dc BuffteksWebsiteContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
*/