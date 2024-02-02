using System.Data;
using System.Security.Claims;
using System.Text.Json;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication.Internal;

// Reference: https://learn.microsoft.com/en-us/aspnet/core/blazor/security/webassembly/hosted-with-identity-server

/* Identity Server sends a JSON array of multiple roles as a single role claim in String format.
   CustomUserFactory will create individual role claims for each of the user's roles. */
public class CustomUserFactory : AccountClaimsPrincipalFactory<RemoteUserAccount>
{
    // Constructor that takes an IAccessTokenProviderAccessor as a parameter
    public CustomUserFactory(IAccessTokenProviderAccessor accessor) : base(accessor)
    {
    }

    // Override method to create a ClaimsPrincipal based on the provided RemoteUserAccount & RemoteAuthenticationUserOptions
    public override async ValueTask<ClaimsPrincipal> CreateUserAsync(RemoteUserAccount account, RemoteAuthenticationUserOptions options)
    {
        // Create the user from the provided parameters
        var user = await base.CreateUserAsync(account, options);

        // If the user is authenticated
        if (user.Identity is not null && user.Identity.IsAuthenticated)
        {
            // Get the user's identity as ClaimsIdentity
            var identity = (ClaimsIdentity)user.Identity;

            // Get all the user's existing role claims as an array
            var roleClaims = identity.FindAll(identity.RoleClaimType).ToArray();

            // If the user has existing role claims
            if (roleClaims.Any())
            {
                // Remove all the existing role claims
                foreach (var existingClaim in roleClaims)
                {
                    identity.RemoveClaim(existingClaim);
                }

                // Access the roles from the user account
                var rolesElem = account.AdditionalProperties[identity.RoleClaimType];

                // If the role claim is not null & the roles is a JsonElement
                if (options.RoleClaim is not null && rolesElem is JsonElement roles)
                {
                    // If the roles are provided as a JSON array
                    if (roles.ValueKind == JsonValueKind.Array)
                    {
                        // Iterate through each role in the array & add it as a separate role claim
                        foreach (var role in roles.EnumerateArray())
                        {
                            var roleValue = role.GetString();

                            if (!string.IsNullOrEmpty(roleValue))
                            {
                                identity.AddClaim(new Claim(options.RoleClaim, roleValue));
                            }
                        }
                    }
                    // If roles are not provided as a JSON array, add the single role as a claim
                    else
                    {
                        var roleValue = roles.GetString();

                        if (!string.IsNullOrEmpty(roleValue))
                        {
                            identity.AddClaim(new Claim(options.RoleClaim, roleValue));
                        }
                    }
                }
            }
        }
        // Return the user with updated claims
        return user;
    }
}