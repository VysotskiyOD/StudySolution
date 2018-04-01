using NotifactionSender;
using System.Net;
using System.Net.Mail;
using Persons;

namespace EmailSender
{
    public class EmailSender : ISender
    {
        private MailMessage _mailMessage;
        private SmtpClient _smtpClient;

        public void SetEmailProviderInfo(MailMessage mailMessage, SmtpClient smtpClient)
        {
            _mailMessage = mailMessage;
            _smtpClient = smtpClient;
        }

        public void Send(string message)
        {
            string st = "<h2>" + message + "</h2>";
            _mailMessage.Body = st;
            _mailMessage.IsBodyHtml = true;

            _smtpClient.Send(_mailMessage);
        }
    }
}
  