using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MySqlDotnetCoreApp.Areas.Identity.Data
{
    public class MySqlDotnetCoreIdentityDbContext : IdentityDbContext<IdentityUser>
    {
        public MySqlDotnetCoreIdentityDbContext(DbContextOptions<MySqlDotnetCoreIdentityDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
