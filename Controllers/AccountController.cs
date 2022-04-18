using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Northwind.Models;
using System;
using System.Net;
using System.Net.Mail;

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

        // public ActionResult ForgotPassword()
        // {
        //     return View();
        // }
        // [HttpPost]
        // public ActionResult ForgotPassword(ForgotPasswordViewModel model)
        // {
        //     string to = "ryanj34521@gmail.com"; //To address    
        //     string from = "northwindfp.help@gmail.com"; //From address    
        //     MailMessage message = new MailMessage(from, to);

        //     string mailbody = "Click this link to reset your password: ";
        //     message.Subject = "Reset Password";
        //     message.Body = mailbody;
        //     // message.BodyEncoding = Encoding.UTF8;  
        //     message.IsBodyHtml = true;
        //     SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
        //     System.Net.NetworkCredential basicCredential1 = new
        //     System.Net.NetworkCredential("northwindfp.help@gmail.com", "Qc#rXTVF6@2WNpf");
        //     client.EnableSsl = true;
        //     client.UseDefaultCredentials = false;
        //     client.Credentials = basicCredential1;
        //     try
        //     {
        //         client.Send(message);
        //     }
        //     catch (Exception Ex)
        //     {
        //         throw Ex;
        //     }

        //     return View();
        // }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ForgotPassword(ForgotPasswordModel model)
        {
            if (ModelState.IsValid)
            {
            //Send Email
            MailMessage Msg = new MailMessage();
            Msg.From = new MailAddress("northwindfp.help@gmail.com","Northwind");// replace with valid value
            Msg.Subject = "Reset Password";
            Msg.To.Add(model.Email); //replace with correct values
            Msg.Body = "Click this link to reset your password: ";
            Msg.IsBodyHtml = true;
            Msg.Priority = MailPriority.High;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("northwindfp.help@gmail.com", "Qc#rXTVF6@2WNpf");// replace with valid value
            smtp.EnableSsl = true;
            smtp.Timeout = 20000;

            smtp.Send(Msg);
            return RedirectToAction("Login");
            }
            
            return View(model);
        }

        public ViewResult AccessDenied() => View();
    }
}