using MailKit.Security;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit.Text;
using MimeKit;
using OrganiDb.Models;
using OrganiDb.ViewModels.Account;
using MailKit.Net.Smtp;
using OrganiDb.Helpers;
using OrganiDb.Services;
using OrganiDb.Services.Interfaces;

namespace OrganiDb.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IEmailService _emailService;

        public AccountController(IAccountService accountService, IEmailService emailService)
        {
            _accountService = accountService;
            _emailService = emailService;
        }
       
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            AppUser user = new()
            {
                Name = request.Name,
                Surname = request.Surname,
                UserName = request.Username,
                Email = request.Email,
            };

            var userResult = await _accountService.CreateUserAsync(user, request.Password);

            if (!userResult.Succeeded)
            {
                foreach (var error in userResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                    return View();
                }
            }

            await _accountService.AddToRoleAsync(user, Roles.Member.ToString());

            string token = await _accountService.GenerateEmailConfirmationTokenAsync(user);

            string link = Url.Action("ConfirmEmail", "Account", new { UserId = user.Id, Token = token }, Request.Scheme);

            string html = "";

            using StreamReader reader = new("wwwroot/assets/templates/email-confirmation.html");

            html = reader.ReadToEnd();

            html = html.Replace("{{link}}",link);
            html = html.Replace("{{name}} {{surname}}", "Ramil Allahverdiyev");

            string subject = "Email Confirmation";

            _emailService.SendEmail(user.Email, subject, html);

            return RedirectToAction(nameof(VerifyEmail));
        }

        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null) return BadRequest();

            AppUser user = await _accountService.FindByIdAsync(userId); 

            if (user == null) return NotFound();

            await _accountService.ConfirmEmailAsync(user, token);

            await _accountService.SignInAsync(user, false);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult VerifyEmail()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            AppUser user = await _accountService.FindByNameAsync(request.UsernameOrEmail);

            if (user == null)
            {
                user = await _accountService.FindByEmailAsync(request.UsernameOrEmail);
            }

            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Email or password is wrong.");
                return View();
            }

            PasswordVerificationResult comparePassword = _accountService.VerifyHashedPassword(user, user.PasswordHash, request.Password);

            if (comparePassword.ToString() == "Failed")
            {
                ModelState.AddModelError(string.Empty, "Email or password is wrong.");
                return View();
            }


            var result = await _accountService.PasswordSignInAsync(user, request.Password, false, false);

            if (result.IsNotAllowed)
            {
                ModelState.AddModelError(string.Empty, "Please confirm your account");
                return View();
            }

            return RedirectToAction("Index","Home");
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _accountService.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordVM request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            AppUser user = await _accountService.FindByEmailAsync(request.Email);

            if (user == null) return NotFound();

            string token = await _accountService.GeneratePasswordResetTokenAsync(user);

            string link = Url.Action("ResetPassword", "Account", new { UserId = user.Id, Token = token }, Request.Scheme);

            string html = "";

            using StreamReader reader = new("wwwroot/assets/templates/forgot-password.html");

            html = reader.ReadToEnd();

            html = html.Replace("{{link}}", link);
            html = html.Replace("{{name}} {{surname}}", "Ramil Allahverdiyev");

            string subject = "Reset Password";

            _emailService.SendEmail(user.Email, subject, html);

            return RedirectToAction(nameof(VerifyEmail));
        }

        [HttpGet]
        public IActionResult ResetPassword(string userId, string token)
        {
            if (userId == null || token == null) return BadRequest();

            return View(new ResetPasswordVM { UserId = userId, Token = token });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            AppUser user = await _accountService.FindByIdAsync(request.UserId);

            if (user == null) return NotFound();

            await _accountService.ResetPasswordAsync(user, request.Token, request.NewPassword);

            return RedirectToAction(nameof(Login));
        }

        [HttpGet]
        public async Task<IActionResult> CreateRoles()
        {
            foreach (var role in Enum.GetValues(typeof(Roles)))
            {
                var roleResult = await _accountService.RoleExistsAsync(role.ToString());

                if (!roleResult)
                {
                   await _accountService.CreateRoleAsync(role.ToString());
                }
            }

            return Ok();
        }
    }
}
