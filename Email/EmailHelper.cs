using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
 
namespace Identity.Email
{
    public class EmailHelper
    {
        
        /*
        When the user clicks the link on the password reset email then he/she is taken to the page where he/she can create the new password.

        The link directs users to the ResetPassword action of Account controller. 
        So add ResetPassword action along with another action called ResetPasswordConfirmation to the Account controller. 
        Their codes are given below.
        */
        public bool SendEmailPasswordReset(string userEmail, string link)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("northwindfp.help@gmail.com");
            mailMessage.To.Add(new MailAddress(userEmail));
 
            mailMessage.Subject = "Password Reset";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = link;
            //mailMessage.Body = "wtf man";
 
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("northwindfp.help@gmail.com", "Qc#rXTVF6@2WNpf");
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.Timeout = 20000;
            mailMessage.Priority = MailPriority.High;
            try
            {
                client.Send(mailMessage);
                return true;
            }
            catch (Exception ex)
            {
                // log exception
                Console.WriteLine(ex);
            }
            return false;
        }
    }
}