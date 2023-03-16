using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace BookShoppingCartMvc.Infrastructure.Extensions
{
    public class GetIdentityUserId
    {
         static UserManager<IdentityUser>? _userManager;
         static IHttpContextAccessor? _httpContextAccessor;

        public static string GetUserId()
        {
            return _userManager!.GetUserId(_httpContextAccessor!.HttpContext.User)!;
        }
    }
}
