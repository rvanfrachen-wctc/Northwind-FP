using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Northwind.Models;
using System.ComponentModel.DataAnnotations;
using Identity.Email;
using System.Net.Mail;
using System.IO;

namespace Northwind.Controllers

{
    public class AccountController : Controller
    {
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userMgr, SignInManager<AppUser> signInMgr)
        {
            _userManager = userMgr;
            _signInManager = signInMgr;
        }
        public IActionResult Login(string returnUrl)
        {
            // return url remembers the user's original request
            ViewBag.returnUrl = returnUrl;
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel details, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                AppUser user = await _userManager.FindByEmailAsync(details.Email);
                if (user != null)
                {
                    await _signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, details.Password, false, false);
                    if (result.Succeeded)
                    {
                        return Redirect(returnUrl ?? "/");
                    }
                }
                ModelState.AddModelError(nameof(LoginModel.Email), "Invalid user or password");
            }
            return View(details);
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public ViewResult AccessDenied() => View();


         [AllowAnonymous]
        public IActionResult ForgotPassword()
        {
            return View();
        }
 
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ForgotPassword([Required]string email)
        {


            // MailMessage Msg = new MailMessage();
            // Msg.From = new MailAddress("northwindfp.help@gmail.com","Northwind");// replace with valid value
            // Msg.Subject = "Reset Password";
            // Msg.To.Add("andrewmgunn31@gmail.com"); //replace with correct values
            // //Msg.Body = "Click this link to reset your password: ";
            // Msg.IsBodyHtml = true;
            // Msg.Priority = MailPriority.High;
            // SmtpClient smtp = new SmtpClient();
            // smtp.Host = "smtp.gmail.com";
            // smtp.Port = 587;
            // smtp.Credentials = new System.Net.NetworkCredential("northwindfp.help@gmail.com", "Qc#rXTVF6@2WNpf");// replace with valid value
            // smtp.EnableSsl = true;
            // smtp.Timeout = 20000;


            if (!ModelState.IsValid)
                return View(email);
 
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                return RedirectToAction(nameof(ForgotPasswordConfirmation));

        
            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
         
            var link = Url.Action("ResetPassword", "Account", new { token, email = user.Email }, Request.Scheme);
            //  Msg.Body = "Click this link to reset your password: " + link;

            EmailHelper emailHelper = new EmailHelper();
            bool emailResponse = emailHelper.SendEmailPasswordReset(user.Email, link);
 
            if (emailResponse)
                return RedirectToAction("ForgotPasswordConfirmation");
            else
            {
                // log email failed 
            }

            // smtp.Send(Msg);
            //return RedirectToAction("Login");
            return View("ForgotPasswordConfirmation");
        }
 
        [AllowAnonymous]
        public IActionResult ForgotPasswordConfirmation()
        {
            return View();
        }

         [AllowAnonymous]
        public IActionResult ResetPassword(string token, string email)
        {
            var model = new ResetPassword { Token = token, Email = email };
            return View(model);
        }
 
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ResetPassword(ResetPassword resetPassword)
        {
            if (!ModelState.IsValid)
                return View(resetPassword);

            AppUser user = await _userManager.FindByEmailAsync(resetPassword.Email);
            // AppUser user = await _userManager.FindByEmailAsync(details.Email);

            // var user = _userManager.FindByEmailAsync(resetPassword.Email);
            if (user == null)
                RedirectToAction("ResetPasswordConfirmation");
 
            var resetPassResult = await _userManager.ResetPasswordAsync(user, resetPassword.Token, resetPassword.Password);
            if (!resetPassResult.Succeeded)
            {
                foreach (var error in resetPassResult.Errors)
                    ModelState.AddModelError(error.Code, error.Description);
                return View();
            }
 
            return RedirectToAction("ResetPasswordConfirmation");
        }
 
        public IActionResult ResetPasswordConfirmation()
        {
            return View();
        }


        // /* RYANS */
        //  [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<ActionResult> ForgotPassword222(ForgotPasswordModel model)
        // {
        //     if (ModelState.IsValid)
        //     {
        //     //Send Email
        //     MailMessage Msg = new MailMessage();
        //     Msg.From = new MailAddress("northwindfp.help@gmail.com","Northwind");// replace with valid value
        //     Msg.Subject = "Reset Password";
        //     Msg.To.Add(model.Email); //replace with correct values
        //     Msg.Body = "Click this link to reset your password: ";
        //     Msg.IsBodyHtml = true;
        //     Msg.Priority = MailPriority.High;
        //     SmtpClient smtp = new SmtpClient();
        //     smtp.Host = "smtp.gmail.com";
        //     smtp.Port = 587;
        //     smtp.Credentials = new System.Net.NetworkCredential("northwindfp.help@gmail.com", "Qc#rXTVF6@2WNpf");// replace with valid value
        //     smtp.EnableSsl = true;
        //     smtp.Timeout = 20000;

        //     smtp.Send(Msg);
        //     return RedirectToAction("Login");
        //     }
            
        //     return View(model);
        // }
    }
}