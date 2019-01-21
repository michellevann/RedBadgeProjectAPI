using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.SeedData
{
    public static class ApplicationDbInitializer
    {
        public static void SeedUsers(UserManager<IdentityUser> userManager)
        {
            if (userManager.FindByEmailAsync("lauracnahas@gmail.com").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "lauracnahas@gmail.com",
                    Email = "lauracnahas@gmail.com"
                };

                IdentityResult result = userManager.CreateAsync(user, "Test123").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
        }
    }
}
