using LeaveManagementTest.Constants;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;

namespace LeaveManagementTest.Services
{
    public class EmailSender : IEmailSender
    {
        private string _hostName;
        private int _hostPort;
        private string _noReplyEmail;

        public EmailSender(string hostName, int hostPort, string noReplyEmail)
        {
            this._hostName = hostName;
            this._hostPort = hostPort;
            this._noReplyEmail = noReplyEmail;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MailMessage
            {
                From = new MailAddress(Email.NoReplyEmail),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };

            message.To.Add(new MailAddress(email));
            message.Bcc.Add(new MailAddress(email));

            using var client = new SmtpClient(_hostName, _hostPort);
            client.Send(message);

            return Task.CompletedTask;
        }
    }
}
