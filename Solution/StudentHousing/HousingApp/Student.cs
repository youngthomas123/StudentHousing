using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HousingApp
{
    public class Student
    {
        private string FirstName;
        private string LastName;
        Login login;
        Rent rent;
        House house;
        List<Task> tasks;
        List<Complaint> complaints;
        List<Arrangement> arrangements;

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            tasks = new List<Task>();
            complaints = new List<Complaint>();
            arrangements = new List<Arrangement>();
        }
          
        public string GetFirstName()
        {
            return FirstName;
        }
        public string GetLastName()
        {
            return LastName;
        }


    }
}
