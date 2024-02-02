// This C# file makes use of the user & roles tables to create a role claim for every user,
// making the authentication modules that use Roles functional.
using System.Linq;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication.Internal;

public class CustomUserFactory
    : AccountClaimsPrincipalFactory<RemoteUserAccount>
{
    // Constructor to initialize the CustomUserFactory with the IAccessTokenProviderAccessor
    public CustomUserFactory(IAccessTokenProviderAccessor accessor)
        : base(accessor)
    {
    }

    // Override method to create a custom ClaimsPrincipal for the user
    public override async ValueTask<ClaimsPrincipal> CreateUserAsync(
        RemoteUserAccount account,
        RemoteAuthenticationUserOptions options)
    {
        // This creates the base user using the base class method
        var user = await base.CreateUserAsync(account, options);

        // This checks if the user is authenticated
        if (user.Identity.IsAuthenticated)
        {
            // Extract the claims identity from the user
            var identity = (ClaimsIdentity)user.Identity;

            // Find all role claims and remove them
            var roleClaims = identity.FindAll(identity.RoleClaimType).ToArray();

            if (roleClaims.Any())
            {
                foreach (var existingClaim in roleClaims)
                {
                    identity.RemoveClaim(existingClaim);
                }

                // Extract roles from the additional properties of the account
                var rolesElem = account.AdditionalProperties[identity.RoleClaimType];

                if (rolesElem is JsonElement roles)
                {
                    // This adds roles as claims to the identity (makes role & user seed configs functional)
                    if (roles.ValueKind == JsonValueKind.Array)
                    {
                        foreach (var role in roles.EnumerateArray())
                        {
                            identity.AddClaim(new Claim(options.RoleClaim, role.GetString()));
                        }
                    }
                    else
                    {
                        identity.AddClaim(new Claim(options.RoleClaim, roles.GetString()));
                    }
                }
            }
        }

        // Return the modified user with custom claims
        return user;
    }
}