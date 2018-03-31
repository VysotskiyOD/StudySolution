using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Person
    {
        private string email;
        public string Name { get; set; } = "";
        public string SecondName { get; set; } = "";
        public string Email {
            set
            {
                if (value.Contains("@"))
                {
                    email = value;
                }
                else
                {
                    Console.WriteLine("Email должен иметь @");
                }
            }
            get { return email; } }
        public string Skype { get; set; } = "";
        public int Phone { get; set; }

        public Person() { }
        public Person(string name, string secondname)
        {
            Name = name;
            SecondName = secondname;
        }
        public Person(string name, string secondname, string email)
        {
            Name = name;
            SecondName = secondname;
            Email = email;
        }
        public Person(string name, string secondname, string email, string skype)
        {
            Name = name;
            SecondName = secondname;
            Email = email;
            Skype = skype;
        }
        public Person(string name, string secondname, string email, string skype, int phone)
        {
            Name = name;
            SecondName = secondname;
            Email = email;
            Skype = skype;
            Phone = phone;
        }
    }
}
