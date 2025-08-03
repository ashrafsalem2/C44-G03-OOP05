using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Q02
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        Dictionary<string, int> users = new Dictionary<string, int>();
        Dictionary<string, string> roles = new Dictionary<string, string>();

        public string? Name { get; set; }
        public int Password { get; set; }
        private bool IsLogin { get; set; }

        public BasicAuthenticationService(string _Name, int _Password)
        {
            Name = _Name;
            Password = _Password;

            users.Add("Hossam", 123);
            users.Add("Ahmed", 456);

            roles.Add("Hossam", "Admin");
            roles.Add("Ahmed", "User");

            IsLogin = false;
        }



        public bool AuthenticateUser()
        {
            if (Name != null && Password != 0) 
                foreach (var entry in users)
                     if(Name == entry.Key.ToString() && Password == entry.Value)
                        IsLogin = true;
                       
            return IsLogin;
        }

        public void AuthorizeUser()
        {
            if (IsLogin)
            {
                foreach (var entry in roles)

                    if (Name == entry.Key.ToString())
                        Console.WriteLine($"Welcome {Name}, You are Our {entry.Value}");
            }
            else
                Console.WriteLine("Error :( Wrong User Or Password"); 
        }
    }
}
