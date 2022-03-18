using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using SinavOlusturma.Data;
using SinavOlusturma.Models;

namespace SinavOlusturma.Common
{
    public class AdminAccount
    {
        public static void SetupAdminAccount(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var dbContext = serviceScope.ServiceProvider.GetRequiredService<QuizDbContext>();

                var roleManager = serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>();

                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<QuizUser>>();

                if (!roleManager.RoleExistsAsync("Admin").Result)
                {
                    roleManager.CreateAsync(new IdentityRole("Admin")).Wait();
                }
                if (userManager.FindByNameAsync("admin").Result == null)
                {
                    var adminUser = new QuizUser();
                    adminUser.UserName = "admin";
                    adminUser.Email = "admin@admin.com";
                    adminUser.Name = "admin";
                    string adminPassword = "123456";
                    IdentityResult result = userManager.CreateAsync(adminUser, adminPassword).Result;

                    if (result.Succeeded)
                    {
                        userManager.AddToRoleAsync(adminUser, "Admin").Wait();
                    }
                }
            }
        }
    }
}
