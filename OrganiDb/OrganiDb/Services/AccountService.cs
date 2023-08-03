using Microsoft.AspNetCore.Identity;
using Org.BouncyCastle.Asn1.Ocsp;
using OrganiDb.Helpers;
using OrganiDb.Models;
using OrganiDb.Services.Interfaces;
using OrganiDb.ViewModels.Account;
using System.Data;

namespace OrganiDb.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public async Task AddToRoleAsync(AppUser user, string role)
        {
            await _userManager.AddToRoleAsync(user, role);
        }

        public async Task ConfirmEmailAsync(AppUser user, string token)
        {
            await _userManager.ConfirmEmailAsync(user, token);
        }

        public async Task<IdentityResult> CreateUserAsync(AppUser user, string password)
        {
          
            return await _userManager.CreateAsync(user, password);
        }

        public async Task CreateRoleAsync(string role)
        {
            await _roleManager.CreateAsync(new IdentityRole { Name = role});
        }

        public async Task<AppUser> FindByEmailAsync(string usernameOrEmail)
        {
            return await _userManager.FindByEmailAsync(usernameOrEmail);
        }

        public async Task<AppUser> FindByIdAsync(string userId)
        {
            return await _userManager.FindByIdAsync(userId);
        }

        public async Task<AppUser> FindByNameAsync(string usernameOrEmail)
        {
            return await _userManager.FindByNameAsync(usernameOrEmail);
        }

        public async Task<string> GenerateEmailConfirmationTokenAsync(AppUser user)
        {
            return await _userManager.GenerateEmailConfirmationTokenAsync(user);
        }

        public async Task<string> GeneratePasswordResetTokenAsync(AppUser user)
        {
            return await _userManager.GeneratePasswordResetTokenAsync(user);
        }

        public async Task<SignInResult> PasswordSignInAsync(AppUser user, string password, bool isPersistent, bool lockOutOnFailure)
        {
            return await _signInManager.PasswordSignInAsync(user, password, isPersistent, lockOutOnFailure);
        }

        public async Task ResetPasswordAsync(AppUser user, string token, string newPassword)
        {
            await _userManager.ResetPasswordAsync(user, token, newPassword);
        }

        public async Task<bool> RoleExistsAsync(string roleName)
        {
            return await _roleManager.RoleExistsAsync(roleName);
        }

        public async Task SignInAsync(AppUser user, bool isPersistent)
        {
            await _signInManager.SignInAsync(user, false);
        }

        public async Task SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public PasswordVerificationResult VerifyHashedPassword(AppUser user, string passwordHash, string password)
        {
            return _userManager.PasswordHasher.VerifyHashedPassword(user, passwordHash, password);
        }
    }
}
