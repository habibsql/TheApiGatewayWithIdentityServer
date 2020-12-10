namespace AuthServer
{
    using IdentityServer4.Models;
    using IdentityServer4.Test;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;

    public static class Config
    {

        public static IEnumerable<TestUser> GetActiveUsers()
        {
            return new List<TestUser> {
                new TestUser {
                    SubjectId = "5BE86359-073C-434B-AD2D-A3932222DABE",
                    Username = "scott",
                    Password = "password"
                }
            };
        }

        public static IEnumerable<Client> GetActiveClients()
        {
            return new[]
            {
                new Client {
                    RequireConsent = false,
                    ClientId = "client1",
                    ClientName = "client1",
                    ClientSecrets ={ new Secret{Value = "s".Sha256()} },
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                    AllowedScopes = new List<string>() { "api1" },
                    AllowAccessTokensViaBrowser = true,
                    AccessTokenLifetime = 36000,
                    AccessTokenType = AccessTokenType.Jwt,
                    Enabled = true,
                    //RequireClientSecret = false,
                    AllowOfflineAccess = true
                }
            };
        }

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Email(),
                new IdentityResources.Profile(),
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("api100", "Resource API")
                {
                    Scopes = {
                       "api1"
                    }
                }
            };
        }

        public static IEnumerable<ApiScope> ApiScopes =>
            new List<ApiScope>
            {
            new ApiScope("api1", "api1")
            };

        public static class Roles
        {
            public const string Consumer = "consumer";
        }

    }
}
