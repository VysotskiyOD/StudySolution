using NotifactionSender;
using Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileWriter;
using System.Net.Mail;
using System.Net;

namespace NotificationApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> contactBook = new List<Person>();
            contactBook.Add(new Person("Oleg", "Vysotskiy", "tauro2005@ukr.net", "0672200521"));
            contactBook.Add(new Person("Lera", "Vysotska", "vysotskavv@gmail.com", "0672200521"));
            var email = from em in contactBook select em.Email;

            MailAddress from = new MailAddress("vysotskiyod@gmail.com", "Oleg");
            
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("vysotskiyod", "19051985");
            smtp.EnableSsl = true;

            foreach (var i in email)
            {
                ISender sender = new ConsoleSender();
                sender.Send("Some message " + i);

                var sender2 = new EmailSender.EmailSender();
                MailAddress to = new MailAddress(i);
                MailMessage m = new MailMessage(from, to);
                m.Subject = "Тест";

                sender2.SetEmailProviderInfo(m, smtp);
                string wrMess;
                wrMess = Console.ReadLine();
                sender2.Send(wrMess);

                FileWriter.FileWriter fwm = new FileWriter.FileWriter();
                fwm.Send(wrMess);

            }


            Console.ReadLine();
        }
    }
}
