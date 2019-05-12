using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using App.Data.Domain.DomainModels.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using App.Data.Context;
using App.Data.Domain.DomainModels.Concrete;
using App.Services.Interfaces.IServices;
using App.Services.Dtos.DTOs.Intern;
using App.Services.Dtos.DTOs.Menthor;

namespace App.Web.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly MyAppContext _context;
        private readonly IUserService _userService;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            MyAppContext context,
            IUserService userService,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _userService = userService;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required]
            public string FirstName { get; set; }

            [Required]
            public string LastName { get; set; }

            [Required]
            [DataType(DataType.Date)]
            public DateTime DateOfBirth { get; set; }

            [Required]
            public string PhoenNumber { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [Required]
            public string Role { get; set; }
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/Home/Index");
            if (ModelState.IsValid)
            {
                //var user = new User
                //{
                //    UserName = Input.Email,
                //    Email = Input.Email,
                //    FirstName = Input.FirstName,
                //    LastName = Input.LastName,
                //    PhoneNumber = Input.PhoenNumber,
                //    DateOfBirth = Input.DateOfBirth
                //};
                var user = new User()
                {
                    UserName = Input.Email,
                    Email = Input.Email,
                    FirstName = Input.FirstName,
                    LastName = Input.LastName,
                    PhoneNumber = Input.PhoenNumber,
                    DateOfBirth = Input.DateOfBirth
                };

                IdentityResult result;
                //using (var transaction = _context.Database.BeginTransaction())
                //{
                //    try
                //    {
                        result = await _userManager.CreateAsync(user, Input.Password);
                        //await _userManager.AddToRoleAsync(user, Input.Role);
                        //switch (Input.Role)
                        //{
                        //    case "Menthor": { _userService.AddMenthor(new MenthorDto() { UserId = user.Id }); } break;
                        //    case "Intern": { _userService.AddIntern(new InternDto() { UserId = user.Id }); } break;
                        //    case "Admin": break;
                        //    default: throw new Exception();
                        //}
                    //    transaction.Commit();
                    //}
                    //catch (Exception)
                    //{
                    //    transaction.Rollback();
                    //    throw new Exception();
                    //    // TODO: Handle failure
                    //}
                //}

                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { userId = user.Id, code = code },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");
                    ///
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
