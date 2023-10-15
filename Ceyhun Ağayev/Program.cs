using Microsoft.Win32;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            bool quit = true;
            int menyu = 0;

            Console.WriteLine("====MENYU====\n1.Regiser\n2login\n3.See all user\n4.Get one user by surname\n5.Uptade user's data\n6.Delete user from company\n7.Exit");
            while (quit)
            {
                Console.WriteLine("\nPlease choose:");
                CORRECT_A:
                string a = Console.ReadLine();
                menyu ++;
                int c;
                if (Int32.TryParse(a, out c))
                {
                    
                    if (c >= 0 && c <= 7)
                    {
                        switch (c)
                        {
                            case 1:
                                Console.WriteLine("Zehmet olmasa adiniz girin");
                                string Name = Console.ReadLine();
                                Console.WriteLine("Zehmet olmasa soyadiniz girin");
                                string Surname = Console.ReadLine();
                                company.Register(Name, Surname);
                                company.Again(menyu);
                                break;
                            case 2:
                                Console.WriteLine("zehmet olmasa username girin");
                                string username = Console.ReadLine();
                                company.Login(username);
                                company.Again(menyu);
                                break;
                            case 3:
                                company.SeeAllUsers();
                                company.Again(menyu);
                                break;
                            case 4:
                                Console.WriteLine("username daxil edin:");
                                string random = Console.ReadLine();
                                company.GetOneUser(random);
                                company.Again(menyu);
                                break;
                            case 5:
                                Console.WriteLine("a. Update name\nb. Update surname\nc. Update username\nd. Update email");
                                string b = Console.ReadLine();
                                switch (b)
                                {
                                    case "a":
                                        Console.WriteLine("username daxil edin:");
                                        string usernamecase5a = Console.ReadLine();
                                        company.GetOneUserCase5a(usernamecase5a);
                                        break;
                                    case "b":
                                        Console.WriteLine("username daxil edin:");
                                        string usernamecase5b = Console.ReadLine();
                                        company.GetOneUserCase5b(usernamecase5b);
                                        break;
                                    case "c":
                                        Console.WriteLine("username daxil edin:");
                                        string usernamecase5c = Console.ReadLine();
                                        company.GetOneUserCase5c(usernamecase5c);
                                        break;
                                    case "d":
                                        Console.WriteLine("username daxil edin:");
                                        string usernamecase5d = Console.ReadLine();
                                        company.GetOneUserCase5d(usernamecase5d);
                                        break;
                                }
                                company.Again(menyu);
                                break;
                            case 6:
                                Console.WriteLine("username daxil edin:");
                                string usernamecase6 = Console.ReadLine();
                                company.Delete(usernamecase6);
                                company.Again(menyu);
                                break;
                            case 7:
                                quit = false;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Choose number about 1-7");
                        goto CORRECT_A;
                    }
                }
                else
                {
                    Console.WriteLine("Choose number about 1-7");
                    goto CORRECT_A;
                }
            }
        }
    }
}