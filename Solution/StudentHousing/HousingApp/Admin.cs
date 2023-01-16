using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HousingApp
{
    [DataContract]
    public class Admin
    {
        [DataMember]
       public string Username { get; set; }
        [DataMember]
       public string Password { get; set; }

        [DataMember]
       public House house { get; set; }

        [DataMember]
        private List<Message> messages = new List<Message>();

        public Admin(string username, string password, House house)
        {
            Username = username;
            Password = password;
            this.house = house;
        }

        public void AddMessage( Message message)
        {
            messages.Add(message);
        }

        public List<Message> GetMessage()
        {
            return messages;
        }
       
       


    }
}
