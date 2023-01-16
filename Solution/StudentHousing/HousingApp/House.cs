using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HousingApp
{
    [DataContract]
    public class House
    {
        [DataMember]
        public int Housenumber { get; set; }
        [DataMember]
        private List<Complaint> complaints= new List<Complaint>();
        [DataMember]
        private List<Announcement> announcements= new List<Announcement>();
        [DataMember]
        private List<Task> tasks= new List<Task>();

        public House(int housenumber)
        {
            Housenumber = housenumber;
        }

        public override string ToString()
        {
            string number = Convert.ToString(Housenumber);
            return number;
        }

        public List<Task>GetTasks()
        {
            return tasks;
        }
        public List<Announcement> GetAnnouncements()
        {
            return announcements;
        }
        public List<Complaint> GetComplaints()
        {
            return complaints;
        }
        public void AddTask(Task task)
        {
            tasks.Add(task);
        }
        public void AddComplaint(Complaint complaint)
        {
            complaints.Add(complaint);
        }
        public void AddAnnouncement(Announcement announcement)
        {
            announcements.Add(announcement);    
        }

        public void RemoveTask(Task task)
        {
            tasks.Remove(task);
        }
    }
}
    
