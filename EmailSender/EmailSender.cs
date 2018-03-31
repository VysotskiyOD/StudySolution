using NotifactionSender;
using System.Net;
using System.Net.Mail;
using Persons;

namespace EmailSender
{
    public class EmailSender : ISender
    {
        public void Send(string Message)
        {
            MailAddress from = new MailAddress("vysotskiyod@gmail.com", "Oleg");
            MailAddress to = new MailAddress("tauro2005@ukr.net");
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Тест";
            string st = "<h2>" + Message + "</h2>";
            m.Body = st;
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("vysotskiyod", "19051985");
            smtp.EnableSsl = true;
            smtp.Send(m);
            
        }
        public void Send(string Message, string emailTo)
        {
            MailAddress from = new MailAddress("vysotskiyod@gmail.com", "Oleg");
            MailAddress to = new MailAddress(emailTo);
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Тест";
            string st = "<h2>" + Message + "</h2>";
            m.Body = st;
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("vysotskiyod", "19051985");
            smtp.EnableSsl = true;
            smtp.Send(m);

        }
    }
}
  