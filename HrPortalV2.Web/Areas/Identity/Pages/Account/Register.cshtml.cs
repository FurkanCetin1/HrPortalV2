﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HrPortalV2.Web.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<HrPortalV2.Models.ApplicationUser> _signInManager;
        private readonly UserManager<HrPortalV2.Models.ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<HrPortalV2.Models.ApplicationUser> userManager,
            SignInManager<HrPortalV2.Models.ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            public InputModel()
            {
                Role = "Candidate";
            }
            [Required(ErrorMessage = "E-posta Girilmesi zorunludur.")]
            [EmailAddress]
            [Display(Name = "E-posta")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Parola oluşturulması zorunludur.")]
            [StringLength(100, ErrorMessage = "{0} alanı en az {2} ve en fazla {1} karakter uzunluğunda olmalıdır.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Parola")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Parola Doğrula")]
            [Compare("Password", ErrorMessage = "Parola ve Parola Doğrulaması eşleşmiyor")]
            public string ConfirmPassword { get; set; }
            [Display(Name = "Rol")]
            public string Role { get; set; }
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)
            {
                var user = new HrPortalV2.Models.ApplicationUser { UserName = Input.Email, Email = Input.Email };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("Kullanıcı Parola ile yeni bir hesap oluşturdu.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { userId = user.Id, code = code },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "E-postanızı doğrulayın",
                        $"<div style='text-align:center'><img src='http://demo.bilisimkariyer.net/images/logo_bilisimkariyer.png' /><br />Lütfen hesabınızı doğrulayın <a href='{HtmlEncoder.Default.Encode(callbackUrl)} '>buraya tıklayarak</a>.</div>");
                    
                    if (Input.Role == "Company") { 
                        await _userManager.AddToRoleAsync(user, "Company");
                    } else
                    {
                        await _userManager.AddToRoleAsync(user, "Candidate");
                    }
                    //await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect("~/Identity/Account/ConfirmSent");
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
