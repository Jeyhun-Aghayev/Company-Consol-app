using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp10
{
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }

        public string Password;
        public string Email { get; set; }


        public User(string Name, string Surname, string Username, string Password, string Email)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Username = Username;
            this.Password = Password;
            this.Email = Email;
        }


    }
}