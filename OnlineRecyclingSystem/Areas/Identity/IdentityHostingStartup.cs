using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineRecyclingSystem.Areas.Identity.Data;
using OnlineRecyclingSystem.Data;

[assembly: HostingStartup(typeof(OnlineRecyclingSystem.Areas.Identity.IdentityHostingStartup))]
namespace OnlineRecyclingSystem.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<OnlineRecyclingSystemContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("OnlineRecyclingSystemContextConnection")));

                services.AddDefaultIdentity<OnlineRecyclingSystemUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<OnlineRecyclingSystemContext>();
            });
        }
    }
}