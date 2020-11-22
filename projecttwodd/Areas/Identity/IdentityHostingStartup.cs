using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using projecttwodd.Data;

[assembly: HostingStartup(typeof(projecttwodd.Areas.Identity.IdentityHostingStartup))]
namespace projecttwodd.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<projecttwoddContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("projecttwoddContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<projecttwoddContext>();
            });
        }
    }
}