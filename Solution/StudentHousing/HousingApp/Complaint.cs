﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HousingApp
{
    [DataContract]
    public class Complaint
    {
        
        public Complaint(string title, string description, string date)
        {
            Title = title;
            Description = description;
            Date = date;
        }


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
