using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace HousingApp
{
    public class Building
    {
        private int NumOfStudents;
        private int NumberOfAdmins;
        private int NumOfHouse;
        private List<Student> AllStudents;
        private List<House> AllHouse;
        private List<Admin> AllAdmins;


        public void AddStudents(Student student)
        {
            AllStudents.Add(student);
        }

        public List<Student> GetStudents()
        {
            return this.AllStudents;
        }
    }
}
