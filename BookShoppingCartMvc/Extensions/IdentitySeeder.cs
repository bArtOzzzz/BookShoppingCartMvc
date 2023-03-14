using BookShoppingCartMvc.Roles;
using Microsoft.AspNetCore.Identity;

namespace BookShoppingCartMvc.Extensions
{
    // Should be refactured
    public class IdentitySeeder
    {
        public static async Task SeedDefaultData(IServiceProvider service)
        {
            var userMgr = service.GetService<UserManager<IdentityUser>>();
            var roleMgr = service.GetService<RoleManager<IdentityRole>>();

            await roleMgr!.CreateAsync(new IdentityRole(RoleEnum.Administrator.ToString()));
            await roleMgr.CreateAsync(new IdentityRole(RoleEnum.User.ToString()));

            var admin = new IdentityUser
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                EmailConfirmed = true
            };

            var userInDb = await userMgr!.FindByEmailAsync(admin.Email);

            if (userInDb is null)
            {
                await userMgr.CreateAsync(admin, "Admin@123");
                await userMgr.AddToRoleAsync(admin, RoleEnum.Administrator.ToString());
            }
        }
    }
}
