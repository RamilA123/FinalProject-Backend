using MailKit.Security;
using MimeKit.Text;
using MimeKit;
using OrganiDb.Helpers;
using OrganiDb.Services.Interfaces;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;

namespace OrganiDb.Services
{
    public class EmailService : IEmailService
    {
        private readonly EmailConfigurations _emailConfigurations;

        public EmailService(IOptions<EmailConfigurations> emailConfigurations)
        {
            _emailConfigurations = emailConfigurations.Value;
        }

        public void SendEmail(string to, string subject, string html, string from = null)
        {
            // create message
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(from ?? _emailConfigurations.FromAddress));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = html };

            // send email
            using var smtp = new SmtpClient();
            smtp.Connect(_emailConfigurations.Host, 587, SecureSocketOptions.StartTls);
            smtp.Authenticate(_emailConfigurations.Username, _emailConfigurations.Password);
            smtp.Send(email);
            smtp.Disconnect(true);

        }
    }
}
