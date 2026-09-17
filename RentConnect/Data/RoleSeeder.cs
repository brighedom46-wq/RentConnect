using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace RentConnect.Data;

public static class RoleSeeder
{
    public static async Task SeedAsync(IServiceProvider services)
    {
        using var scope = services.CreateScope();

        var roleManager =
            scope.ServiceProvider
                .GetRequiredService<RoleManager<IdentityRole>>();

        var userManager =
            scope.ServiceProvider
                .GetRequiredService<UserManager<ApplicationUser>>();

        string[] roles = ["Landlord", "Renter"];

        foreach (string roleName in roles)
        {
            if (!await roleManager.RoleExistsAsync(roleName))
            {
                await roleManager.CreateAsync(
                    new IdentityRole(roleName));
            }
        }

        const string landlordEmail =
            "brightedom215@gmail.com";

        var landlord =
            await userManager.FindByEmailAsync(landlordEmail);

        if (landlord is not null)
        {
            if (!await userManager.IsInRoleAsync(
                    landlord, "Landlord"))
            {
                await userManager.AddToRoleAsync(
                    landlord, "Landlord");
            }

            if (await userManager.IsInRoleAsync(
                    landlord, "Renter"))
            {
                await userManager.RemoveFromRoleAsync(
                    landlord, "Renter");
            }
        }

        var users = await userManager.Users.ToListAsync();

        foreach (var user in users)
        {
            bool isLandlord = string.Equals(
                user.Email,
                landlordEmail,
                StringComparison.OrdinalIgnoreCase);

            if (!isLandlord &&
                !await userManager.IsInRoleAsync(user, "Renter"))
            {
                await userManager.AddToRoleAsync(
                    user, "Renter");
            }
        }
    }
}