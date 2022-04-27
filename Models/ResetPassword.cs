using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
 
namespace Northwind.Models
{
    /*
    The HTTP GET version of ResetPassword action method gets called when the user clicks on the reset password link on his/her email. 
    The work of this action method is to grab the token and email address and bind them to the view.
    Next, the user adds the new password and confirm password on the View (ResetPassword.cshtml) and 
    click the button to save it. This calls the HTTP POST version of ResetPassword action method. 
    This action method gets new password, user email and token through the ResetPassword model calls which is provided in it’s parameter.
    */
    public class ResetPassword
    {
        [Required]
        public string Password { get; set; }
 
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
 
        public string Email { get; set; }
        public string Token { get; set; }
    }
}