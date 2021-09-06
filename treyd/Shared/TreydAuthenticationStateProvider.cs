using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.Extensions.Configuration;
using System;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using treyd.Models;

namespace treyd.Shared
{
    public class TreydAuthenticationStateProvider : AuthenticationStateProvider, ITreydAuthenticationStateProvider
    {
        private ProtectedSessionStorage _protectedSessionStorage;
        private AuthModel _auth;

        public TreydAuthenticationStateProvider(ProtectedSessionStorage protectedSessionStorage, IConfiguration config)
        {
            _protectedSessionStorage = protectedSessionStorage;
            _auth = new AuthModel();
        }

        /**
         * This gets called when the application loads for the first time
         */
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var user = new ClaimsPrincipal();

            try
            {
                var result = await _protectedSessionStorage.GetAsync<AuthModel>("user");
                _auth = result.Success ? result.Value : null;

                ClaimsIdentity identity = null;

                if (_auth != null)
                {
                    identity = new ClaimsIdentity(new[]
                    {
                        new Claim(ClaimTypes.Name, _auth.Name),
                        new Claim(ClaimTypes.Role, _auth.Role),
                        new Claim(ClaimTypes.Email, _auth.Email),
                    }, "auth_type");
                }
                else
                {
                    identity = new ClaimsIdentity();
                }

                user = new ClaimsPrincipal(identity);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                UnsetAuthenticationState();
            }

            return await Task.FromResult(new AuthenticationState(user));
        }

        /**
         * Authenticating the user on login or register
         */
        public void SetAuthenticationState(AuthModel Auth)
        {
            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, Auth.Name),
                new Claim(ClaimTypes.Role, Auth.Role),
                new Claim(ClaimTypes.Email, Auth.Email),
            }, "auth_type"); ;

            var user = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        /**
         * Logging user out
         */
        public void UnsetAuthenticationState()
        {
            _protectedSessionStorage.DeleteAsync("user");

            var identity = new ClaimsIdentity();

            var user = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        /*
         * Getting a uniquely generated salt
         */
        public byte[] GetSalt()
        {
            // generate a 512-bit salt using a secure PRNG
            byte[] salt = new byte[512 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            return salt;
        }

        /**
         * Hashing the password to a unique hash value using the generated salt
         */
        public string HashPassword(string password, byte[] salt)
        {
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA512,
                iterationCount: 10000,
                numBytesRequested: 512 / 8));

            return hashed;
        }
    }
}
