using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Person
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public string Skype { get; set; }
        public string Phone { get; set; }

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
        public Person(string name, string secondname, string email, string phone)
        {
            Name = name;
            SecondName = secondname;
            Email = email;
            Phone = phone;
        }
        public Person(string name, string secondname, string email, string phone, string skype)
        {
            Name = name;
            SecondName = secondname;
            Email = email;
            Skype = skype;
            Phone = phone;
        }
    }
}
