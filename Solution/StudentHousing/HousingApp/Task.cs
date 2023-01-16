using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HousingApp
{
    [DataContract]
    public class Task
    {

        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Date { get; set; }
        [DataMember]
        public string? Assignment { get; set; }


        public Task(string title, string description, string date)
        {
            Title = title;
            Description = description;
            Date = date;
        }

        public Task(string title, string description, string date, string assignment)
        {
            Title = title;
            Description = description;
            Date = date;
            Assignment = assignment;
        }

        public override string ToString()
        {
            return $"{Title}(for: {Assignment})";
        }

        
    }
}
