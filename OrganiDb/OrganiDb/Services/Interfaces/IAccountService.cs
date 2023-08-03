using Microsoft.AspNetCore.Identity;
using OrganiDb.Models;
using OrganiDb.ViewModels.Account;

namespace OrganiDb.Services.Interfaces
{
    public interface IAccountService
    {
        Task<IdentityResult> CreateUserAsync(AppUser user, string password);
        Task CreateRoleAsync(string role);
        Task AddToRoleAsync(AppUser user, string role);
        Task<string> GenerateEmailConfirmationTokenAsync(AppUser user);
        Task <AppUser> FindByIdAsync(string userId);
        Task<AppUser> FindByNameAsync(string usernameOrEmail);
        Task<AppUser> FindByEmailAsync(string usernameOrEmail);
        Task ConfirmEmailAsync(AppUser user, string token);
        Task SignInAsync(AppUser user, bool isPersistent);
        PasswordVerificationResult VerifyHashedPassword(AppUser user, string passwordHash, string password);
        Task<SignInResult> PasswordSignInAsync(AppUser user, string password, bool isPersistent, bool lockOutOnFailure );
        Task SignOutAsync();
        Task <string> GeneratePasswordResetTokenAsync(AppUser user);
        Task ResetPasswordAsync(AppUser user, string token, string newPassword);
        Task <bool> RoleExistsAsync(string roleName);
    }
}
