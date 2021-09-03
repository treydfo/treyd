using DataLibrary;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using treyd.Models;

namespace treyd.Shared
{
    public class TreydAuthenticationStateProvider : AuthenticationStateProvider, ITreydAuthenticationStateProvider
    {
        private ProtectedSessionStorage _protectedSessionStorage;
        private IConfiguration _config;
        private IDataAccess _data;
        private UserModel _user;

        public TreydAuthenticationStateProvider(ProtectedSessionStorage protectedSessionStorage, IConfiguration config)
        {
            _protectedSessionStorage = protectedSessionStorage;
            _config = config;
            _data = new DataAccess();
            _user = new UserModel();
        }

        protected async Task<bool> LoadUser(string email)
        {
            try
            {
                string sql = "select * from users where Email = @Email";
                _user = await _data.QuerySingle<UserModel, dynamic>(sql, new { Email = email }, _config.GetConnectionString("default"));

                return await Task.FromResult(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return await Task.FromResult(false);
            }
        }

        /**
         * This gets called when the application loads for the first time
         */
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var user = new ClaimsPrincipal();

            try
            {
                var auth = await _protectedSessionStorage.GetAsync<string>("user");
                ClaimsIdentity identity = null;

                if (auth.Value != null)
                {
                    var data = auth.Value.Split(" ");
                    var strArr = data.Take(data.Length - 2);
                    string name = string.Join(" ", strArr);
                    string role = data[data.Length - 2];
                    string email = data[data.Length - 1];

                    await LoadUser(email);

                    string storedName = "";

                    if (role == "Company" || role == "Admin")
                    {
                        storedName = _user.CompanyName;
                    }
                    else
                    {
                        storedName = _user.FirstName + " " + _user.LastName;
                    }

                    if (_user != null && storedName.Equals(name) && 
                        _user.Role.Equals(role) && _user.Email.Equals(email))
                    {
                        identity = new ClaimsIdentity(new[]
                        {
                            new Claim(ClaimTypes.Name, name),
                            new Claim(ClaimTypes.Role, role),
                            new Claim(ClaimTypes.Email, email),
                        }, "auth_type");
                    }
                    else
                    {
                        UnsetAuthenticationState();
                    }
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
        public void SetAuthenticationState(string name, string role, string email)
        {
            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, name),
                new Claim(ClaimTypes.Role, role),
                new Claim(ClaimTypes.Email, email),
            }, "auth_type");

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
