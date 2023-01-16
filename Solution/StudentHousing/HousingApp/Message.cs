using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HousingApp
{
    [DataContract]
    public class Message
    {
        public Message(string title, string body)
        {
            Title = title;
            Body = body;
        }

        public Message(string title, string body, string from)
        {
            Title = title;
            Body = body;
            From = from;
        }

        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Body { get; set; }
        [DataMember]
        public string From { get; set; }
        
        public override string ToString()
        {
            return Title;
        }

    }
}
