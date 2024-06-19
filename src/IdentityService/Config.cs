using Duende.IdentityServer.Models;

namespace IdentityService;

public static class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
        };

    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
        {
            new ApiScope("auctionApp", "Auction app full access"),
            new ApiScope("dis_api", "DIS API full access"),
        };

    public static IEnumerable<Client> Clients =>
        new Client[]
        {
            new Client
            {
                ClientId = "postman",
                ClientName = "Postman",
                AllowedScopes = {"openid", "profile", "auctionApp"},
                RedirectUris = {"https://www.getpostman.com/oauth2/callback"},
                ClientSecrets = new[] {new Secret("NotASecret".Sha256())},
                AllowedGrantTypes = {GrantType.ResourceOwnerPassword}
            },
            new Client
            {
                ClientId = "nextApp",
                ClientName = "nextApp",
                ClientSecrets = {new Secret("secret".Sha256())},
                AllowedGrantTypes = GrantTypes.CodeAndClientCredentials, // dido: maybe we will need to use GrandTypes.Code + RequiredPkce = true
                RequirePkce = false,
                RedirectUris = {"http://localhost:3000/api/auth/callback/id-server"},
                AllowOfflineAccess = true,
                AllowedScopes = {"openid", "profile", "auctionApp"},
                AccessTokenLifetime = 3600*24*30,
                AlwaysIncludeUserClaimsInIdToken = true,
            },
            new Client
            {
                ClientId = "dis_postman",
                ClientName = "dis_postman",
                AllowedScopes = {"openid", "profile", "dis_api"},
                RedirectUris = {"https://www.getpostman.com/oauth2/callback"},
                ClientSecrets = new[] {new Secret("NotASecret".Sha256())},
                AllowedGrantTypes = {GrantType.ResourceOwnerPassword}
            },
            new Client
            {
                ClientId = "dis_ui_localhost",
                ClientName = "dis_ui_localhost",
                RequireClientSecret = false,
                AllowedGrantTypes = GrantTypes.Code,
                RedirectUris = {"http://localhost:3000/callback"},
                PostLogoutRedirectUris = {"http://localhost:3000/signout-callback-oidc"},
                AllowedCorsOrigins = {"http://localhost:3000"},
                AllowedScopes = {"openid", "profile", "dis_api"},
                AccessTokenLifetime = 3600*24*30,
                AlwaysIncludeUserClaimsInIdToken = true,
            },
            new Client
            {
                ClientId = "dis_ui_dev",
                ClientName = "dis_ui_dev",
                RequireClientSecret = false,
                AllowedGrantTypes = GrantTypes.Code,
                RedirectUris = {"https://dis-dev.milestonesys.xyz/callback"},
                PostLogoutRedirectUris = {"https://dis-dev.milestonesys.xyz/signout-callback-oidc"},
                AllowedCorsOrigins = {"https://dis-dev.milestonesys.xyz"},
                AllowedScopes = {"openid", "profile", "dis_api"},
                AccessTokenLifetime = 3600*24*30,
                AlwaysIncludeUserClaimsInIdToken = true,
            }
        };
}
