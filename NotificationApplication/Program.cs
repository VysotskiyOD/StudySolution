using NotifactionSender;
using Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileWrite;

namespace NotificationApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] contactBook = new[] {
            new Person { Name="Oleg", SecondName="Vysotskiy", Email="tauro2005@ukr.net", Phone=0672200521},
            new Person { Name="Lera", SecondName="Vysotska", Email="vysotskavv@gmail.com", Phone=0672200521},
            };
            var email = from em in contactBook select em.Email;
            foreach (var i in email)
            {
                ISender sender = new ConsoleSender();
                sender.Send("Some message "+i);

                var sender2 = new EmailSender.EmailSender();
                string wrMess;
                wrMess = Console.ReadLine();
                sender2.Send(wrMess, i);

                fileWriteMassage fwm = new fileWriteMassage();
                fwm.Send(wrMess);
                


            }
           // ISender sender = new ConsoleSender();
            //sender.Send("Some message");

          
            Console.ReadLine();
        }
    }
}
