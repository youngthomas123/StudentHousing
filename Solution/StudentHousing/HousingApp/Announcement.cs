using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HousingApp
{
    [DataContract]
    public class Announcement

    {
        public Announcement(string title, string description, string date)
        {
            Title = title;
            Description = description;
            Date = date;
        }

        [DataMember]
        public string? Firstname { get; set; }

        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Date { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }

    
}
