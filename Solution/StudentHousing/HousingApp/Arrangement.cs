using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingApp
{
    public class Arrangement
    {
        private string messages;

        public Arrangement(string messages)
        {
            this.messages = messages;
        }

        public string GetMessages() 
        { return messages; }
    }
}
