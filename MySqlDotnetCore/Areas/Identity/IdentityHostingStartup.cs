using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySqlDotnetCoreApp.Areas.Identity.Data;

[assembly: HostingStartup(typeof(MySqlDotnetCoreApp.Areas.Identity.IdentityHostingStartup))]
namespace MySqlDotnetCoreApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<MySqlDotnetCoreIdentityDbContext>(options =>
                    options.UseMySQL(
                        context.Configuration.GetConnectionString("DefaultConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<MySqlDotnetCoreIdentityDbContext>();

            });
        }
    }
}