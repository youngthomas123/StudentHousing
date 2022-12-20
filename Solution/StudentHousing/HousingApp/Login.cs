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
        private int UniqueId = 0;

        public Login() { }
        public Login(string userName, string password)
        {
            UserName = userName;
            Password = password;
            Random random = new Random();
            UniqueId = random.Next(10000, 100000);
        }
        public string GetUsername()
        {
            return UserName;
        }
        public string GetPassword()
        {
            return Password;
        }
        public int GetUniqueId()
        {
            return UniqueId;
        }
        
            

    }
}
