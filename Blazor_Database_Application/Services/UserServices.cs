using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

#nullable disable

namespace Blazor_Database_Application.Services
{
    public class UserServices
    {
        private string userName;
        private AuthenticationStateProvider _ASP;
        public UserServices(AuthenticationStateProvider ASP)
        {
            _ASP = ASP;
        }

        public async Task<string> GetUserNameAsync()
        {
            var authState = await _ASP.GetAuthenticationStateAsync();
            return authState.User.Identity.Name;
        }

        public async Task<string> GetUserIdAsync()
        {
            var authState = await _ASP.GetAuthenticationStateAsync();
            return authState.User.FindFirstValue(ClaimTypes.NameIdentifier);
            //return authState.User.FindFirst(x => x.Type == "sub").Value;
        }
    }
}
