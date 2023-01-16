using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HousingApp
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public string Firstname { get; set; }
        [DataMember]
        public string Lastname { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public House house { get; set; }    

        public Student(string firstname, string lastname, string username, string password, House house)
        {
            Firstname = firstname;
            Lastname = lastname;
            Username = username;
            Password = password;
            this.house = house;
        }
        [DataMember]
        public int Rent { get; set; }
        [DataMember]
        private List<Message>messages = new List<Message>();  

        public override string ToString()
        {
            return $"{Firstname} {Lastname}";
        }
        public List<Message>GetMessages()
        {
            return messages;
        }
        public void AddMessage(Message Message)
        {
           this.messages.Add(Message);
        }

    }
}
