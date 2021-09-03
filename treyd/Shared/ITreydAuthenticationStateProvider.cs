using Microsoft.AspNetCore.Components.Authorization;
using System.Threading.Tasks;

namespace treyd.Shared
{
    public interface ITreydAuthenticationStateProvider
    {
        Task<AuthenticationState> GetAuthenticationStateAsync();
        byte[] GetSalt();
        string HashPassword(string password, byte[] salt);
        void SetAuthenticationState(string name, string role, string email);
        void UnsetAuthenticationState();
    }
}