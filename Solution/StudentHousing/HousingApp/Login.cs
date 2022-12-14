using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HousingApp
{
    public class Login
    {

        private string UserName;
        private string Password;
        private int UniqueId =0;

        public Login(string userName, string password)
        {
            UserName = userName;
            Password = password;
            Random random= new Random();
            UniqueId= random.Next(1000, 10000);    
        }
        public string GetUsername()
        {
            return UserName;
        }
        public string GetPassword() 
        { 
            return Password;
        }

    }
}
