using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp10
{
    public class Company
    {
        public string Name;
        User[] users = new User[0];
        bool IsValidPassword(string password)
        {    
                string pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{8,}$";
                return Regex.IsMatch(password, pattern);
        }    
        
        public void Register(string Name, string Surname)
        {
            
            while (true)
            {
                Console.WriteLine("Zehmet olmasa passwordu  girin");
            Pass:
                string Password = Console.ReadLine();
                if (IsValidPassword(Password))
                {
                    string Email = Name + "." + Surname + "@gmail.com";
                    string Username = Name + "." + Surname;
                    User user = new User(Name, Surname, Username, Password, Email);
                    Array.Resize(ref users, users.Length + 1);
                    users[users.Length - 1] = user;
                    Console.WriteLine($"register: {user.Username}");
                    break;
                }
                else
                {
                    Console.WriteLine("Password min 8 simvoldan ibaret olmalidir ve passwordda min bir boyuk herf, bir kicik herf ve biir reqem olmalidir :");
                    goto Pass;
                }
            }
        }
        public void Login(string Username)
        {
            
            bool compain = true;
            foreach (var item in users)
            {
                if (Username == item.Username)
                {
                    compain = false;
                    Console.WriteLine("zehmet olmasa passwordu girin");
                    string Password = Console.ReadLine();
                    if (Password == item.Password)
                    {
                    Console.WriteLine($"name:{item.Name} Surname:{item.Surname} Email:{item.Email}");
                    
                    }
                    else { Console.WriteLine("Sifre yanlisdir"); }
                }
            }
            if (compain) { Console.WriteLine("bele user yoxdu"); }
        }
        public void SeeAllUsers()
        {
            foreach (User item in users)
            {
                Console.WriteLine($"name:{item.Name} Surname:{item.Surname} Email:{item.Email}");
            }
        }
        public void GetOneUser(string random)
        {
            bool succes = true;
            foreach (var item in users)
            {
                string usernamelower = item.Username.ToLower();
                if (item.Username.Contains(random))
                {
                    Console.WriteLine($"name:{item.Name} Surname:{item.Surname} Email:{item.Email}");
                    succes = false;
                }
            }
            if (succes) { Console.WriteLine("not found"); }
        }
        public void GetOneUserCase5a(string usernamecase5)
        {
            bool succes = true;
            foreach (var item in users)
            {

                if (usernamecase5 == item.Username)
                {
                    Console.WriteLine($"name:{item.Name} Surname:{item.Surname} Email:{item.Email}");
                    succes = false;
                    Console.WriteLine("Changed name:");
                    string changedname = Console.ReadLine();
                    item.Name = changedname;
                    item.Username = item.Name + "." + item.Surname;
                }

            }
            if (succes) { Console.WriteLine("not found"); }
        }
        public void GetOneUserCase5b(string usernamecase5)
        {
            bool succes = true;
            foreach (var item in users)
            {

                if (usernamecase5 == item.Username)
                {
                    Console.WriteLine($"name:{item.Name} Surname:{item.Surname} Email:{item.Email}");
                    succes = false;
                    Console.WriteLine("Changed name:");
                    string changedname = Console.ReadLine();
                    item.Surname = changedname;
                    item.Username = item.Name + "." + item.Surname;
                }

            }
            if (succes) { Console.WriteLine("not found"); }
        }
        public void GetOneUserCase5c(string usernamecase5)
        {
            bool succes = true;
            foreach (var item in users)
            {

                if (usernamecase5 == item.Username)
                {
                    Console.WriteLine($"name:{item.Name} Surname:{item.Surname} Email:{item.Email}");
                    succes = false;
                    Console.WriteLine("Changed username:");
                    string changedname = Console.ReadLine();
                    item.Username = changedname;
                }

            }
            if (succes) { Console.WriteLine("not found"); }
        }
        public void GetOneUserCase5d(string usernamecase5)
        {
            bool succes = true;
            foreach (var item in users)
            {

                if (usernamecase5 == item.Username)
                {
                    Console.WriteLine($"name:{item.Name} Surname:{item.Surname} Email:{item.Email}");
                    succes = false;
                    Console.WriteLine("Changed email:");
                    string changedname = Console.ReadLine();
                    item.Email = changedname;
                }

            }
            if (succes) { Console.WriteLine("not found"); }
        }
        public bool GetOneUserBool(string random)
        {
            bool succes = false;
            foreach (var item in users)
            {
                string usernamelower = item.Username.ToLower();
                if (item.Username.Contains(random))
                {
                    succes = true;
                    return succes;
                }
            }
            return succes;
        }
        public void Delete(string username)
        {
            int a = 0;
            User[] coppy = new User[users.Length-1];
            if (GetOneUserBool(username)) 
            { 
                for (int i = 0; i < users.Length; i++)
                {
                    if (users[i].Username == username)
                    {
                        continue;
                    }
                    else
                    {
                        coppy[a] = users[i];
                        a++;
                    }
                }
                Console.WriteLine($"User deleted successfully:{username}");
                users = coppy;
            }
            else
            {
                Console.WriteLine($"not fount user by this username:{username}");
            }
            
        }
        public void Again(int c)
        {
            if (c % 2 == 0)
            {
                Console.WriteLine("\n====MENYU====\n1.Regiser\n2login\n3.See all user\n4.Get one user by surname\n5.Uptade user's data\n6.Delete user from company\n7.Exit");
            }
        }
    }
}