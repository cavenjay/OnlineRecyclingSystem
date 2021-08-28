using OnlineRecyclingSystem.Areas.Identity.Data;
using OnlineRecyclingSystem.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public static class MyIdentityDataInitializer
{
    public static void SeedData
(UserManager<OnlineRecyclingSystemUser> userManager)
    {
        SeedUsers(userManager);
    }

    public async static void SeedUsers
(UserManager<OnlineRecyclingSystemUser> userManager)
    {

        if (userManager.FindByNameAsync
        ("admin@gmail.com").Result == null)
        {
            OnlineRecyclingSystemUser user = new OnlineRecyclingSystemUser()
            {
                User_Role = "Admin",
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                User_Name = "Admin",
                User_DOB = new DateTime(1960, 1, 1),
                EmailConfirmed = true
            };
            var role = Roles.Admin.ToString();
            IdentityResult result = userManager.CreateAsync
            (user, "Admin@123").Result;
            await userManager.AddToRoleAsync(user, role);
        }
    }

    internal static void SeedData(object userManager)
    {
        throw new NotImplementedException();
    }
}
