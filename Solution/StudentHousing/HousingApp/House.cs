using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingApp
{
    internal class House
    {
        private int HouseNumber;
        private List<Student> studentsInHouse;
        private Admin admin;

        public House(int houseNumber)
        {
            HouseNumber = houseNumber;
            studentsInHouse= new List<Student>();
              
        }

        public void SetAdmin(Admin admin)
        {
            this.admin = admin; 
        }

        public void AddStudentToHouse(Student student)
        {
            studentsInHouse.Add(student);   
        }
    }
}
