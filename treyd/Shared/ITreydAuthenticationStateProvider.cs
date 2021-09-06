using Microsoft.AspNetCore.Components.Authorization;
using System.Threading.Tasks;
using treyd.Models;

namespace treyd.Shared
{
    public interface ITreydAuthenticationStateProvider
    {
        Task<AuthenticationState> GetAuthenticationStateAsync();
        byte[] GetSalt();
        string HashPassword(string password, byte[] salt);
        void SetAuthenticationState(AuthModel Auth);
        void UnsetAuthenticationState();
    }
}