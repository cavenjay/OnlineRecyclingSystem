using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRecyclingSystem.Areas.Identity.Data
{
    public enum Roles
    {     
        Admin,
        Driver,
        Customer,
        Ban
    }
    public class ContextRoles
    {
        public static async Task SeedRolesAsync(UserManager<OnlineRecyclingSystemUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Driver.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Customer.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Ban.ToString()));

        }

    }
}
