using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

#nullable disable

namespace Blazor_Database_Application.Services
{
    public class UserServices
    {
        private AuthenticationStateProvider _ASP;
        public UserServices(AuthenticationStateProvider ASP)
        {
            _ASP = ASP;
        }

        //Returns a user's name
        public async Task<string> GetUserNameAsync()
        {
            var authState = await _ASP.GetAuthenticationStateAsync();
            return authState.User.Identity.Name;
        }

        //Returns a user's id
        public async Task<string> GetUserIdAsync()
        {
            var authState = await _ASP.GetAuthenticationStateAsync();
            return authState.User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
