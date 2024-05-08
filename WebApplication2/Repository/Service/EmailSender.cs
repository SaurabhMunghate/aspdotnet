using Microsoft.AspNetCore.Identity.UI.Services;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mail;
using WebApplication2.ViewModel;

namespace WebApplication2.Repository.Service
{
    public class EmailSender : IEmailSender
    {

        private readonly IConfiguration configuration;

        public EmailSender(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        async Task IEmailSender.SendEmailAsync(string email, string subject, string message)
        {
            try{

                GetEmailSetting getEmailSetting = new GetEmailSetting()
                {
                    SecretKey = configuration.GetValue<string>("AppSettings.SecretKey"),
                    From = configuration.GetValue<string>("AppSettings.EmailSetting.From"),
                    SmtpServer = configuration.GetValue<string>("AppSettings.EmailSetting.SmtpServer"),
                    Port = configuration.GetValue<int>("AppSettings.EmailSetting.Port"),
                    EnableSSL = configuration.GetValue<bool>("AppSettings.EmailSetting.EnableSSL")
                };

            MailMessage mailMessage = new MailMessage()
            {
                From = new MailAddress(getEmailSetting.From),
                Subject = subject,
                Body = message
            };
                mailMessage.To.Add(email);
                SmtpClient smtpClient = new SmtpClient(getEmailSetting.SmtpServer)
                {
                    Port = getEmailSetting.Port,
                    Credentials = new NetworkCredential(getEmailSetting.From, getEmailSetting.SecretKey),
                    EnableSsl = getEmailSetting.EnableSSL
                };
                await smtpClient.SendMailAsync(mailMessage);
           
            }
            catch(Exception){
                throw;
            }
            throw new NotImplementedException();
        }
    }
}
