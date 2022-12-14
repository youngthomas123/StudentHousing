using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingApp
{
    public class Admin
    {
        private string FirstName;
        private string LastName;
        private Login login;

        public Admin(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            
        }
        public void SetLogin(string username, string password)
        {
            login = new Login(username, password);
        }


    }
}
