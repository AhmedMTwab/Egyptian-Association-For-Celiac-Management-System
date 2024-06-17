using Castle.Core.Smtp;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.Net;
using System.Net.Mail;

namespace Egyptian_association_of_cieliac_patients.IdentityModels
{
    public class EmailConfirm 
    {
        public void Send(string email, string subject, string ConfirmLink)
        {
            var fMail = "am4752714@gmail.com";
            var fPassword = "New@dmin10";

            var theMsg = new MailMessage();
            theMsg.From = new MailAddress(fMail);
            theMsg.Subject = subject;
            theMsg.To.Add(email);
            theMsg.Body = $"<html><body>{ConfirmLink}</body></html>";
            theMsg.IsBodyHtml = true;

            var smtpClint = new SmtpClient("smtp-mail.outlook.com")
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(fMail, fPassword),
                Port = 587
            };

            smtpClint.Send(theMsg);
        }

        public void Send(MailMessage message)
        {
            throw new NotImplementedException();
        }

        public void Send(IEnumerable<MailMessage> messages)
        {
            throw new NotImplementedException();
        }
    }
}
