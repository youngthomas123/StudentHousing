using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace HousingApp
{
    [DataContract]
    public class Building
    {
        [DataMember]
        private List<House> houses= new List<House>();
        [DataMember]
        private List<Student> students= new List<Student>();
        [DataMember]
        private List<Admin> admins= new List<Admin>();  
        
        public Building ()
        {
            //create houses and add to list (dont change)
            House h1 = new House(1);     
            houses.Add(h1);
            House h2 = new House(2);
            houses.Add(h2);
            House h3 = new House(3);
            houses.Add(h3);
            House h4 = new House(4);
            houses.Add(h4);

            // create admins and add to list (dont change)
            Admin a1 = new Admin("admin1", "one", h1);
            admins.Add(a1);
            Admin a2 = new Admin("admin2", "two", h2);
            admins.Add(a2);
            Admin a3 = new Admin("admin3", "three", h3);
            admins.Add(a3);
            Admin a4 = new Admin("admin4", "four", h4);
            admins.Add(a4);





            // test data

            Student s1 = new Student("First", "Last", "thomas", "abc", h1);
            students.Add(s1);
            Student s2 = new Student("jon", "doe", "xqc" , "password1", h1);
            students.Add(s2);
            Student s3 = new Student("messi", "pessi", "goat", "password2", h2);
            students.Add(s3);
            Student s4 = new Student("ronaldo", "sui", "lol" ,"password3" ,h2); 
            students.Add(s4);

            Task t1 = new Task("test title1", "test description1", "today");
            h1.AddTask(t1);
            Complaint com1 = new Complaint("Test cmoplaint title1", "test complaint description1", "today");
            h1.AddComplaint(com1);
            Announcement an1 = new Announcement("test announcement title1", "test ann description", "today");
            h1.AddAnnouncement(an1);
                
        }

        

        public List<House> GetHouse()
        {
            return houses;  
        }
        public List<Student>GetStudents()
        {
            return students;
        }
        public List<Admin> GetAdmins()
        {
            return admins;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void Repair()
        {
            foreach(House RealHouse in houses)
            {
                foreach(Student student in students)
                {
                    if(student.house.Housenumber == RealHouse.Housenumber)
                    {
                        student.house = RealHouse;
                    }
                }
                foreach(Admin admin in admins)
                {
                    if(admin.house.Housenumber == RealHouse.Housenumber)
                    {
                        admin.house = RealHouse;
                    }
                }
            }
        }
       
       
    }
}
